using Shapes;

namespace Polyinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var carEngine = new CarEngine();
            //var impretza = new Car("Subaru", "Impretza", carEngine);

            //var motorcycleEngine = new MotorcycleEngine();
            //var hardyDaytona = new Motorcycle("Hardy", "Daytona", false, motorcycleEngine);

            //hardyDaytona.StartEngine();
            //impretza.StartEngine();

            //hardyDaytona.Drive();
            //impretza.Drive();


            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),
                new Rectangle(2, 5),
                new Triangle(3, 7)
             };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name + " area = " + shape.CalculateArea());
            }


        }
    }
}
