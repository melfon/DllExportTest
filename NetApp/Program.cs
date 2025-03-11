// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

[DllImport("DllExport.dll", CallingConvention = CallingConvention.Cdecl)]
static extern void Load();

Load();

Console.WriteLine("Load ok!");
