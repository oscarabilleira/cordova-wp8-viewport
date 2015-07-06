cordova-wp8-viewport
====================

Viewport Cordova plugin for WP8 platform. Give and fix correct height and width viewport for windows phone 8+ devices.


Usage:
```html
 function onDeviceReady() {
 
 // put inside onDeviceReady function
Viewport.fixViewport();

;}
 ```


Also include this tags in your index.html
 ```html
 <meta http-equiv="X-UA-Compatible" content="IE=edge" >
    <meta name="viewport" content=" height=device-height,  initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />


```

Forked from the original plugin lisovin/cordova-wp8-viewport making some changes to make it works properly.
Information to get the correct size from: http://developerpublish.com/windows-phone-8-1-and-windows-runtime-apps-how-to-15-get-screen-resolution-in-windows-phone-8-1/
