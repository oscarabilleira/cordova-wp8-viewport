using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows;
using Windows.Graphics.Display;
using System.Windows.Media;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Info;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;

using Windows.UI.Popups;


    



    
    
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
    

var width = Window.Current.Bounds.Width * (int)DisplayProperties.ResolutionScale / 100;
var height = Window.Current.Bounds.Height * (int)DisplayProperties.ResolutionScale / 100;

    var dpi = DisplayInformation.GetForCurrentView().RawDpiY;
 
width= Math.Sqrt(Math.Pow(width / dpi, 2).ToString();
height=Math.Pow(height / dpi, 2).ToString());
 
          var result = "{\"width\":\"" + width + "\",\"height\":\"" + height + "\"}";
          
          
          MessageDialog message = new MessageDialog(result);
await message.ShowAsync();

            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, result));
        }
    }
}



