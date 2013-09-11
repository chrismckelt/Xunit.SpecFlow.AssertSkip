﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using McKeltCustom.SpecflowPlugin;
using TechTalk.SpecFlow.Infrastructure;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Plugin")]
[assembly: AssemblyDescription("SpecFlow xunit ignore tests through feature tags")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("McKelt")]
[assembly: AssemblyProduct("Plugin")]
[assembly: AssemblyCopyright("Copyright ©  2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("39ca6fb4-8ca3-4a73-94e3-eee217cc6769")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: GeneratorPlugin(typeof(CustomGeneratorPlugin))]
[assembly: RuntimePlugin(typeof(CustomGeneratorPlugin))]

