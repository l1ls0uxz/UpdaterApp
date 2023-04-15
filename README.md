# UpdaterApp
# ![AutoUpdater.NET](Images/Horizontal.png)
This project is using AutoUpdater.NET, which is a class library that enables .NET developers to easily incorporate auto-update functionality into their traditional desktop application projects.
## The NuGet Package  [![NuGet](https://img.shields.io/nuget/v/Autoupdater.NET.Official.svg)](https://www.nuget.org/packages/Autoupdater.NET.Official/) [![NuGet](https://img.shields.io/nuget/dt/Autoupdater.NET.Official.svg)](https://www.nuget.org/packages/Autoupdater.NET.Official/)

````powershell
PM> Install-Package Autoupdater.NET.Official
````

## Supported .NET versions

* .NET Framework 4.5 or above
* .NET Core 3.1
* .NET 5.0 or above

This library only works for WinForms or WPF application projects.

## How it works

AutoUpdater.NET downloads the XML file containing update information from your server. It uses this XML file to get the information about the latest version of the software. If the latest version of the software is greater than the current version of the software installed on User's PC then AutoUpdater.NET shows update dialog to the user. If user press the update button to update the software then It downloads the update file (Installer) from URL provided in XML file and executes the installer file it just downloaded. It is a job of installer after this point to carry out the update. If you provide zip file URL instead of installer then AutoUpdater.NET will extract the contents of zip file to application directory.

## Using the code

### XML file

AutoUpdater.NET uses XML file located on a server to get the release information about the latest version of the software. You need to create XML file like below and then you need to upload it to your server.

````xml
<?xml version="1.0" encoding="UTF-8"?>
<item>
  <version>1.0.1.4</version>
  <url>https://rbsoft.org/downloads/AutoUpdaterTest.zip</url>
  <changelog>https://github.com/ravibpatel/AutoUpdater.NET/releases</changelog>
  <mandatory>false</mandatory>
</item>
````

There are two things you need to provide in XML file as you can see above.

* version (Required) : You need to provide latest version of the application between version tags. Version should be in X.X.X.X format.
* url (Required): You need to provide URL of the latest version installer file or zip file between url tags. AutoUpdater.NET downloads the file provided here and install it when user press the Update button.
* changelog (Optional): You need to provide URL of the change log of your application between changelog tags. If you don't provide the URL of the changelog then update dialog won't show the change log.
* mandatory (Optional): You can set this to true if you don't want user to skip this version. This will ignore Remind Later and Skip options and hide both Skip and Remind Later button on update dialog.
  * mode (Attribute, Optional): You can provide mode attribute on mandatory element to change the behaviour of the mandatory flag. If you provide "1" as the value of mode attribute then it will also hide the Close button on update dialog. If you provide "2" as the value of mode attribute then it will skip the update dialog and start downloading and updating application automatically.
