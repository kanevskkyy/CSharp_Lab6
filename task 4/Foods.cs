using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public abstract class Food
    {
        public abstract int HappinessPoints();
    }

    public class DryBread : Food
    {
        public override int HappinessPoints()
        {
            return 2;
        }
    }

    public class Lembas : Food
    {
        public override int HappinessPoints()
        {
            return 3;
        }
    }

    public class Apple : Food
    {
        public override int HappinessPoints()
        {
            return 1;
        }
    }

    public class Melon : Food
    {
        public override int HappinessPoints()
        {
            return 1;
        }
    }

    public class HoneyCake : Food
    {
        public override int HappinessPoints()
        {
            return 5;
        }
    }

    public class Mushrooms : Food
    {
        public override int HappinessPoints()
        {
            return -10;
        }
    }

    public class OtherFood : Food
    {
        public override int HappinessPoints()
        {
            return -1;
        }
    }
    public class FoodFactory
    {
        public static Food CreateFood(string foodName)
        {
            switch (foodName.ToLower())
            {
                case "drybread":
                    return new DryBread();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new Apple();
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new OtherFood();
            }
        }
    }
}
