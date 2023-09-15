namespace CSharpOOP4
{
    public class Ball : Shape
    {
        private double _radius;
        public Ball(string name, double r): base(name)
        {
            _radius = r;
        }

        public void ShapeInfo()
        {
            base.ShapeInfo();
        }

        public override double GetSquare()
        {
            return 4 * Math.PI * _radius * _radius;
        }
    }
}