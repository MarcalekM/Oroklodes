using Oroklodes;

Book b = new("Vaják Az utolsó kívánság", "Andrzej Sapkowski", "fantasy", 288);
Movie m = new("Fekete telefon", "Scott Derrickson", "horror", 1, 42);
Series s = new("A mentalista", "Simon Baker", "krimi", 151);

Console.WriteLine(b.Write());
Console.WriteLine(m.Write());
Console.WriteLine(s.Write());