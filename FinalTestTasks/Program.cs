// See https://aka.ms/new-console-template for more information

var names = new List<string> { "Mike", "Selena", "Andy" };

var Names4symbols = from name in names
    where name.Length <= 5
    select name;

var namesWithE = names.Where(i=>i.Contains("e")).ToList();


foreach (var e in Names4symbols)
{
    Console.WriteLine(e);
}

var cities = new List<string> {"Minsk", "Babruisk", "Ivianets", "Kobryn"};

var citiesEven = cities.Where(i => i.Length % 2 == 0).Select(i => 'X' + i.Substring(1, 2)).ToList();
foreach (var e in citiesEven)
{
    Console.WriteLine(e);
}

