# Scripting Define Utility

<p align="center">
	<img alt="GitHub package.json version" src ="https://img.shields.io/github/package-json/v/Thundernerd/Unity3D-ScriptingDefineUtility" />
	<a href="https://github.com/Thundernerd/Unity3D-ScriptingDefineUtility/issues">
		<img alt="GitHub issues" src ="https://img.shields.io/github/issues/Thundernerd/Unity3D-ScriptingDefineUtility" />
	</a>
	<a href="https://github.com/Thundernerd/Unity3D-ScriptingDefineUtility/pulls">
		<img alt="GitHub pull requests" src ="https://img.shields.io/github/issues-pr/Thundernerd/Unity3D-ScriptingDefineUtility" />
	</a>
	<a href="https://github.com/Thundernerd/Unity3D-ScriptingDefineUtility/blob/master/LICENSE.md">
		<img alt="GitHub license" src ="https://img.shields.io/github/license/Thundernerd/Unity3D-ScriptingDefineUtility" />
	</a>
	<img alt="GitHub last commit" src ="https://img.shields.io/github/last-commit/Thundernerd/Unity3D-ScriptingDefineUtility" />
</p>

Scripting Define Utility is a small helper that allows you to more easily modify the scripting define symbols for your project.

## Installation
1. The package is available on the [openupm registry](https://openupm.com). You can install it via [openupm-cli](https://github.com/openupm/openupm-cli).
```
openupm add net.tnrd.scriptingdefineutility
```
2. Installing through a [Unity Package](http://package-installer.glitch.me/v1/installer/package.openupm.com/net.tnrd.scriptingdefineutility?registry=https://package.openupm.com) created by the [Package Installer Creator](https://package-installer.glitch.me) from [Needle](https://needle.tools)

[<img src="https://img.shields.io/badge/-Download-success?style=for-the-badge"/>](http://package-installer.glitch.me/v1/installer/package.openupm.com/net.tnrd.scriptingdefineutility?registry=https://package.openupm.com)

## Usage
There's a couple of interactions you can do with the ScriptingDefineUtility

#### Adding
Adding a new define symbol to the list

```csharp
private void Foo()
{
    ScriptingDefineUtility.Add("Bar");
}
```

#### Removing
Removing an existing define symbol from the list

```csharp
private void Foo()
{
    ScriptingDefineUtility.Remove("Bar");
}
```

#### Contains
Checking if a symbol is in the current symbols list

```csharp
private void Foo()
{
    if (ScriptingDefineUtility.Contains("Bar"))
    {
        ...
    }
}
```

#### Getting
There are two ways of getting all the define symbols

This returns all the symbols as stored in the settings.
```csharp
private void Foo()
{
    string symbols = ScriptingDefineUtility.GetSymbols();
}
```

This returns all the symbols split by the delimiter ; (semicolon) and returns it as a string array
```csharp
private void Foo()
{
    string[] symbols = ScriptingDefineUtility.Symbols;
}
```

## Support
**Scripting Define Utility** is a small and open-source utility that I hope helps other people. It is by no means necessary but if you feel generous you can support me by donating.

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/J3J11GEYY)

## Contributing
Pull requests are welcomed. Please feel free to fix any issues you find, or add new features.
