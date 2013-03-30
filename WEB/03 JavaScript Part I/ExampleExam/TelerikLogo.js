function Solve(args) {
	var intNumberX = parseInt(args[0]);
	var intHeightOfTheTree = (intNumberX + 1) / 2;
	var intCountInRow = 1;
	var intCountRow = 0;
	var intCharNumbers = intHeightOfTheTree * intHeightOfTheTree;
	var charSimbol = '*';
	var charSimbolEmpty = '.';
	var intWriteSimbol = 1;
	var stringRowToWrite = "";
	var stringResult = "";
	while (intWriteSimbol <= intCharNumbers) {
		for (var i = 1; i <= intCountInRow; i++) {
			if (intWriteSimbol <= intCharNumbers) intWriteSimbol++;
		}
		intCountInRow = intCountInRow + 2;
	}
	intWriteSimbol = 1;
	intCountRow = ((intCountInRow + 1) / 2) - 1;
	intCountInRow = intCountInRow - 2;
	for (var i = 1; i <= intCountRow; i++) {
		for (var j = 1; j <= intCountInRow; j++) {
			if ((j == (((intCountInRow - intWriteSimbol) / 2)) + 1) || (j == ((intCountInRow - intWriteSimbol) / 2) + intWriteSimbol)) {
				stringRowToWrite = stringRowToWrite + charSimbol;
			}
			else {
				stringRowToWrite = stringRowToWrite + charSimbolEmpty;
			}
		}
		for (var j = 1; j <= intCountInRow - 2; j++) {
			stringRowToWrite = stringRowToWrite + charSimbolEmpty;
		}
		for (var j = 1; j <= intCountInRow; j++) {
			if ((j == (((intCountInRow - intWriteSimbol) / 2)) + 1) || (j == ((intCountInRow - intWriteSimbol) / 2) + intWriteSimbol)) {
				stringRowToWrite = stringRowToWrite + charSimbol;
			}
			else {
				stringRowToWrite = stringRowToWrite + charSimbolEmpty;
			}
		}
		intWriteSimbol = intWriteSimbol + 2;
		//****************************************Console.WriteLine(rowToWrite);
		stringResult = stringResult + stringRowToWrite + "\r\n";
		stringRowToWrite = "";
	}
	intHeightOfTheTree = intNumberX * 3 - 2 - (intNumberX + 1) / 2;
	intCountRow = intHeightOfTheTree;
	for (var i = 1; i <= intCountRow - intNumberX + 1; i++) {
		for (var j = 1; j <= intNumberX * 3 - 2; j++) {
			if ((j == (((intCountInRow - intWriteSimbol) / 2) + intNumberX + 1 + (intNumberX * 3 - 2 - intNumberX * 2))) || (j == ((intCountInRow - intWriteSimbol) / 2) + intWriteSimbol)) {
				stringRowToWrite = stringRowToWrite + charSimbol;
			}
			else {
				stringRowToWrite = stringRowToWrite + charSimbolEmpty;
			}
		}
		intWriteSimbol = intWriteSimbol + 2;
		//***************************************Console.WriteLine(rowToWrite);
		stringResult = stringResult + stringRowToWrite + "\r\n";
		stringRowToWrite = "";
	}
	intHeightOfTheTree = intNumberX - 1;
	intCountRow = intHeightOfTheTree;
	intWriteSimbol = (3);
	for (var i = 1; i <= intCountRow; i++) {
		for (var j = 1; j <= intNumberX * 3 - 2; j++) {
			if ((j == (((intCountInRow - intWriteSimbol) / 2) + intNumberX + 1 + (intNumberX * 3 - 2 - intNumberX * 2))) || (j == ((intCountInRow - intWriteSimbol) / 2) + intWriteSimbol)) {
				stringRowToWrite = stringRowToWrite + charSimbol;
			}
			else {
				stringRowToWrite = stringRowToWrite + charSimbolEmpty;
			}
		}
		intWriteSimbol = intWriteSimbol + 2;
		//******************************************Console.WriteLine(rowToWrite);
		stringResult = stringResult + stringRowToWrite + "\r\n";
		stringRowToWrite = "";
	}

	return stringResult;
}