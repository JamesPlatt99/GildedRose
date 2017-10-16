using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
using System;
using System.IO;
using System.Text;
using ApprovalUtilities.Utilities;

namespace csharp
{
    [TestFixture]
    [UseReporter(typeof(NUnitReporter))]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
        {
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            String output = fakeoutput.ToString();

            StreamReader file = new StreamReader(@"C:\LocalProjects\Training\GildedRose-Kata\GildedRose-Refactoring-Kata\csharp\bin\Debug\valid.txt");
            string valid = "";
            string line;
            while ((line = file.ReadLine()) != null)
            {
                valid += line;
            }
            file.Close();
            output = output.Replace(Environment.NewLine, "");
            Assert.AreEqual(valid,output);
            
        }
    }
}
