namespace ShapeSpace
{
    abstract class Shape
    {
        abstract public void CalculateArea();
    }

     class Circle: Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine("radius=");
            decimal r=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine((decimal)3.14 * r * r);
        }
    }
    class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine("length=");
            decimal l = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("breath=");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(l*b);
        }
    }
}