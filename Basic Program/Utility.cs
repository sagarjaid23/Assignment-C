using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Utility
    {
        internal static Utility u;

        public int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }
        public double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }
        public float ReadFloat()
        {
            return float.Parse(Console.ReadLine());
        }
        public long ReadLong()
        {
            return long.Parse(Console.ReadLine());
        }
        public bool ReadBoolean()
        {
            return bool.Parse(Console.ReadLine());
        }
        public char ReadChar()
        {
            return char.Parse(Console.ReadLine());
        }

    }
}
