// Keep this lines for a best effort IntelliSense of Visual Studio 2017.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.d.ts" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Controls\System\TcHmiControl\Source.d.ts" />

// Keep this lines for a best effort IntelliSense of Visual Studio 2013/2015.
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\Lib\jquery\jquery.js" />
/// <reference path="C:\TwinCAT\Functions\TE2000-HMI-Engineering\Infrastructure\TcHmiFramework\Latest\TcHmi.js" />

/*
 * Generated 3/21/2019 8:08:02 AM
 * Copyright Pim 2019
 * 
 * destinationdirectory:        C:\Users\Pim\Documents\GitHub\TwinCAT3HMI\FrameworkControlTesting
 * TcHmi_DefaultParameters:     [$guid1$, 2b21ef41-40c6-4658-9b4f-44c40ef94fd1] | [$guid2$, 09d61eb4-9c06-4470-bc9d-6747d361202e] | [$guid3$, 90c8ae47-e264-4b91-927c-669604ee7798] | [$guid4$, ae1e82b3-9d3c-4f75-958d-e73cfa279e00] | [$guid5$, c11ddf62-98fc-4bf8-b2af-a1b1734ac49a] | [$guid6$, df2d9cbf-2dee-4add-a78d-eef9d027bb12] | [$guid7$, b0029b7b-478d-42eb-872c-ed627f8d7d75] | [$guid8$, ed7d8179-fa1b-4003-b147-1a4a6410a95f] | [$guid9$, a7c80fd0-697c-4a2c-8066-483a50a8a703] | [$guid10$, 8eb3389d-72a6-4a9b-866b-e2d8b5fc952f] | [$time$, 3/21/2019 8:08:02 AM] | [$year$, 2019] | [$username$, Pim] | [$userdomain$, LAPTOP-IQO77BGT] | [$machinename$, LAPTOP-IQO77BGT] | [$clrversion$, 4.0.30319.42000] | [$registeredorganization$, ] | [$runsilent$, False] | [$targetframeworkversion$, 4.6.1] | [$solutiondirectory$, C:\Users\Pim\Documents\GitHub\TwinCAT3HMI\] | [$projectname$, FrameworkControlTesting] | [$safeprojectname$, FrameworkControlTesting] | [$currentuiculturename$, en-US] | [$installpath$, C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\] | [$specifiedsolutionname$, FrameworkControlTesting] | [$exclusiveproject$, False] | [$destinationdirectory$, C:\Users\Pim\Documents\GitHub\TwinCAT3HMI\FrameworkControlTesting]
 * projectname_tchmi:           FrameworkControlTesting
 * projectname_tchmi_dashcase:  framework-control-testing
 * safeprojectname:             FrameworkControlTesting
 * projectname:                 FrameworkControlTesting
 */

/**
*  Namespace: TcHmi
*  [REQUIRED]
*/
(function (TcHmi) {
    /**
    *  Namespace: TcHmi.Controls
    *  [REQUIRED]
    */
    (function (Controls) {
        /**
         *  Namespace: TcHmi.Controls.Custom
         *  [CUSTOM]
         */
        var Custom;
        (function (Custom) {
            /** FrameworkControlTesting object */
            var FrameworkControlTesting = (function (_super) {
                __extends(FrameworkControlTesting, _super);

                /*
                Attribute philosophy
                --------------------
                - Local variables are not set while definition in class, so they have the value 'undefined'.
                - On compile the Framework sets the value from HTML or from theme (possibly 'null') via normal setters
                - The "changed detection" in the setter will result in processing the value only once while compile
                - Attention: If we have a Server Binding on an Attribute the setter can be very late or never (leaving the value = undefined).
                */

                /**
                 * @description Constructor of the control
                 * @param {JQuery} element Element from HTML (internal, do not use)
                 * @param {JQuery} pcElement precompiled Element (internal, do not use)
                 * @param {TcHmi.Controls.ControlAttributeList} attrs Attributes defined in HTML in a special format (internal, do not use)
                 * @returns {void}
                 */
                function FrameworkControlTesting(element, pcElement, attrs) {
                    /** Call base constructor */
                    _super.call(this, element, pcElement, attrs);

                    
                }

                /** 
                * @description Is called during control initialize phase before attribute setter are called based on initial html dom values. 
                * @returns {void}
                */
                FrameworkControlTesting.prototype.__previnit = function () {
                    /** Handle template elements. Should be done before call to __previnit of super class. */
                    this.__elementTemplateRoot = this.__element.find('.framework-control-testing-template');
                    this.__myUL = this.__elementTemplateRoot.find('#myUl');
                    this.__toggler = this.__myUL.find('.caret');
                    
                    /** Call __previnit of super class with the correct instance. */
                    _super.prototype.__previnit.call(this);
                };
                /** 
                 * @description Is called during control initialize phase after attribute setter have been called based on it's default or initial html dom values. 
                 * @returns {void}
                 */
                FrameworkControlTesting.prototype.__init = function () {
                    /** Call __init of super class with the correct instance. */
                    _super.prototype.__init.call(this);

                    
                };
                /**
                * @description Is called after the control instance gets part of the current DOM.
                * Is only allowed to be called from the framework itself!
                * @returns {void}
                */
                FrameworkControlTesting.prototype.__attach = function () {
                    /** Call __attach of super class with the correct instance. */
                    _super.prototype.__attach.call(this);

                    /**
                     * Initialize everything which is only available while the control is part of the active dom.
                     */

                    // Uncomment the next line to make the Treeview collapsable by the user
                    //var caret = $('.caret');

                    // Give each caret a onClick function
                    caret.bind('click', function () {
                        //console.log("Clicked the caret!");
                        //console.log($(this));
                        $.each($(this), function (key, value) {
                            //console.log(value.parentElement.children);
                            $.each(value.parentElement.children, function (key, value) {
                                if (value.classList.contains("nested")) {
                                    value.classList.toggle('active');
                                }
                            });
                        });
                        $(this)[0].classList.toggle('caret-down');
                    });

                    //// Simple jQuery for when the button gets pressed
                    //this.__firstButton.on('click', function (e) {
                    //    e.preventDefault();
                    //    console.log("Button pressed!" + this.__buttonValue);
                    //    // Doesn't fire
                    //    TcHmi.EventProvider.raise(this.__id + '.onMyCustomEvent');
                    //});

                };
                /**
                * @description Is called after the control instance is no longer part of the current DOM.
                * Is only allowed to be called from the framework itself!
                * @returns {void}
                */
                FrameworkControlTesting.prototype.__detach = function () {
                    /** Call __detach of super class with the correct instance. */
                    _super.prototype.__detach.call(this);

                    /**
                     * Disable everything which is not needed while the control is not part of the active dom.
                     * No need to listen to events for example!
                     */
                };
                /**
                * @description Destroy the current control instance. 
                * Will be called automatically if system destroys control!
                * @returns {void}
                */
                FrameworkControlTesting.prototype.destroy = function () {
                    /** Call destroy of super class with the correct instance. */
                    _super.prototype.destroy.call(this);

                    /**
                    * Free resources like child controls etc.
                    */
                };

                return FrameworkControlTesting;
            })(TcHmi.Controls.System.TcHmiControl);
            Custom.FrameworkControlTesting = FrameworkControlTesting;
        })(Custom = Controls.Custom || (Controls.Custom = {}));
        /**
        * Register control...
        */
        Controls.register('framework-control-testing', Custom.FrameworkControlTesting, 'Custom/FrameworkControlTesting/', 'Custom/FrameworkControlTesting/Template.html');
    })(Controls = TcHmi.Controls || (TcHmi.Controls = {}));
})(TcHmi);