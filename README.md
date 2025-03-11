Testing to use .NET 9.0 CLR with a C++ dll.

It works fine with .NET 8.0, but with .NET 9.0 it only works during debugging and if Suppress JIT optimization on module load is enabled. It never works in release.

'TestApp.exe' (Win32): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\9.0.2\clrjit.dll'. Symbol loading disabled by Include/Exclude setting.
Exception thrown at 0x00007FFB66DF53EB (clrjit.dll) in TestApp.exe: 0xC000008E: Floating-point division by zero (parameters: 0x0000000000000000, 0x0000000000001924).
