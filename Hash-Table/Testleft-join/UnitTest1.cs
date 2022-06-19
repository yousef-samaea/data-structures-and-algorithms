using System;
using Xunit;
using Hash_Table;
using System.Collections.Generic;
using static Hash_Table.Program;

namespace Testleft_join
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HashTable left = new HashTable();
            left.Set("diligent", "employed");
            left.Set("fond", "enamored");
            left.Set("guide", "usher");
            left.Set("outift", "garb");
            left.Set("wrath", "anger");

            HashTable right = new HashTable();
            right.Set("diligent", "idle");
            right.Set("fond", "averse");
            right.Set("guide", "follow");
            right.Set("flow", "jam");
            right.Set("wrath", "delight");

            Program Join = new Program();
            List<string> Resolt = new List<string>() {
           "[diligent:employed,idle]", "[outift:garb,NULL]", "[fond:enamored,averse]", "[guide:usher,follow]", "[wrath:anger,delight]" };
            Assert.Equal(Resolt, Program.LeftJoin(left, right));
        }

        [Fact]
        public void Test2()
        {
            HashTable left = new HashTable();
            left.Set("diligent", "employed");
            left.Set("fond", "enamored");
            left.Set("guide", "usher");
            left.Set("outift", "garb");
            left.Set("wrath", "anger");

            HashTable right = new HashTable();
            right.Set("diligent", "idle");
            right.Set("fond", "averse");
            right.Set("guide", "follow");
            right.Set("flow", "jam");
            right.Set("wrath", "delight");

            Program Join = new Program();
            List<string> Resolt = new List<string>() {
           "[diligent:employed,idle]", "[outift:garb,NULL]",
           "[fond:enamored,averse]", "[guide:usher,follow]", "[wrath:anger,delight]"
            };
            Assert.Equal(Resolt, Program.LeftJoin(left, right));
        }
    }

}

