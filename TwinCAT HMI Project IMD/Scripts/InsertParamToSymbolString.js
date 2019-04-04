// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var InsertParamToSymbolString = function (Symbol,Param1,Param2) {
        var symbol = '%s%';
        var value;
        //console.log(Symbol);
        var newSymbol = Symbol.replace('[1]', Param1);
        //console.log(newSymbol);
        var finalSymbol = newSymbol.replace('[2]', Param2);
        //console.log(finalSymbol);
        symbol += finalSymbol;
        symbol += '%/s%';

        console.log(symbol);

        //var readSymbol = new TcHmi.Symbol(symbol);
        //console.log(readSymbol);
        //readSymbol.readEx(function (data) {
        //    if (data.error === TcHmi.Errors.NONE) {
        //        // Handle result value... 
        //        value = data.value;
        //        console.log(value);

        //        return value;
        //    } else {
        //        // Handle error... 
        //        console.log(data);

        //        return -1;
        //    }
        //});

        TcHmi.Symbol.readEx2(symbol, function (data) {
            if (data.error === TcHmi.Errors.NONE) {
                // Handle result value... 
                value = data.value;
                console.log(value);
                return value;
            } else {
                // Handle error... 
                console.log(data);
                return -1;
            }
        });
    };
    
    TcHmi.Functions.registerFunction('InsertParamToSymbolString', InsertParamToSymbolString);
})(TcHmi);