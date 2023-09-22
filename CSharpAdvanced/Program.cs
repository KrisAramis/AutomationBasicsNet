using System.Collections;
using System.Linq;
using System.Collections.Generic;
using CSharpAdvanced;
using CSharpOOP2;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 4, 0, 8, 22 };
        
        int firstNumber = FlowerHelper.ReturnFirstElement(numbers);
        Console.WriteLine("First number is: {0}", firstNumber);

        Rose blueRose = new Rose() { Price = 10, Name = "Blue Rose", Color = "blue" };
        Camomile swissCamomile = new Camomile() { Price = 10, Name = "Swiss Camomile", Color = "yellow-white" };
        int rosesAmount = 0;
        int camomilesAmount = 0;
        Console.WriteLine("Input roses amount:");
        bool success = int.TryParse(Console.ReadLine(), out rosesAmount);
        Console.WriteLine("Input camomiles amount:");
        bool success2 = int.TryParse(Console.ReadLine(), out camomilesAmount);

        double bouqetPrice = FlowerHelper.ReturnPriceforBouquet(blueRose, rosesAmount);
        double bouqetPrice2 = FlowerHelper.ReturnPriceforBouquet(swissCamomile, camomilesAmount);
        
        FlowerHelper.PrintReceipt(swissCamomile, camomilesAmount);
        FlowerRepaint<Flower>.RepaintFlower(blueRose, "black");
        FlowerHelper.PrintReceipt(blueRose, rosesAmount);
        Car chevrolet = new Car("matiz",2009, 50);
        chevrolet.ReturnCarInfo();
        chevrolet.SetVinNumber();
        chevrolet.RepaintCar("grey");
        chevrolet.ChooseColor("grey");
    }
}