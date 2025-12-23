using OOP_IN.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IN.Models
{
    public class ReelPost : PostBase
    {
        public int DurationSeconds { get; set; }

        public ReelPost(string creator, int duration) : base(creator)
        {
            DurationSeconds = duration;
        }

        public override void Display()
        {
            Console.WriteLine($"[DISPLAY] 🎬 REEL by @{CreatorName} | ⏱ {DurationSeconds}s (Auto-playing...)");
        }

        // Note: We did NOT override Upload(), so it will use the default Parent logic.
    }
}
