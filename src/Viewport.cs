
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Info;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;

namespace Cordova.Extension.Commands
{
    /// <summary>
    /// </summary>
    public class Viewport: BaseCommand
    {
        /// <summary>
        /// </summary>
        public void getViewport(string options)
        {
            var resolution = (Size)DeviceExtendedProperties.GetValue("PhysicalScreenResolution");
                var height ="413";
            var width ="700"
        
            var result = "{\"width\":\"" + width + "\",\"height\":\"" + height + "\"}";

            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, result));
        }
    }
}
