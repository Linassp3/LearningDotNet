using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    public class Program
    {
        public static void Main()
        {
            string[] zodziai = new string[5];
            zodziai[0] = "kaciukas";
            zodziai[1] = "suniukas";
            zodziai[2] = "peliukas";
            zodziai[3] = "triusiukas";
            zodziai[4] = "drambliukas";
            for (int i = 0; i < zodziai.Length; i++)
                Console.WriteLine(zodziai[i]);
            int[] skaiciukai = new int[20];
            for (int i = 0; i < skaiciukai.Length; i++)
                skaiciukai[i] = i;
            for (int i = skaiciukai.Length - 1; i >= 0; i--)
                Console.WriteLine(skaiciukai[i]);
        }
    }
}