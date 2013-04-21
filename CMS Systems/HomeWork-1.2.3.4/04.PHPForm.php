<?php include_once 'header.php';?>

<?php echo ("<h1>04. Create a PHP form that accepts 3 fields - number, sign and another number.
		The form should submit to another PHP file which validates the input and calculates based
		on the numbers and the mathematical symbol. Use JavaScript for frontend validation of
		the form.</h1>"); ?>

<form method="post" action="04.PHPCalculate.php" onsubmit="return validateForm()" name="myForm"><!--за тест без javascript валидация изтрии: onsubmit="return validateForm()" -->
	<label>number one</label> <input type="text" name="numberOne" />
	<label>sign</label> <input type="text" name="sign" />
	<label>number two</label> <input type="text" name="numberTwo" />
	<input type="submit" name="send" value="Calculate" />
</form>

<script type="text/javascript">
	function isNumber(n) {
		return !isNaN(parseFloat(n)) && isFinite(n);
	}

	function isSign(n) {
		return (n === '+' || n=== '-' || n === '*' || n=== '/') ;
	}

	function validateForm() {
		var numberOne = document.forms["myForm"]["numberOne"].value;
		var sign = document.forms["myForm"]["sign"].value;
		var numberTwo = document.forms["myForm"]["numberTwo"].value;
		if(!isNumber(numberOne) ) {
			alert("Please provide a number for first argument");
			document.myForm.numberOne.focus();
			return false;
		}
		if(!isSign(sign) ) {
			alert("Please provide a sign for second argument");
			document.myForm.sign.focus();
			return false;
		}
		if(!isNumber(numberTwo) ) {
			alert("Please provide a number for third argument");
			document.myForm.numberTwo.focus();
			return false;
		}
	}
</script>

<?php include_once 'footer.php';?>