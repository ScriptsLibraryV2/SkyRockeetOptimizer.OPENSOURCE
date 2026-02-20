<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:0f0c29,50:302b63,100:24243e&height=220&section=header&text=🚀%20SkyRocket%20Optimizer&fontSize=55&fontColor=ffffff&fontAlignY=40&desc=Advanced%20Windows%2010%20%2F%2011%20System%20Optimization%20Tool&descAlignY=62&descColor=cccccc" width="100%"/>

<br/>

[![Release](https://img.shields.io/badge/Version-0.4-blueviolet?style=for-the-badge&logo=github)](https://github.com/ScriptsLibraryV2)
[![Platform](https://img.shields.io/badge/Platform-Windows%2010%2F11-0078D6?style=for-the-badge&logo=windows&logoColor=white)](https://github.com/ScriptsLibraryV2)
[![Framework](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Admin](https://img.shields.io/badge/Requires-Administrator-red?style=for-the-badge&logo=windows-terminal&logoColor=white)](https://github.com/ScriptsLibraryV2)
[![License](https://img.shields.io/badge/License-All%20Rights%20Reserved-lightgrey?style=for-the-badge)](https://github.com/ScriptsLibraryV2)

<br/>

> **A powerful, menu-driven Windows optimization tool built in C# .NET 8 — squeeze every ounce of performance out of your system with one click.**

<br/>

</div>

---

## 📌 Table of Contents

- [Overview](#-overview)
- [Screenshots](#-screenshots)
- [Features](#-features)
- [Tweaks Breakdown](#-tweaks-breakdown)
- [Requirements](#-requirements)
- [Installation](#-installation)
- [Building from Source](#-building-from-source)
- [Usage](#-usage)
- [Backup & Restore](#-backup--restore)
- [Logging](#-logging)
- [Risk Levels](#-risk-levels)
- [Copyright](#-copyright--legal)

---

## 🧾 Overview

**SkyRocket Optimizer v0.4** is a feature-rich, console-based Windows system optimization tool written in **C# (.NET 8)**. It provides a clean, menu-driven interface to apply carefully curated tweaks across four core categories: **Performance, Gaming, Network, and Security** — with a full **backup and restore system** so you can always undo any change.

Built to be safe, transparent, and powerful — every tweak is documented, every change is backed up, and nothing runs without your confirmation.

```
✓ No bloatware          ✓ Full backup & restore       ✓ Self-contained .exe
✓ Risk-level warnings   ✓ Operation logging           ✓ UAC-aware elevation
```

---

## 📸 Screenshots

```
╔═══════════════════════════════════════════════════════════════════════════════╗
║                                                                               ║
║         ██╗    ██╗███████╗██╗          ██████╗ ██╗  ██╗ ██████╗              ║
║         ██║    ██║██╔════╝██║          ██╔══██╗██║  ██║██╔═══██╗             ║
║         ██║ █╗ ██║█████╗  ██║          ██████╔╝███████║██║   ██║             ║
║         ██║███╗██║██╔══╝  ██║          ██╔═══╝ ██╔══██║██║   ██║             ║
║         ╚███╔███╔╝███████╗███████╗     ██║     ██║  ██║╚██████╔╝             ║
║          ╚══╝╚══╝ ╚══════╝╚══════╝     ╚═╝     ╚═╝  ╚═╝ ╚═════╝              ║
║                                                                               ║
║                        🚀 SKYROCKET OPTIMIZER v0.4 🚀                        ║
║                        (C) 2026 ScriptsLibraryV2 (isvexed on Discord) - All Rights Reserved                ║
╚═══════════════════════════════════════════════════════════════════════════════╝

  [1] ⚡ Performance & Speed
  [2] 🎮 Gaming Optimizations
  [3] 🌐 Network Tweaks
  [4] 🔒 Security Hardening
  [5] 🚀 Apply ALL Tweaks
  [6] 🔄 Restore / Undo Tweaks
  [7] 💻 View System Info
  [8] 🚪 Exit
```

---

## ✨ Features

### 🖥️ Core Application
| Feature | Details |
|---|---|
| **Splash Screen & Loading Animation** | Animated ASCII art splash with frame-by-frame loading bar |
| **UAC / Admin Detection** | Detects admin rights at startup; prompts to auto-relaunch as Administrator |
| **Self-Contained Executable** | Single `.exe` — no .NET runtime installation required |
| **Menu-Driven Interface** | Full keyboard-navigated menu system, no GUI dependencies |
| **Backup System** | Automatically backs up registry keys and service states before ANY change |
| **Restore System** | Restore all tweaks, a specific tweak, or browse all available backups |
| **Operation Logging** | Timestamped log file written to the application directory |
| **Risk Level Indicators** | Every tweak is labelled 🟢 Safe / 🟡 Moderate / 🔴 Advanced |
| **Confirmation Prompts** | Advanced/risky tweaks require explicit user confirmation |
| **Apply Individual or All** | Apply a single tweak or blast all in a category at once |
| **System Info Viewer** | Live system information display |
| **x64 Native** | Compiled and optimized for 64-bit Windows |
| **Windows 10/11 Compatibility** | Supports Windows 10 1903+ and all Windows 11 builds |

---

## 🔧 Tweaks Breakdown

### ⚡ Performance & Speed — 15 Tweaks (P01–P15)

<details>
<summary>Click to expand</summary>

| ID | Tweak | Risk |
|---|---|---|
| P01 | Disable SysMain (Superfetch) | 🟢 Safe |
| P02 | Disable Windows Search Indexing | 🟢 Safe |
| P03 | Set High Performance Power Plan | 🟢 Safe |
| P04 | Enable Ultimate Performance Power Plan | 🟡 Moderate |
| P05 | Disable Visual Effects & Transparency | 🟢 Safe |
| P06 | Clean Temporary Files | 🟢 Safe |
| P07 | Optimize CPU Scheduling | 🟡 Moderate |
| P08 | Disable Core Parking | 🟡 Moderate |
| P09 | Disable Windows Tips & Suggestions | 🟢 Safe |
| P10 | Disable Background Apps | 🟢 Safe |
| P11 | Optimize Virtual Memory / Pagefile | 🟡 Moderate |
| P12 | Disable Startup Delay | 🟢 Safe |
| P13 | Disable Hibernation | 🟢 Safe |
| P14 | Optimize NTFS File System | 🟡 Moderate |
| P15 | Disable Telemetry & Data Collection | 🟢 Safe |

</details>

### 🎮 Gaming Optimizations — 12 Tweaks (G01–G12)

<details>
<summary>Click to expand</summary>

| ID | Tweak | Risk |
|---|---|---|
| G01 | Enable Windows Game Mode | 🟢 Safe |
| G02 | Disable Game DVR / Game Bar | 🟢 Safe |
| G03 | Set GPU Preference to High Performance | 🟢 Safe |
| G04 | Enable Hardware-Accelerated GPU Scheduling (HAGS) | 🟡 Moderate |
| G05 | Disable Nagle's Algorithm (lower network latency) | 🟡 Moderate |
| G06 | Disable Mouse Acceleration | 🟢 Safe |
| G07 | Optimize Timer Resolution | 🟡 Moderate |
| G08 | Set Game Process Priority | 🟢 Safe |
| G09 | Disable Xbox Game Overlay | 🟢 Safe |
| G10 | Disable Full-Screen Optimization Override | 🟢 Safe |
| G11 | Optimize GPU via Registry | 🟡 Moderate |
| G12 | Disable Background Recording | 🟢 Safe |

</details>

### 🌐 Network Tweaks — 11 Tweaks (N02–N12)

<details>
<summary>Click to expand</summary>

| ID | Tweak | Risk |
|---|---|---|
| N02 | Set DNS to Cloudflare (1.1.1.1) | 🟢 Safe |
| N03 | Set DNS to Google (8.8.8.8) | 🟢 Safe |
| N04 | Enable Receive Side Scaling (RSS) | 🟢 Safe |
| N05 | Enable TCP Fast Open | 🟡 Moderate |
| N06 | Disable QoS Packet Scheduler Reservation | 🟢 Safe |
| N07 | Disable Delivery Optimization | 🟢 Safe |
| N08 | Disable IPv6 | 🟡 Moderate |
| N09 | Reset TCP/IP Stack | 🟡 Moderate |
| N10 | Optimize Network Adapter Settings | 🟡 Moderate |
| N11 | Disable Windows Auto-Tuning | 🟡 Moderate |
| N12 | Flush DNS Cache | 🟢 Safe |

</details>

### 🔒 Security Hardening — 14 Tweaks (S01–S14)

<details>
<summary>Click to expand</summary>

| ID | Tweak | Risk |
|---|---|---|
| S01 | Configure Windows Defender Settings | 🟡 Moderate |
| S02 | Enable Windows Firewall (all profiles) | 🟢 Safe |
| S03 | Disable SMBv1 (critical vulnerability) | 🟢 Safe |
| S04 | Enable SMB Signing | 🟡 Moderate |
| S05 | Disable Remote Desktop (RDP) | 🟡 Moderate |
| S06 | Disable Remote Registry | 🟢 Safe |
| S07 | Configure UAC Level | 🟡 Moderate |
| S08 | Disable AutoRun / AutoPlay | 🟢 Safe |
| S09 | Enable Controlled Folder Access | 🔴 Advanced |
| S10 | Disable LLMNR (Link-Local Multicast Name Resolution) | 🟡 Moderate |
| S11 | Disable NetBIOS over TCP/IP | 🟡 Moderate |
| S12 | Enable Exploit Protection | 🔴 Advanced |
| S13 | Disable Print Spooler (if not needed) | 🔴 Advanced |
| S14 | Audit Policy Configuration | 🟡 Moderate |

</details>

---

## 💻 Requirements

| Requirement | Details |
|---|---|
| **OS** | Windows 10 (Build 1903+) or Windows 11 |
| **Architecture** | x64 only |
| **Privileges** | Administrator (required — auto-elevation prompt included) |
| **Runtime** | None — self-contained `.exe` bundles .NET 8 |
| **Disk Space** | ~60 MB (self-contained build) |

---

## 📦 Installation

### Option 1 — Installer (Recommended)

1. Download `SkyRocketOptimizer_Setup_v0.4.exe` from [Releases](https://github.com/ScriptsLibraryV2/SkyRocket-Optimizer/releases)
2. Run the installer — it will ask for admin rights
3. Choose your install directory (default: `C:\Program Files\SkyRocket Optimizer\`)
4. Optionally create a Desktop shortcut
5. Launch **SkyRocket Optimizer** from the Start Menu or Desktop

### Option 2 — Portable

1. Download `SkyRocketOptimizer.exe` from [Releases](https://github.com/ScriptsLibraryV2/SkyRocket-Optimizer/releases)
2. Place it anywhere on your system
3. Right-click → **Run as administrator**

> ⚠️ The application **requires** Administrator privileges. If not launched as admin, it will prompt you to auto-relaunch with elevation.

---

## 🔨 Building from Source

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8)
- Windows 10/11 (required — Windows-specific APIs are used)
- [Inno Setup 6.x](https://jrsoftware.org/isinfo.php) *(optional — for building the installer)*

### Clone & Build

```bash
git clone https://github.com/ScriptsLibraryV2/SkyRocket-Optimizer.git
cd SkyRocket-Optimizer/WinOptimizer
dotnet build
```

### Publish (Self-Contained Single File)

```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

Output: `bin/Release/net8.0-windows/win-x64/publish/SkyRocketOptimizer.exe`

### Build Installer

1. Open `installer.iss` in **Inno Setup Compiler**
2. Press `Ctrl+F9` to compile
3. Output: `Installer/SkyRocketOptimizer_Setup_v0.4.exe`

---

## 🕹️ Usage

### Main Menu

```
  [1]  ⚡  Performance & Speed
  [2]  🎮  Gaming Optimizations
  [3]  🌐  Network Tweaks
  [4]  🔒  Security Hardening
  [5]  🚀  Apply ALL Tweaks
  [6]  🔄  Restore / Undo Tweaks
  [7]  💻  View System Info
  [8]  🚪  Exit
```

### Applying Tweaks

1. Select a category (e.g. `1` for Performance)
2. Choose to **Apply ALL** tweaks in the category, or enter a specific tweak ID
3. Review the tweak description and risk level
4. Confirm when prompted for Moderate / Advanced tweaks
5. The tool applies the change and logs the result

### Apply All Tweaks at Once

Select option `5` from the main menu to run through every tweak across all four categories sequentially.

---

## 🔄 Backup & Restore

SkyRocket Optimizer **automatically backs up** registry keys and Windows service states before applying any tweak. You never lose your original settings.

### Restore Options (Menu Option 6)

| Option | Description |
|---|---|
| **Restore All** | Undo every change made in this session |
| **Restore Specific Tweak** | Undo a single tweak by ID |
| **View Backups** | Browse all available backups with timestamps |

> Backups are stored in the application directory and persist across sessions.

---

## 📝 Logging

Every operation is logged automatically to a timestamped file:

```
skyrocket_log_2026-01-15_14-32-00.txt
```

Log entries include:
- Timestamp of each action
- Tweak applied or restored
- Success / failure status
- Any errors with details

Logs are saved to the same directory as the executable.

---

## ⚠️ Risk Levels

| Level | Badge | Meaning |
|---|---|---|
| **Safe** | 🟢 | No known side effects. Reversible. |
| **Moderate** | 🟡 | Minor system behaviour changes. Confirmation prompted. |
| **Advanced** | 🔴 | May affect stability or security. Explicit confirmation required. Always backed up. |

---

## 🛡️ Disclaimer

> This software modifies **Windows registry keys, system services, and OS settings**.
> While every change is backed up and restorable, use this tool at your own risk.
> The author is not responsible for data loss, system instability, or any damages
> resulting from the use of this software.
>
> Always create a **System Restore Point** before running optimization tools on critical machines.

---

## 📜 Copyright & Legal

```
Copyright © 2026 ScriptsLibraryV2 (isvexed on Discord) — All Rights Reserved.

This software and its source code are the exclusive intellectual property
of ScriptsLibraryV2 (isvexed on Discord). Unauthorised copying, redistribution, modification, reverse
engineering, reselling, or claiming ownership of this software or any
part thereof is strictly prohibited without prior written permission
from the author.

SkyRocket Optimizer is provided for personal use only.
The author holds no responsibility for any damages, data loss, system
instability, or any consequences resulting from the use of this software.

Windows is a registered trademark of Microsoft Corporation.
SkyRocket Optimizer is not affiliated with or endorsed by Microsoft.
```

---

<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:24243e,50:302b63,100:0f0c29&height=130&section=footer" width="100%"/>

**SkyRocket Optimizer v0.4** — Made with ❤️ by [ScriptsLibraryV2](https://github.com/ScriptsLibraryV2)

[![GitHub](https://img.shields.io/badge/GitHub-ScriptsLibraryV2-181717?style=for-the-badge&logo=github)](https://github.com/ScriptsLibraryV2)

*© 2026 ScriptsLibraryV2 (isvexed on Discord) — All Rights Reserved*

</div>
