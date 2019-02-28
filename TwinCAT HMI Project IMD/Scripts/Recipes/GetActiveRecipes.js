// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

(function (TcHmi) {

    var GetActiveRecipes = function (ctx,TargetControl) {
        if (!TargetControl) {
            // Stop (not abort) with null (binding without a value) or empty string
            ctx.success();

            return;    // We are running async so the return value is not used
        }
        var activeRecipe = "";
        TcHmi.Server.RecipeManagement.getActiveRecipes (function (data) {
            if (data.error === TcHmi.Errors.NONE) {
                console.log(data);
                activeRecipe = data.recipeList;
            } else {
                // Error
            }
        });
        TargetControl.setText(activeRecipe);
        return; 
    };
    
    TcHmi.Functions.registerFunction('GetActiveRecipes', GetActiveRecipes);
})(TcHmi);