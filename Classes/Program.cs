namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car(); // Dot notation 
            toyota.Year = 2011;
            toyota.Make = "Toyota";
            toyota.Model = "Camry";
           
            Console.WriteLine($"{toyota.Year} {toyota.Make} {toyota.Model}");
          
         


            
        }
    }


}
