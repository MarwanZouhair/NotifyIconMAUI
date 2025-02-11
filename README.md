# NotifyIconMAUI
A .NET MAUI template demonstrating how to integrate H.NotifyIcon with .NET MAUI for a Windows application running in a Windowless state.

## Overview

This repository serves as a reference implementation to answer [this issue](https://github.com/HavenDV/H.NotifyIcon/issues/147) in the **H.NotifyIcon** repository. It provides a basic setup for using **H.NotifyIcon** in a .NET MAUI Windows app. 
## Features

- Integrates **H.NotifyIcon** into a .NET MAUI Windows app and starts the app in a Windowless state (i.e., no main UI window is shown, and the app only runs in the system tray).
- Demonstrates system tray menu interactions
- Provides a template for extending tray functionality in MAUI applications

## Requirements

- .NET 9.0 or later
- Visual Studio 2022 (latest version recommended)

Currently, this implementation is only available for Windows. Development for macOS via macCatalyst is not supported at this time due to the lack of a macOS development environment.

## Getting Started

### 1. Clone the Repository
Open a terminal/command prompt in the desired folder and run the following command:
```sh
git clone https://github.com/MarwanZouhair/NotifyIconMAUI.git
```

### 2. Open in Visual Studio
- Open `NotifyIconMAUI.sln` in Visual Studio 2022.
- Ensure the **Windows Machine** target is selected with the Framework **(net9.0-windows)**.

### 3. Run the Application
- Build and run the project.
- The system tray icon should appear in the taskbar.
- Right-click the icon to see available menu options.

## Contributing

This repository is intended as a reference template, but contributions are welcome! Feel free to submit issues or pull requests to improve the implementation.

## References

- [H.NotifyIcon Repository](https://github.com/HavenDV/H.NotifyIcon)

## License

This project is licensed under the MIT License.

