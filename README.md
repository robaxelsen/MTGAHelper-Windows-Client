![MTGAHelper](http://www.mtgahelper.com/images/hero1-bg.jpg)

[MTGAHelper](http://www.mtgahelper.com) is a web application used along with the game Magic: The Gathering Arena.

### MTGAHelper-Windows-Client

This project contains the Installer and source code for the local program that can be installed on your computer known as a *Tracker*  and is used to communicate with the MTGAHelper servers.

You can then use the **[MTGAHelper website](http://www.mtgahelper.com)**  at any time to see your cards collection statistics and a variety of information tracked for you while you enjoy playing Magic: The Gathering Arena.

See [this post](https://www.patreon.com/posts/how-to-make-best-29075781) for an overview on how to best use MTGAHelper.

Please note that this tracker runs only on Windows for now.

### Features

- Automatically synchronizes your log files data with the MTGAHelper servers
- Draft helper when picking your cards during a draft
- In-match tracker to see your draw probabilities, opponent cards played, etc.

##### Check the [Patch notes](https://github.com/ibiza240/MTGAHelper-Windows-Client/blob/master/PatchNotes.md) to know about the latest changes.

-----

### Installation

##### Step 1. Microsoft .NET Core 3.0 framework
The application uses the very recent framework known as Microsoft .NET Core 3.0.

You will require to install:
- [This version if you have a 64-bit Operating System (x64-based processor)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-3.0.100-windows-x64-installer)
- [This version if you have a 32-bit Operating System (x86-based processor)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-3.0.100-windows-x86-installer)

> Note: If you are on Windows 7, you will most likely also need this Update for Windows 7 (KB2533623):
> - [This version if you have a 64-bit Operating System (x64-based processor)](https://www.microsoft.com/en-us/download/details.aspx?id=26764)
> - [This version if you have a 32-bit Operating System (x86-based processor)](https://www.microsoft.com/en-us/download/details.aspx?id=26767)


##### Step 2. MTGAHelper Tracker Installer

Once the framework installed, [download the Tracker Installer](https://github.com/ibiza240/MTGAHelper-Windows-Client/raw/master/MTGAHelperTracker.msi) and after the very simple setup, the tracker will be ready to run from your Desktop where a shortcut will be created.

### Configuration

To use the tracker, you will need to have an MTGAHelper account. You can authenticate with Google or Facebook directly, or you may also use a local account but you will first have to sign-up for one on the website.

### Activate the detailed MTGA log

**This step is now required after the Sept. 4 MTGA game patch**

To be able to use the tracker, you need to do the following in the MTGA game client:

1. Press `Esc` to get the Options popup and click on **View account**
<img src="https://i.imgur.com/NpLkJzy.png" width="420" alt="MTGA Options">

2. Check the **Detailed Logs (Plugin Support)** option
<img src="https://i.imgur.com/pWJVc7J.png" width="420" alt="MTGA Profile">

3. Restart the game.

### Usage

You will notice activity in the status bar any time the tracker is communicating with the servers. For example the status bar will blink and indicate `Uploading log file to server...` while it is uploading your data, which can take some time. You are NOT blocked by this activity and can continue playing the game normally.

Once your data is uploaded successfully, you can simply refresh the MTGAHelper website to see it updated.

-----

### Troubleshooting

**Nothing happens when I run the MTGAHelper Tracker**

1- It's probably because the program cannot find the .NET Core 3.0 framework described above. Check in your installed applications if you have this installed:

<img src="https://i.imgur.com/UWrO39u.png" width="420" alt=".NET Core 3.0 framework in your installed applications">

2- Try to run the tracker from a command line window by running:

    dotnet "C:\Program Files (x86)\MTGAHelper\MTGAHelper Tracker\MTGAHelper.Tracker.dll"

This might give some information on why the tracker doesn't want to start.

3- In the `%AppData%/MTGAHelper` directory there might be some log files (ie. log-201923.txt). You can open these text files and see if there's any helpful information.

### Questions or Feedback

If you are stuck at any moment, please reach us directly through our [Discord server](https://discord.gg/GTd3RMd) for the fastest response time or by using the [contact form](https://www.mtgahelper.com/contact) on the MTGAHelper website so we can assist you.

-----

###### All art is property of their respective artists and/or Wizards of the Coast Inc. This website is not produced, endorsed, supported, or affiliated with Wizards of the Coast. MTGAHelper is unofficial Fan Content permitted under the Fan Content Policy.
