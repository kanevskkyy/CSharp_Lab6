using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public abstract class Mood
    {
        public abstract string MoodName();
    }
    public class Angry : Mood
    {
        public override string MoodName()
        {
            return "Angry";
        }
    }

    public class Sad : Mood
    {
        public override string MoodName()
        {
            return "Sad";
        }
    }

    public class Happy : Mood
    {
        public override string MoodName()
        {
            return "Happy";
        }
    }

    public class Blissful : Mood
    {
        public override string MoodName()
        {
            return "Blissful";
        }
    }

    public class MoodFactory
    {
        public static Mood CreateMood(int happinessPoints)
        {
            if (happinessPoints < -5)   return new Angry();
            else if (happinessPoints <= 0)  return new Sad();
            else if (happinessPoints <= 15) return new Happy();
            else return new Blissful();
        }
    }
}