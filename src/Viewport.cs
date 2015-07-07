using System;
using System.Net;
using System.IO;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Notification;
using Microsoft.Phone.Shell;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Windows.Graphics.Display;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
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



var scaleFactor =DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
string width = Current.Bounds.Width * scaleFactor;
string height= Current.Host.window.Current.Bounds.Height * scaleFactor;


          var result = "{\"width\":\"" + width + "\",\"height\":\"" + height + "\"}";



            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, result));
        }
    }
}
