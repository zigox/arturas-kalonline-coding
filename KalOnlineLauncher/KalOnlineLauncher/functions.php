<?php
function GetVersion()
{
	$query = "SELECT * FROM updates ORDER BY version DESC";
	$result = mysql_query($query) or die(mysql_error());
	$row = mysql_fetch_array($result);
	return $row['version'];
}
function GetNextVersion($current_version)
{
	$query = "SELECT * FROM updates WHERE version > ".$current_version." ORDER BY version ASC";
	$result = mysql_query($query) or die(mysql_error());
	$row = mysql_fetch_array($result);
	return $row['version'];
}
function GetUpdateNotes($current_version)
{
	$query = "SELECT * FROM updates WHERE version = ".$current_version." ORDER BY version DESC";
	$result = mysql_query($query) or die(mysql_error());
	$row = mysql_fetch_array($result);
	return $row['notes'];
}
function GetUpdateURL($current_version)
{
	$query = "SELECT * FROM updates WHERE version = ".$current_version." ORDER BY version DESC";
	$result = mysql_query($query) or die(mysql_error());
	$row = mysql_fetch_array($result);
	return $row['url'];
}
function GetNotice()
{
	$query = "SELECT * FROM notes ORDER BY nid DESC";
	$result = mysql_query($query) or die(mysql_error());
	$row = mysql_fetch_array($result);
	return $row['text'];
}
function GetFileMD5($file)
{
	$file = mysql_real_escape_string($file);
	$query = "SELECT * FROM md5 WHERE file = '".$file."'";
	$result = mysql_query($query) or die(mysql_error());
	$row = mysql_fetch_array($result);
	return $row['hash'];
}
function GetLauncherArgs()
{
	$query = "SELECT * FROM args ORDER by aid DESC";
	$result = mysql_query($query) or die(mysql_error());
	$row = mysql_fetch_array($result);
	return $row['value'];
}
?>