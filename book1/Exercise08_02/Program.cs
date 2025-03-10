using System.Globalization;

namespace Exercise08_02
{
    class Numbers
    {
        public int[] nums;

        public Numbers(int size)
        {
            nums = new int[size];
        }

        public static string operator~(Numbers obj)
        {
            string[] result = new string[obj.nums.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = obj.nums[i].ToString();
            }
            return string.Join(", ",result);
        }

        public static Numbers operator ++ (Numbers obj)
        {
            int[] newNums = new int[obj.nums.Length + 1];
            for (int i = 0; i < obj.nums.Length; i++)
            {
                newNums[i] = obj.nums[i];
            }
            obj.nums = newNums;
            return obj;
        }

        public static Numbers operator -- (Numbers obj)
        {
            if (obj.nums.Length == 0)
            {
                return obj;
            }
            else
            {
                int[] newNums = new int[obj.nums.Length - 1];
                for (int i = 0; i < newNums.Length; i++)
                {
                    newNums[i] = obj.nums[i];
                }
                obj.nums = newNums;
                return obj;
            }
        }

        public static Numbers operator + (Numbers obj0, Numbers obj1)
        {
            int length = obj0.nums.Length + obj1.nums.Length;
            int[] newNums = new int[length];
            Numbers result = new Numbers(length);

            for (int i = 0; i < length; i++)
            {
                if (i < obj0.nums.Length)
                {
                    newNums[i] = obj0.nums[i];
                }
                else
                {
                    newNums[i] = obj1.nums[i - obj0.nums.Length];
                }
            }
            result.nums = newNums;
            return result;
        }

        public static Numbers operator + (Numbers obj, int num)
        {
            Numbers obj1 = new Numbers(1);
            int[] nums = { num };
            obj1.nums = nums;
            return obj + obj1;
        }

        public static Numbers operator + (int num, Numbers obj1)
        {
            Numbers obj0 = new Numbers(1);
            int[] nums = { num };
            obj0.nums = nums;
            return obj0 + obj1;
        }

        public override string ToString()
        {
            return ~this;
        }
        /*
        public static implicit operator string (Numbers obj)
        {
            string[] result = new string[obj.nums.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = obj.nums[i].ToString();
            }
            return string.Join("| ", result);
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers obj = new Numbers(9);
            Console.WriteLine(~obj);
            obj++;
            Console.WriteLine(obj);
            obj--;
            Console.WriteLine(obj);
            Numbers obj0 = new Numbers(0);
            Console.WriteLine(obj0);
            obj0--;
            Console.WriteLine(obj0);
            obj0++;
            obj0++;
            obj0++;
            Console.WriteLine("{0} + {1} = {2}", obj, obj0, obj + obj0);
            Console.WriteLine("{0} + {1} = {2}", obj, 11, obj + 11);
            Console.WriteLine("{0} + {1} = {2}", 10, obj0, 10 + obj0);
        }
    }
}
