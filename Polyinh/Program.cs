namespace Polyinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carEngine = new CarEngine();
            var impretza = new Car("Subaru", "Impretza", carEngine);

            var motorcycleEngine = new MotorcycleEngine();
            var hardyDaytona = new Motorcycle("Hardy", "Daytona", false, motorcycleEngine);

            hardyDaytona.StartEngine();
            impretza.StartEngine();

            hardyDaytona.Drive();
            impretza.Drive();


        }
    }
}
