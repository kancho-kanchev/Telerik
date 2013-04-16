<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<!-- 03. Create a PHP script that displays all numbers from 1 to 1000 that divide by 3 and 7 -->
	<title>Task 03</title>
</head>
<body>
<?php
	echo ("<h1>03. Create a PHP script that displays all numbers from 1 to 1000 that divide by 3 and 7</h1>");
	$numberN = jsConsole.readInteger("#tb-numberN");
	echo ("<h3>Ако приемем, че в условието се иска да се изведат числата които едновременно се делят на 3 и 7:</h3>");
	for ($i = 1; $i <= numberN; $i++) {
		if (($i % 3 == 0) && ($i % 7 == 0)) {
			echo $i." ";
		}
	}
	echo "</br>";
	echo ("<h3>Ако приемем, че в условието се иска да се изведат числата които се делят на 3 или 7:</h3>");
	for ($i = 1; $i <= numberN; $i++) {
		if (($i % 3 == 0) || ($i % 7 == 0)) {
			echo $i." ";
		}
	}
	echo "</br>";
?>
</body>