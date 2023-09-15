namespace CSharpOOP4
{
    public class Cylinder : Shape
    {
        private double _radius;
        private double _height;
        public Cylinder(string name,double radius, double height): base(name)
        {
            _radius = radius;
            _height = height;
        }

        public override double GetSquare()
        {
            return _height * Math.PI * _radius * _height;
        }

        public override void ShapeInfo()
        {
            base.ShapeInfo();
        }
    }
}