<?php
//init connects to mysql
include("init.php");

include("functions.php");

$command = $_REQUEST['command'];
if($command == "GetVersion")
{
	echo GetVersion();
}

if($command == "GetLauncherVersion")
{
	echo "0.9";
}

if($command == "GetLauncherUpdateURL")
{
	echo "http://arturasserver.com/launcher_update.zip";
}
else if($command == "GetNextVersion")
{
	echo GetNextVersion(str_replace(",",".",$_REQUEST['arg1'])+0);
}
else if($command == "GetUpdateNotes")
{
	echo GetUpdateNotes(str_replace(",",".",$_REQUEST['arg1'])+0);
}
else if($command == "GetNotice")
{
	echo GetNotice();
}
else if($command == "GetUpdateURL")
{
	echo GetUpdateURL(str_replace(",",".",$_REQUEST['arg1'])+0);
}
else if($command == "GetFileMD5")
{
	echo GetFileMD5($_REQUEST['arg1']);
}
else if($command == "GetLauncherArgs")
{
	echo GetLauncherArgs();
}
else if($command == "GetStatus")
{
	$ip = "localhost";
	$port = 30001;
	$fp = @fsockopen ($ip, $port, $errno, $errstr, 5); 
	if ($fp) 
	{
		echo 0;
	}
	else
	{	
		echo 0;
	}
}
?>