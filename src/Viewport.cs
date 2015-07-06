using System;
    using System.Collections.Generic;
    using System.IO.IsolatedStorage;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Windows;
    using System.Windows.Media;
    using Windows.Graphics.Display;
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
            


// Window Size
var bounds = Window.Current.Bounds;
var height= bounds.Height;
var width = bounds.Width;

 
          var result = "{\"width\":\"" + width + "\",\"height\":\"" + height + "\"}";
          
          
WindowSize.Text = string.Format("H {0}  x  W {1}", bounds.Height, bounds.Width);
            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, result));
        }
    }
}



