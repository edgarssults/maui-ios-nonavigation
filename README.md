# Overview

This repository contains a MAUI .NET 9 application that can be used to reproduce an issue with navigation not happening on iOS when clicking a link in a web view. Whenever navigation occurs a toast is shown.

# Steps

1. Deploy and start the app on an iOS device. CodesignKey and CodesignProvision must be provided in the .csproj file.
2. Click on any download in the list.
3. Nothing happens.

It's a relative link and has `target="_blank"`. It's possible that MAUI is considering that as a different host and because it's supposed to open in a new window it's not doing anything at all. I expect MAUI to at least raise a `Navigating` event and let the developer decide what to do in that case.

# Related

MAUI documentation mentions issues with `target="_blank"` links on Android and a workaround, but doesn't say anything about iOS: [https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/webview?view=net-maui-9.0&pivots=devices-android#navigate-to-content-that-opens-a-new-window-on-android](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/webview?view=net-maui-9.0&pivots=devices-android#navigate-to-content-that-opens-a-new-window-on-android).