# SkyRocket Optimizer

A powerful Windows 10/11 system optimization tool with a stunning menu-driven interface for applying performance, gaming, network, and security tweaks.

## Features

- **Performance & Speed**: Optimize CPU, memory, power settings, and disable unnecessary services
- **Gaming Optimizations**: Enable Game Mode, reduce latency, optimize GPU settings
- **Network Tweaks**: DNS configuration, QoS, TCP/IP optimizations
- **Security Hardening**: Firewall, Defender, SMB hardening, UAC settings

## Requirements

- Windows 10 (1903+) or Windows 11
- .NET 8.0 Runtime (included in self-contained build)
- Administrator privileges (required)

## Building

```bash
cd WinOptimizer
dotnet build
```

## Publishing

To create a self-contained single-file executable:

```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

The executable will be in `bin/Release/net8.0-windows/win-x64/publish/`

## Running

1. Run `SkyRocketOptimizer.exe`
2. If not running as Administrator, the app will prompt to restart with elevation
3. Navigate the menu using numbers and letters

## Usage

### Main Menu Options

| Option | Description |
|--------|-------------|
| 1 | Performance & Speed tweaks |
| 2 | Gaming Optimizations |
| 3 | Network Tweaks |
| 4 | Security Hardening |
| 5 | Apply All Tweaks |
| 6 | Restore / Undo Tweaks |
| 7 | View System Info |
| 8 | Exit |

### Applying Tweaks

- **Apply ALL**: Apply all tweaks in a category
- **Select specific**: Choose individual tweaks by ID

### Risk Levels

- 🟢 **Safe**: Can be applied without issues
- 🟡 **Moderate**: May require confirmation
- 🔴 **Advanced**: May cause instability, requires explicit confirmation

### Backup & Restore

The tool automatically backs up registry keys and service states before making changes. Use the Restore menu to:
- Restore all tweaks
- Restore a specific tweak
- View available backups

## Tweaks Included

### Performance (P01-P15)
- Disable SysMain, Windows Search
- Power plans (High Performance, Ultimate Performance)
- Visual effects, transparency
- Temp file cleaning
- CPU scheduling, core parking

### Gaming (G01-G12)
- Game Mode, Game DVR
- GPU preferences, HAGS
- Nagle's Algorithm, mouse acceleration
- Timer resolution, game priority

### Network (N02-N12)
- DNS (Cloudflare/Google)
- RSS, TCP Fast Open
- QoS, Delivery Optimization
- IPv6, TCP/IP reset

### Security (S01-S14)
- Windows Defender, Firewall
- SMBv1/SMB Signing
- Remote Desktop, Remote Registry
- UAC, AutoRun
- Controlled Folder Access, LLMNR

## Logs

All operations are logged to `skyrocket_log_[timestamp].txt` in the application directory.

## Copyright

**© 2026 isvexed - All Rights Reserved**

This software is protected by copyright law. All rights reserved.

---

*Made with ❤️ for Windows users*
