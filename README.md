Testing to use .NET 9.0 CLR with a C++ dll.

It works fine with .NET 8.0, but with .NET 9.0 it only works during debugging and if Suppress JIT optimization on module load is enabled. It never works in release.
