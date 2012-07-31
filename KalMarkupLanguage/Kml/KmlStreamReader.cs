using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ArturasServer.KalOnline.Kml.Exceptions;
using System.Windows.Forms;
using System.Drawing;

namespace ArturasServer.KalOnline.Kml
{

    class KmlStreamReader
    {
        private const char COMMENT_CHAR = ';';
        private const char END_COMMENT_CHAR = '\r';
        private const char OPEN_NODE_CHAR = '(';
        private const char CLOSE_NODE_CHAR = ')';
        private const char VALUE_SEPERATOR_CHAR = ' ';
        private const char QUOTE_CHAR = '"';
        private const char ESCAPE_CHAR = '\\';

        //stream we are reading from
        public Stream Stream;
        //our reader
        TextReader reader;
        //our document
        KmlDocument Document;
        //out current position within the souce
        CharPosition Position = new CharPosition(1, 1, -1);
        //holds out comments
        List<KmlComment> CommentBuffer = new List<KmlComment>();

        public KmlStreamReader(Stream Stream, KmlDocument Document)
        {
            this.Stream = Stream;
            reader = new StreamReader(Stream);
            this.Document = Document;
        }

        /// <summary>
        /// Tracks the position of the character being read.
        /// </summary>
        /// <param name="c"></param>
        private void TrackPosition(char c)
        {
            if (c == '\r')
            {
                Position.Row++;
                Position.Column = 0;
                Position.Offset++;
            }
            else if (c == '\n')
            {
                Position.Offset++;
            }
            else
            {
                Position.Column++;
                Position.Offset++;
            }
        }

        /// <summary>
        /// Returns the current CharPosition
        /// </summary>
        /// <returns></returns>
        private CharPosition GetCurrentPosition()
        {
            return new CharPosition(this.Position.Row, this.Position.Column, this.Position.Offset);
        }

        /// <summary>
        /// Beings to read from the stream.
        /// </summary>
        /// <returns></returns>
        public void Read()
        {
            //read everything in steam
            while (reader.Peek() >= 0)
            {
                char c = (char)reader.Read();
                //keep track of characters read
                TrackPosition(c);
                //check for end/start of line
                if(c == COMMENT_CHAR)
                {
                    //read the comment
                    ReadComment(Document);
                }
                else if (c == OPEN_NODE_CHAR)
                {
                    //add nodes to parent
                    KmlNode rn = ReadNode(null);
                    Document.ChildNodes.Add(rn);
                }
                else if (Char.IsWhiteSpace(c) || Char.IsSeparator(c))
                {
                    //do nothing
                }
                else if (c == CLOSE_NODE_CHAR)
                {
                    throw new InvalidKmlSyntaxException(GetCurrentPosition(), new UnopenedNodeException(Position));
                }
                else
                {
                    throw new InvalidKmlSyntaxException(GetCurrentPosition(), new InvalidCharacterException(c, Position));
                }
                
            }
            reader.Close();
        }

        /// <summary>
        /// Reads a string from the stream
        /// </summary>
        /// <returns></returns>
        public string ReadString()
        {
            StringBuilder buffer = new StringBuilder();
            bool escaped = false;
            bool end = false;

            //record start position for errors
            CharPosition startPosition = GetCurrentPosition();

            while (!end)
            {
                //check if we are at end of stream
                if (reader.Peek() < 0)
                {
                    throw new InvalidKmlSyntaxException(GetCurrentPosition(), new UnclosedStringException(startPosition));
                }
                char c = (char)reader.Read();

                //keep track of characters read
                TrackPosition(c);

                if (c == ESCAPE_CHAR && !escaped)
                {
                    escaped = true;
                }
                else if (c == QUOTE_CHAR && !escaped)
                {
                    end = true;
                }
                else
                {
                    escaped = false;
                    buffer.Append(c);
                }
            }
            //MessageBox.Show("Done");
            return buffer.ToString();
        }

        /// <summary>
        /// Reads a comment from the stream
        /// </summary>
        /// <returns></returns>
        public void ReadComment(KmlNode Node)
        {
            StringBuilder buffer = new StringBuilder();
            bool end = false;

            //record start position for errors
            CharPosition startPosition = GetCurrentPosition();

            while (!end)
            {
                //check if we are at end of stream
                if (reader.Peek() < 0)
                {
                    break;
                }

                char c = (char)reader.Read();

                //keep track of characters read
                TrackPosition(c);

                if (c == END_COMMENT_CHAR)
                {
                    end = true;
                }
                else
                {
                    buffer.Append(c);
                }
            }

           CommentBuffer.Add(new KmlComment(buffer.ToString(), startPosition, GetCurrentPosition()));
        }

        public KmlNode ReadNode(KmlNode Parent)
        {
            StringBuilder buffer = new StringBuilder();
            bool end = false;
            bool readingValue = false;

            //record start position
            CharPosition nodeStartPosition = GetCurrentPosition();
            CharPosition valueStartPosition = GetCurrentPosition();

            //node to store values in
            KmlNode node = new KmlNode(nodeStartPosition);

            //unload comments
            node.Comments.AddRange(CommentBuffer);
            CommentBuffer.Clear();
            while (!end)
            {
                //check if we are at end of stream
                if (reader.Peek() < 0)
                {
                    throw new InvalidKmlSyntaxException(GetCurrentPosition(), new UnclosedNodeException(nodeStartPosition));
                }
                char c = (char)reader.Read();
                //keep track of characters read
                TrackPosition(c);
                //check for comment
                if (c == COMMENT_CHAR)
                {
                    ReadComment(node);
                    continue;
                }
                //check if we are reading whitespace
                if (Char.IsWhiteSpace(c) || Char.IsSeparator(c) || c== CLOSE_NODE_CHAR)
                {
                    //check if we have finished reading the node
                    if (c == CLOSE_NODE_CHAR)
                    {
                        //end reading
                        end = true;
                    }
                    //check if we have been reading a value
                    if (readingValue)
                    {
                        //create new value
                        KmlValue val = new KmlValue(buffer.ToString(), false, valueStartPosition, GetCurrentPosition());
                        //give it out comments
                        val.Comments.AddRange(CommentBuffer);
                        //clear out our comments
                        CommentBuffer.Clear();
                        //put the buffer into a value
                        node.Values.Add(val);
                        //finished reading value
                        readingValue = false;
                        //clear buffer
                        buffer = new StringBuilder();
                    }
                    //if not ignore
                }
                else
                {
                    
                    //check if theres another node to read
                    if (c == OPEN_NODE_CHAR)
                    {
                        //read the node and add to child nodes
                        KmlNode rn = ReadNode(null);
                        node.ChildNodes.Add(rn);
                    }
                    //check if theres a string to read
                    else if (c == QUOTE_CHAR)
                    {
                        //end pos
                        CharPosition valueEndPosition = GetCurrentPosition();
                        //create our value
                        KmlValue val = new KmlValue(ReadString(), true, valueStartPosition, valueEndPosition);
                        
                        //give it out comments
                        val.Comments.AddRange(CommentBuffer);
                        //clear out our comments
                        CommentBuffer.Clear();
                        //read the string and add it to values
                        node.Values.Add(val);
                    }
                    else
                    {
                        //check if we are reading a value
                        if (!readingValue)
                        {
                            //we arnt reading a value - but we are now
                            readingValue = true;
                            //set value start post
                            valueStartPosition = GetCurrentPosition();
                        }
                        //add the character to the buffer
                        buffer.Append(c);
                        //MessageBox.Show(c.ToString()); 
                    }
                }
            }

            node.EndPosition = new CharPosition(Position.Row, Position.Column + 1, Position.Offset + 1);

            return node;

        }
    }
}
