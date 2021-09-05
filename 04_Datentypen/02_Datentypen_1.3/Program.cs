using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			// Output for byte
			int intMin = int.MinValue;
			int intMax = int.MaxValue;
			Console.WriteLine($"Int value range start: {intMin}");
			Console.WriteLine($"Int value range end: {intMax}");

			intMin = intMin - 1;
			intMax = intMax + 1;
			Console.WriteLine($"Int underflow: {intMin}");
			Console.WriteLine($"Int overflow: {intMax}");

			// Output for byte
			uint uintMin = uint.MinValue;
			uint uintMax = uint.MaxValue;
			Console.WriteLine($"UInt value range start: {uintMin}");
			Console.WriteLine($"UInt value range end: {uintMax}");

			uintMin = uintMin - 1;
			uintMax = uintMax + 1;
			Console.WriteLine($"UInt underflow: {uintMin}");
			Console.WriteLine($"Uint overflow: {uintMax}");
		}
	}
}
