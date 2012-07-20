using System;

namespace DynamicType.NET.Tests {
    internal class Program {
        public static void Main(string[] args) {
            var v = new DynamicValue();
            v++;
            v++;
            v++;
            v++;
            Console.WriteLine(v);
            v = new DynamicValue(0.0);
            Console.WriteLine(v);
            v += 2;
            Console.WriteLine(v);
            v += 1.3;
            Console.WriteLine(v);
            v = new DynamicValue("0");
            Console.WriteLine(v);
            v += 2;
            Console.WriteLine(v);
            v += 1.3;
            Console.WriteLine(v);
            v = new DynamicValue(0.0);
            Console.WriteLine(v);
            v += "2";
            Console.WriteLine(v);
            v += new DynamicValue("103,7");
            Console.WriteLine(v);
            v /= new DynamicValue("10");
            Console.WriteLine(v);
            v = new DynamicValue(2);
            Console.WriteLine(v);
            v += "2,1";
            Console.WriteLine(v);
            //Console.WriteLine(new DynamicValue(5) + new DynamicValue("10 Little Piggies")); -> crash
            Console.WriteLine(new DynamicValue(5) + new DynamicValue("10"));
            Console.WriteLine(new DynamicValue("10 Little Piggies") + new DynamicValue(5));
            v = new DynamicValue("");
            v += 100;
            v += 100;
            Console.WriteLine(v);

            Console.WriteLine((new DynamicValue("100").Equals(new DynamicValue(100))));

            Console.WriteLine((new DynamicValue("100") == new DynamicValue(100)));
            Console.WriteLine((new DynamicValue(100) == 100));
            Console.WriteLine((new DynamicValue(100) == new DynamicValue(100.0)));
            Console.WriteLine((new DynamicValue(99) < new DynamicValue(100.0)));
            Console.WriteLine((new DynamicValue(100) < new DynamicValue("99")));

            Console.WriteLine((new DynamicValue() == new DynamicValue()));
            Console.WriteLine((new DynamicValue() == null));
            Console.WriteLine((null == new DynamicValue()));

            dynamic con = new DynamicExpandoContainer();

            Console.WriteLine((int)con.count);

            con.count++;
            con.count++;
            con.count++;
            con.count++;
            con.count++;
            con.count++;

            con.count += "100";

            Console.WriteLine(con.count);
        }
    }
}