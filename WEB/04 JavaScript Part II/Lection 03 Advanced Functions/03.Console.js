var specialConsole = (function () {
    function _format(str /*, params */) {
        var selfArguments = arguments;
 
        return str.replace(/\{(\d+)\}/g, function (match, p1) {
            return selfArguments[+p1 + 1];
        });
    }
 
    return {
        writeLine: function () {
            console.log(_format.apply(null, arguments));
        },
 
        writeError: function () {
            console.error(_format.apply(null, arguments));
        },
 
        writeWarning: function () {
            console.warn(_format.apply(null, arguments));
        }
    };
}());
 
specialConsole.writeLine("Message: hello");
specialConsole.writeLine("Message: {0}, {1}!", "Hello", "Pesho");
specialConsole.writeError("Error: {0}", "Something happened");
specialConsole.writeWarning("Warning: {0}", "A warning");