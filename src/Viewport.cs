using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Windows;
using Windows.Graphics.Display;
using System.Windows.Media;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Info;



using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Core;
using Windows.ApplicationModel;
using Microsoft.Phone.Tasks;

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
            


var scaleFactor = GetForCurrentView().RawPixelsPerViewPixel;
string width = Current.Bounds.Width * scaleFactor;
string height= Current.Bounds.Height * scaleFactor;

 
          var result = "{\"width\":\"" + width + "\",\"height\":\"" + height + "\"}";
          
          

            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, result));
        }
    }
}



