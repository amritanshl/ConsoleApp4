using System;

namespace OOP_IN.Core
{
    // INTERFACE: Defines a capability (Can receive likes/comments)
    public interface IReactable
    {
        void Like();
        void Comment(string text);
    }

    // ABSTRACT CLASS: The blueprint for any content
    public abstract class PostBase : IReactable
    {
        // STATIC MEMBER: Belongs to the class, not object. Tracks TOTAL posts globally.
        public static int GlobalPostCount = 0;

        // ENCAPSULATION: Protected properties (accessible only to child classes)
        protected int _id;
        public string CreatorName { get; set; }
        public DateTime UploadTime { get; protected set; } // Read-only from outside

        public PostBase(string creator)
        {
            CreatorName = creator;
            UploadTime = DateTime.Now;
            _id = new Random().Next(1000, 9999);
            GlobalPostCount++; // Increment global counter
        }

        // VIRTUAL METHOD: Has default logic, but can be overridden
        public virtual void Upload()
        {
            Console.WriteLine($"[Server] Uploading generic content for {CreatorName}...");
        }

        // ABSTRACT METHOD: No body. Child MUST implement how to display itself.
        public abstract void Display();

        // INTERFACE IMPLEMENTATION
        public void Like()
        {
            Console.WriteLine($" >> {CreatorName}'s post received a LIKE <3");
        }

        public void Comment(string text)
        {
            Console.WriteLine($" >> Comment on {CreatorName}'s post: \"{text}\"");
        }
    }
}