// See https://aka.ms/new-console-template for more information
using csharp_biblioteca;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

//Console.WriteLine("Hello, World!");
//List<string> settore = new List<string>() { "poliziesco", "romanzo", "fantasy"};
//foreach (string s in settore)
//{
//    Console.WriteLine(s);
//}

Libro Libri = new Libro(345, "32", "La DivinaCommedia", 1800, "Romanzo", "A4", "Dante", "Alighieri");
Dvd Dvds = new Dvd(120, "4ef", "Harry Potter e la pietra filosofale", 2001, "Fantasy","3f", "K.J.", "Rowling");
Utente Utenti = new Utente("de Pinto", "Corrado", "de Pinto Corrado", "ciaociao", 3512064362);
Prestito Prestiti = new Prestito("12 Luglio 2023", "14 Settembre 2023","de Pinto","Corrado");

Console.Write($"Hai selezionato l'elemento: {Libri.CodeId}");
Libri.LeggiDocumento();