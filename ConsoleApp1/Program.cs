var names = new List<string> {"Abdullah", "Ahsan" , " Bilal"};

names.Add("Abdullah");
names.Add("Ahsan");
names.Add("Bilal");

foreach(var name in names)
{
    Console.WriteLine("$Hello {name.ToUpper()}!");
} 