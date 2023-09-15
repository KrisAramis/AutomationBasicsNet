namespace CSharpOOP4
{
    public class Pyramid:Shape
    {
        private double _height;
        private double _s;

        public double Height
        {
            get => _height;
        }
    public Pyramid(string name, double height, double s):base (name )
    {
        _height = height;
        _s = s;
    }

        public override void ShapeInfo()
        {
            base.ShapeInfo();
        }
        public override double GetSquare()
        {
            return 0.5 * _height * _s;
        }
    }
}