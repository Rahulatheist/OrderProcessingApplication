using System;
using System.Collections.Generic;

namespace OrderProcessingApplication
{
    public abstract class NonPhysicalProduct
    {
        public string ItemName { get; set; }
        public List<string> Operations { get; set; }

        public void GetSlip()
        {
            Operations.Add("Generated a packing slip.");
            Console.WriteLine("Generated a packing slip.");
        }
        public virtual void DropMail()
        {
            Operations.Add("Mail Sent");
            Console.WriteLine("Mail Sent");
        }

    }

    class Video : NonPhysicalProduct
    {
        public Video(string videoName)
        {
            Operations = new List<string>();
            ItemName = videoName;

            GetSlip();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Video nonPhysicalProduct = new Video("jvahsjvhas");
        }
    }

    public class OrderProcessor
    {
        public static NonPhysicalProduct ConvertInputToType(string[] input)
        {
            string name = input[0];

            NonPhysicalProduct product = new Video(name);

            return product;
        }
    }
}
