using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_IN.Core;
using OOP_IN.Models;

namespace OOP_IN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INSTAGRAM OOP SYSTEM ===\n");

            // 1. Partial Class Demo (User)
            User user1 = new User("code_master", "12345");
            if (!user1.Login("12345")) return; // Logic from file 2, Data from file 1

            Console.WriteLine("\n--- Creating Content ---");

            // 2. Polymorphism Demo (Storing Child objects in Parent List)
            List<PostBase> feed = new List<PostBase>();

            // Adding a Photo
            PhotoPost photo = new PhotoPost(user1.Username, "VividWarm");
            feed.Add(photo);

            // Adding a Reel
            ReelPost reel = new ReelPost("dance_queen", 30);
            feed.Add(reel);

            // 3. Processing Feed
            foreach (PostBase post in feed)
            {
                // Upload Logic (Virtual Method)
                // Photo uses Custom logic, Reel uses Default logic
                post.Upload();

                // Display Logic (Abstract Method)
                // Runtime Polymorphism: Decides at runtime which Display() to call
                post.Display();

                // Interface Logic
                post.Like();
                Console.WriteLine();
            }

            // 4. Interface Specific Interaction
            // Since we know 'photo' is IReactable, we can comment.
            photo.Comment("Nice filter!");

            // 5. Static Member Demo
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Total Posts on Server: {PostBase.GlobalPostCount}");
            Console.WriteLine("--------------------------------");

            Console.ReadKey();
        }
    }
}
