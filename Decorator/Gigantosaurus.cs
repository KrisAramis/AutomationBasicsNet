namespace Decorator
{
    public class Gigantosaurus : IGigantosaurus
    {
        //this is basic class which describes basic functionality
        public void Roar()
        {
            string sound = "Dianosaurous roars";
            Console.WriteLine(sound);
        }
    }
}