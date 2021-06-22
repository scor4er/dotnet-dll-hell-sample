# Sample of the simplest DLL hell in .NET

So there's a .NET Standard 2.0 library having multiple releases: 1.1.0, 1.2.0 & 1.3.0. 

This library is so cool that 3 different frameworks are using this library. Unfortunately, not all authors of such wonderful frameworks are using the latest version of the library.

- Framework 1 uses: Library 1.1.0

- Framework 2 uses: Library 1.2.0

- Framework 3 uses: Library 1.3.0 (this one has a breaking change and glossy new interface)


Finally 2 casual apps are trying to incorporate all power of these 3 frameworks, one app targets .NET Framework 4.8, another app is for .NET 5.



This situation leads to DLL hell.



There're couple things to avoid this.
- .NET Framework provides both auto/manually generated assembly binding redirection mechanism: 
https://docs.microsoft.com/en-us/dotnet/framework/configure-apps/redirect-assembly-versions


- .NET 5 supports Automatic Binding Redirection (despite that it's not seems to be a way for .NET 5 as mentioned here: https://stackoverflow.com/a/46120907/984299). 
I wasn't able to set up manual redirections. The correct version of the library is not getting to the binaries folder during the build.
