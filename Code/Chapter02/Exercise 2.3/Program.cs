using Microsoft.VisualBasic;
using System.Diagnostics;
using static System.Console;

// new 
//var[] vars = { sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal };


for (int i = 0; i < (WindowWidth * 0.61); i++)
{
    Write("-");
}
WriteLine();

string columnA = "Type";
string columnB = "Byte(s) of memory";
string columnC = "Min";
string columnD = "Max";

WriteLine( format: "{0} {1, 20} {2, 17} {3, 30}", columnA, columnB, columnC, columnD);
for (int i = 0; i < (WindowWidth * 0.61); i++)
{
    Write("-");
}
WriteLine();
WriteLine($"sbyte {sizeof(sbyte),3} {sbyte.MinValue,33} {sbyte.MaxValue,30}");
WriteLine($"byte  {sizeof(byte), 3} {byte.MinValue,33} {byte.MaxValue,30}"); 
WriteLine($"short {sizeof(short), 3} {short.MinValue,33} {short.MaxValue,30}");
WriteLine($"ushort{sizeof(ushort), 3} {ushort.MinValue,33} {ushort.MaxValue,30}");
WriteLine($"int   {sizeof(int),3} {int.MinValue,33} {int.MaxValue,30}");
WriteLine($"uint  {sizeof(uint), 3} {uint.MinValue,33} {uint.MaxValue,30}");
WriteLine($"long  {sizeof(long),3} {long.MinValue,33} {long.MaxValue,30}");
WriteLine($"ulong {sizeof(ulong),3} {ulong.MinValue,33} {ulong.MaxValue,30}");
WriteLine($"float {sizeof(float),3} {float.MinValue,33} {float.MaxValue,30}");
WriteLine($"double{sizeof(double),3} {double.MinValue,33} {double.MaxValue,30}");
WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
for (int i = 0; i < (WindowWidth * 0.61); i++)
{
    Write("-");
}
WriteLine();

// THIS IS THE ANSWER... ONCE AGAIN, I WAS APPROACHING IT WITH TOO COMPLEX A SOLUTION...

WriteLine("--------------------------------------------------------------------------");
WriteLine("Type    Byte(s) of memory               Min                            Max");
WriteLine("--------------------------------------------------------------------------");
WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
WriteLine("--------------------------------------------------------------------------");

//WriteLine(
//    format: "{0,0} {1, 20} {2, 40} {3, 60}",
//    columnA,
//    columnB,
//    columnC,
//    columnD);
//WriteLine($"{sbyte.MinValue,-10}{sbyte.MaxValue,10}");

//foreach (object listobject in objects)
//{
//    WriteLine($"{listobject.GetType}");
//}
