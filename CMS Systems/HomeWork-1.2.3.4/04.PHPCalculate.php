<?php include_once 'header.php';?>

<?php echo ("<h1>04. Create a PHP form that accepts 3 fields - number, sign and another number.
		The form should submit to another PHP file which validates the input and calculates based
		on the numbers and the mathematical symbol. Use JavaScript for frontend validation of
		the form.</h1>"); ?>

<?php 
if (isset($_POST['send'])) {
	if( empty( $_POST['numberOne'] ) || empty( $_POST['sign'] ) || empty( $_POST['numberTwo'])) {
			//header('Location: 04.PHPForm.php'); //закоментиран защото хваща 0 за empty
	}
	
	$numberOne = $_POST['numberOne'];
	$numberTwo = $_POST['numberTwo'];
	$sign = $_POST['sign'];
	
	$accepted_signs = array( '+', '-', '*', '/' );
	
	if( ! is_numeric( $numberOne ) || ! is_numeric( $numberTwo ) || ! in_array( $sign, $accepted_signs ) ) {
		header('Location: 04.PHPForm.php');
	} else {
		echo ('Result: ' . $numberOne . ' ' . $sign . ' ' . $numberTwo .' = ');

		switch ($sign) {
			case '+':
				echo ($numberOne + $numberTwo);
				break;
			case '-':
				echo ($numberOne - $numberTwo);
				break;
			case '*':
				echo ($numberOne * $numberTwo);
				break;
			case '/': {
				if($numberTwo != 0) {
					echo ($numberOne / $numberTwo);
					break;
				}
				else {
					echo ("Divide by zero not allowed!");
					break;
				}
			}
			default : {
				header('Location: 04.PHPForm.php');
			}
		}
	}
}
?>

<?php include_once 'footer.php';?>