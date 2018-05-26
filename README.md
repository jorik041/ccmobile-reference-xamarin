This repository contains the source code of a Xamarin sample app used to demonstrate best practices.

## Setup development environment
##### Install Visual Studio 2017 #####
VS 2017 is required for developing Xamarin.Forms. If you do not already have it installed, you can download it [here](https://www.visualstudio.com/downloads/download-visual-studio-vs). VS 2017 Community is completely free. If you are installing VS 2017 for the first time, select the "Custom" installation type and select the following from the features list to install:

- Universal Windows Platform Development - In the `Summary > Optional select the Windows 10 Mobile Emulator`.
- Mobile Development with .NET - In the `Summary > Optional select Xamarin Remoted Simulator, Xamarin SDK Manager, Intel Hardware Accelerated Execution Manager (HAXM)`

We also recommend installing [Xamarin Android Device Manager](https://developer.xamarin.com/guides/android/getting_started/installation/android-emulator/xamarin-device-manager/) This will use the HAXM tools installed above and allow you to configure Android Virtual Devices (AVDs) that emulate Android devices.
If you already have VS 2017 installed, you can verify that these features are installed by modifying the VS 2017 installation via the Visual Studio Installer.

### Reporting Bugs
We use [GitHub Issues](https://github.com/infosupport/ccmobile-reference-xamarin/issues) to track issues. If at all possible, please submit a reproduction of your bug along with your bug report.
