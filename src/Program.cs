using System;
using System.IO;


string path = @"C:\Users\sdme\git\mapgen\res\GTOPO30\all10\a10g";
byte[] readText = File.ReadAllBytes(path);


List<Int16> uniqueNumbers = new();

for (int i = 0; i < readText.Length/2; i++) {
    Int16 number = BitConverter.ToInt16(readText, i*2);
    if (!uniqueNumbers.Contains(number)) {
        uniqueNumbers.Add(number);
        Console.WriteLine(number);
    }
    
}



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Finished");
