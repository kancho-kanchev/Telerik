<?php include_once 'header.php';?>
<!-- 03. Create a PHP script that displays all numbers from 1 to 1000 that divide by 3 and 7 -->
<!-- <title>Task 03</title> -->
<?php echo ("<h1>03. Create a PHP script that displays all numbers from 1 to 1000 that divide by 3 and 7</h1>"); ?>

	<form method="post" action="03.DivideWithoutRemainder.php" onsubmit="return validateForm()" name="myForm">
		<label>Въведете число или оставете празно за 1000</label> <input type="text" name="number" />
		<input type="submit" name="send" value="Submit" />
	</form>
<?php 
if (isset($_POST['send'])) {
	if( empty( $_POST['number'] )) {
		$number = 1000;
	}
	else {
		$number = $_POST['number'];
	}
	
	if( ! is_numeric( $number )) {
		$number = 1000;
	}
	echo "number: $number";
	
	echo ("<h3>Ако приемем, че в условието се иска да се изведат числата които едновременно се делят на 3 и 7:</h3>");
	
	for ($i = 1; $i <= $number; $i++) {
		if (($i % 3 == 0) && ($i % 7 == 0)) {//is equal ($i % 21 == 0)
			echo $i." ";
		}
	}
	echo "</br>";
	
	echo ("<h3>Ако приемем, че в условието се иска да се изведат числата които се делят на 3 или 7:</h3>");
	
	for ($i = 1; $i <= $number; $i++) {
		if (($i % 3 == 0) || ($i % 7 == 0)) {
			echo $i." ";
		}
	}
	echo "</br>";
	}
?>
	
<script type="text/javascript">
	function isNumber(n) {
		return !isNaN(parseFloat(n)) && isFinite(n);
	}

	function validateForm() {
		var a = document.forms["myForm"]["number"].value;
		if(!isNumber(a)) {
			document.forms["myForm"]["number"].value = 1000;
		}
	}
</script>

<?php include_once 'footer.php';?>