using OOP_IN.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IN.Models
{
    public class PhotoPost : PostBase
    {
        public string FilterName { get; set; }

        public PhotoPost(string creator, string filter) : base(creator)
        {
            FilterName = filter;
        }

        // POLYMORPHISM: Overriding the Abstract method
        public override void Display()
        {
            Console.WriteLine($"[DISPLAY] 📷 PHOTO by @{CreatorName} | Filter: {FilterName}");
        }

        // POLYMORPHISM: Overriding the Virtual method
        public override void Upload()
        {
            Console.WriteLine($"[Upload] Optimizing Image resolution for {FilterName}...");
            base.Upload(); // Calls the parent's default upload logic too
            Console.WriteLine("[Upload] Photo Ready!");
        }
    }
}
