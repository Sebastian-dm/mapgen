using Microsoft.Extensions.Configuration;
using System;
using System.IO;




IConfigurationRoot GTOPO30config = new ConfigurationBuilder()
.AddJsonFile("C:/Users/sdme/git/mapgen/src/GTOPO30config.json", optional: true).Build();

//string path = @"C:\Users\sdme\git\mapgen\res\GTOPO30\all10\a10g";

string path = GTOPO30config["path:a10g"];
byte[] readText = File.ReadAllBytes(path);

List<Int16> uniqueNumbers = new();
int datapoints = 0;


//for (int i = 0; i < readText.Length/2; i++) {
//    Int16 number = BitConverter.ToInt16(readText, i*2);
//    if (!uniqueNumbers.Contains(number)) {
//        uniqueNumbers.Add(number);
//        //Console.WriteLine(number);
//    }
//    datapoints++;


//}
//Console.WriteLine(datapoints.ToString());



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Finished");
