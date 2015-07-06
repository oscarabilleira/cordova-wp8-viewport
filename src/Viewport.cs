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
    

var scaleFactor = Windows.Graphics.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
string width = Window.Current.Bounds.Width * scaleFactor;
string height= Window.Current.Bounds.Height * scaleFactor;

MessageDialog messageDialog = new MessageDialog(width+' '+height);
await messageDialog.ShowAsync();

 
          var result = "{\"width\":\"" + width + "\",\"height\":\"" + height + "\"}";
          
          

            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, result));
        }
    }
}



