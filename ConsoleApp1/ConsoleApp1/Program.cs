// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Containers;

Console.WriteLine("Hello, World!");

int? a = 10;
a = null;
int b = 1;
// var container = new Container(100.0 ){ CargoMass = 100.0};

List<int> list = new List<int>(){1,2,3};
Dictionary<string,int> dictionary = new ();

Dictionary<PossibleProducts, double> products = new Dictionary<PossibleProducts, double>();