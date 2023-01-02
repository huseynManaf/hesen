using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace ConsoleApp57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Massivin uzunlugun daxil et:");
            int n= int.Parse(Console.ReadLine());
            int sum = 0;
            
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)

            {
                Console.Write($"arr{i}+{i}=");
                arr[i] = int.Parse(Console.ReadLine());


            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) ;
                sum += arr[i];
                
            }
            Console.WriteLine("cem="+sum+" " + say=)
        }    
    }
}