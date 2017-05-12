using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte   valueSByte = -100;
            byte    valueByte = 100;
            short   valueShort = -20000;
            ushort valueUSShort = 50000;
            int valueInt = 100000000;
            uint valueUInt = 400000000;
            long valueLong = -800000000000;
            ulong valueULong = 90000000000000000;

            //実数型
            float valueFloat = 3.1415F;
            double valueDouble = 3.14159263535;

            //文字型
            char valueChar = 'A';
            string valueString = "C# PROGRAM";

            //論理型
            bool valueBool = true;

            Console.WriteLine("sbyte :{0}", valueSByte);
            Console.WriteLine("byte :{0}", valueByte);
            Console.WriteLine("shot :{0}", valueShort);
            Console.WriteLine("usshort :{0}", valueUSShort);
            Console.WriteLine("int:{0}", valueInt);
            Console.WriteLine("uint:{0}", valueUInt);
            Console.WriteLine("Long:{0}", valueLong);
            Console.WriteLine("yLong:{0}", valueULong);
            Console.WriteLine("float:{0}", valueFloat);
        }
    }
}
