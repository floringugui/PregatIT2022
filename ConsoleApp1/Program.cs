//using System.Text;

//var b = new System.Boolean();
//System.Object i = new int();
//char c = 'c';

using System.Text;

string cStr = "cccc";
//cStr = cStr + "d";
//cStr += "aaaa" + "bbbb";

//Console.WriteLine(cStr);

//var newStr = cStr.Replace("d", string.Empty);

//Console.WriteLine(newStr);

StringBuilder sb = new StringBuilder(cStr);
sb.Append("d");
sb.Append("aaaa");
sb.Append("bbbb");

Console.WriteLine(sb.ToString());

sb.Replace("d", string.Empty);

Console.WriteLine(sb.ToString());

//Console.WriteLine(b.ToString());

//Console.WriteLine("Hello, World!" + System.Environment.NewLine + "Hello, World2!");
//Console.Beep();

//Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ro-RO");
//Console.WriteLine("{0:c}", 1000);
//var demo = new Demo();
//demo.LocalVars(i);

//public class Demo : Object
//{
//    private int var;

//    public int LocalVars(object parametru)
//    {
//        System.Boolean localVar = true;
//        var localVar2 = 100;
//        var localVar3 = "Test";

//        parametru.Equals(5);

//        var = 5;
//        parametru = 5;
//        localVar = false;
//        return 0;
//    }

//    public int Prop { get; set; }
//}