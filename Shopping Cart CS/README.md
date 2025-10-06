<h1 align="center">
  Shopping Cart (C# Migration)
</h1>
<p align="center">
  C# Windows Forms implementation of the Shopping Cart application, migrated from VB.NET
</p>

<br>
<br>


## 📕 About This Project

This is a C# Windows Forms project that represents the ongoing migration of the original VB.NET Shopping Cart application to C#. The project targets .NET Framework 4.7.2 and maintains equivalent functionality to the VB.NET version.

**JIRA Ticket**: BT-3 - Create C# Project Structure  
**Migration Status**: Infrastructure Complete ✅ | UI/Logic Migration Pending 🚧  
**Original VB.NET Project**: [Shopping Cart](../Shopping%20Cart)

### Key Technical Details

- **Target Framework**: .NET Framework 4.7.2
- **Project Type**: Windows Forms Application (WinExe)
- **Namespace**: Shopping_Cart
- **Project Format**: Legacy .csproj (non-SDK style) for .NET Framework compatibility

### VB.NET to C# Conversions

| VB.NET Element | C# Equivalent |
|----------------|---------------|
| `My.MyApplication` startup | `Program.Main()` with `[STAThread]` |
| `My.Resources` module | `Properties.Resources` class |
| `My.Settings` module | `Properties.Settings` class |
| `Microsoft.VisualBasic.targets` | `Microsoft.CSharp.targets` |
| VB-specific properties (MyType, OptionExplicit, etc.) | Removed |

### Project Structure

```
Shopping Cart CS/
└── Shopping Cart CS/
    ├── Shopping Cart CS.csproj  - Main project file
    ├── Program.cs               - C# entry point with Main()
    ├── Form1.cs                 - Main form (stub, UI pending)
    ├── Form1.Designer.cs        - Form designer (stub)
    ├── Form1.resx               - Form resources
    ├── App.config               - Runtime configuration
    └── Properties/
        ├── AssemblyInfo.cs      - Assembly metadata
        ├── Resources.Designer.cs - Resource accessor
        ├── Resources.resx       - Application resources
        ├── Settings.Designer.cs - Settings accessor
        └── Settings.settings    - Application settings
```

### System References

The project includes 10 core .NET Framework system assembly references:
- System
- System.Core
- System.Data
- System.Data.DataSetExtensions
- System.Deployment
- System.Drawing
- System.Net.Http
- System.Windows.Forms
- System.Xml
- System.Xml.Linq

## 🔧 Building the Project

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 SDK
- Windows OS (required for .NET Framework projects)

### Build Instructions

1. Open `Shopping Cart CS.sln` in Visual Studio (when solution file is created)
2. Restore NuGet packages (if any are added in future phases)
3. Build the solution in Debug or Release configuration
4. The executable will be generated in `bin\Debug\` or `bin\Release\`

**Note**: This project uses the legacy .csproj format and requires Windows for building. Linux/Mac users with Mono may encounter compatibility issues.

## 🚨 Migration Status

### ✅ Completed (BT-3)
- Project structure created
- Build configurations (Debug/Release) with XML documentation
- C# entry point (Program.cs)
- Properties files (AssemblyInfo, Resources, Settings)
- Form designer stubs

### 🚧 Pending (Future Phases)
- UI controls migration (buttons, labels, textboxes, etc.)
- Business logic implementation (shopping cart calculations)
- Event handlers (Button1_Click, Button2_Click)
- Form layout and design
- Testing and validation

## 📚 Reference

**Original VB.NET Project**: [Shopping Cart](../Shopping%20Cart)  
**Pull Request**: [PR #3 - BT-3: Create C# Project Structure](https://github.com/ben-windsurf/VB.NET-PROJECTS/pull/3)  
**Migration Lead**: @ben-windsurf

### Built With

* [Microsoft Visual Studio Community 2019/2022](https://visualstudio.microsoft.com/downloads/) - IDE for C# Development
* [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472) - Target Framework

### Authors

* **Original VB.NET**: Abhijith Udayakumar - [Abhijith14](https://github.com/Abhijith14)
* **C# Migration**: Requested by @ben-windsurf

<br>
<br>

## 🚨 Forking this repo (please read!)

_**yes, with attribution**_.

I value keeping my work open source, but as you all know, _**plagiarism is bad**_. It's always disheartening whenever I find that someone has copied my work without giving me credit. I spent a non-trivial amount of effort building and designing this project, and I am proud of it! All I ask of you all is to not claim this effort as your own.


### TL;DR

Yes, you can fork this repo. Please give me proper credit by linking back to [Abhijith14/VB.NET-PROJECTS](https://github.com/Abhijith14/VB.NET-PROJECTS). Thanks!
