// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var GetStatusText = function (Symbol,itemID,StatusTextList) {
        //console.log(Symbol);
        //console.log(itemID);
        //console.log(StatusTextList);

        var locale = TcHmi.Locale.get();
        //console.log(locale);

        //console.log(StatusTextList[locale][itemID][Symbol]);

        var text = StatusTextList[locale][itemID][Symbol];
        return text;
    };
    
    TcHmi.Functions.registerFunction('GetStatusText', GetStatusText);
})(TcHmi);