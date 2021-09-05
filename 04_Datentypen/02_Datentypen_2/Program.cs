using System;

namespace Bwz.Rappi
{
	class Program
	{
		static void Main()
		{
			// Output for char
			const char charMin = char.MinValue;
			const char charMax = char.MaxValue;

			Console.WriteLine($"Char value range start: {charMin}");
			Console.WriteLine($"Char value range end: {charMax}");

			// Output for byte
			const byte byteMin = byte.MinValue;
			const byte byteMax = byte.MaxValue;

			Console.WriteLine($"Byte value range start: {byteMin}");
			Console.WriteLine($"Byte value range end: {byteMax}");

			// Output for byte
			const sbyte sbyteMin = sbyte.MinValue;
			const sbyte sbyteMax = sbyte.MaxValue;

			Console.WriteLine($"SByte value range start: {sbyteMin}");
			Console.WriteLine($"SByte value range end: {sbyteMax}");

			// Output for short
			const short shortMin = short.MinValue;
			const short shortMax = short.MaxValue;

			Console.WriteLine($"Short value range start: {shortMin}");
			Console.WriteLine($"Short value range end: {shortMax}");

			// Output for int
			const int intMin = int.MinValue;
			const int intMax = int.MaxValue;

			Console.WriteLine($"Int value range start: {intMin}");
			Console.WriteLine($"Int value range end: {intMax}");

			// Output for long
			const long longMin = long.MinValue;
			const long longMax = long.MaxValue;

			Console.WriteLine($"Long value range start: {longMin}");
			Console.WriteLine($"Long value range end: {longMax}");
		}
	}
}
