namespace Gemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                int september = 210;  
                int oktober = 195;     
                int november = 225;    

                double gemiddelde = (september + oktober + november) / 3.0;

                Console.WriteLine($"Het gemiddelde aantal uren slaap over drie maanden is: {gemiddelde:F1} uur");
            }
        }

    }

