// See https://aka.ms/new-console-template for more information
using csharp_biblioteca;
using System.Collections.ObjectModel;

Console.WriteLine("Hello, World!");
List<string> settore = new List<string>() { "poliziesco", "romanzo", "fantasy"};
foreach (string s in settore)
{
    Console.WriteLine(s);
}
//Dictionary<string, string> autori = new Dictionary<string, string>();

//autori["Giacomo"] = "Leopardi";
//autori["Dante"] = "Alighieri";
//autori["Ugo"] = "Foscolo";

//Documento documento1 = new("1", "Divina Commedia", "Romanzo" , "R4") ;