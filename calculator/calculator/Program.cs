using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{

  
    
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
         Hashtable h=new Hashtable();
            h.Add("Roll No", 1);
            h.Add("Name", "Maitri");
            h.Add("Age", 21);
            h.Add("City", "Nagpur");
            foreach (string s in h.Keys)
            {
                Console.WriteLine("Key is "+s+" "+ "Value is " + h[s]);   
            }
            Console.WriteLine("Total keys are" + h.Count);
            h.Remove("Roll No");
            foreach (string s in h.Keys)
            {
                Console.WriteLine("Key is " + s + " " + "Value is " + h[s]);
            }
            Console.WriteLine("Total keys are" + h.Count);



        }
    }
}
