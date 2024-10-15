using System.Text.Unicode;
using Verseny;

List<Versenyzo> versenyzok = [];

using StreamReader reader = new("forras.txt");
while (!reader.EndOfStream) versenyzok.Add(new(reader.ReadLine()));

Console.WriteLine($"Versenyzők száma: {versenyzok.Count}");

//első célba érkező férfi

