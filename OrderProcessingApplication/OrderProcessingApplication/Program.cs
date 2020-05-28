using System;
using System.Collections.Generic;
using static OrderProcessingApplication.Program;

namespace OrderProcessingApplication
{
    public abstract class NonPhysicalProduct
    {
        public string ItemName { get; set; }
        public List<string> Operations { get; set; }

        public virtual void GetSlip()
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
        public override void GetSlip()
        {
            base.GetSlip();
            if (ItemName.ToLower().Equals("learning to ski"))
            {
                Operations.Add("'First Aid' video added to the packing slip");
                Console.WriteLine("'First Aid' video added to the packing slip");
            }
        }
    }

    class Upgrade : NonPhysicalProduct
    {
        public Upgrade()
        {
            Operations = new List<string>();
            base.GetSlip();
            Operations.Add("Apply the upgrade");
            Console.WriteLine("Apply the upgrade");
            base.DropMail();
        }
    }
    class Program
    {
        public enum ProductTypes
        {
            Video,
            Membership,
            Upgrade,
            Book,
            Other
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Video nonPhysicalProduct = new Video("jvahsjvhas");
            Console.WriteLine("Hello World!");
            Upgrade nonPhysicalProduct2 = new Upgrade();
        }
    }

    public class OrderProcessor
    {
        public static NonPhysicalProduct ConvertInputToType(string[] input)
        {
            string name = input[0];
            NonPhysicalProduct nonPhysicalproduct=null;
            ProductTypes type = (ProductTypes)Enum.Parse(typeof(ProductTypes), input[0], ignoreCase: true);
            switch (type)
            {
                case ProductTypes.Upgrade:
                    {
                        nonPhysicalproduct = new Upgrade();
                        break;
                    }
                case ProductTypes.Video:
                    {
                        nonPhysicalproduct = new Video(name);
                        break;
                    }
            }
            return nonPhysicalproduct;
        }
    }
}
