using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


//ROT13

//How can you tell an extrovert from an introvert at NSA? Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.

//I found this joke on USENET, but the punchline is scrambled.Maybe you can decipher it? According to Wikipedia, ROT13 (http://en.wikipedia.org/wiki/ROT13) is frequently used to obfuscate jokes on USENET.

//Hint: For this task you're only supposed to substitue characters. Not spaces, punctuation, numbers etc. Test examples:

//rot13("EBG13 rknzcyr.") == "ROT13 example.";
//rot13("This is my first ROT13 excercise!" == "Guvf vf zl svefg EBG13 rkprepvfr!"

//best solution:
//using System;
//using System.Linq;
//public class Kata
//{
//    public static string Rot13(string input)
//    {
//        var s1 = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
//        var s2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
//        return string.Join("", input.Select(x => char.IsLetter(x) ? s1[s2.IndexOf(x)] : x));
//    }
//}


namespace Codewars_ROT13
{
    public partial class Form1 : Form
    {
        public List<char> high1 = new List<char> {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M'};
        public List<char> high2 = new List<char> {'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        public List<char> low1 = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm'};
        public List<char> low2 = new List<char> {'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        public Form1()
        {
            InitializeComponent();
        }


        public string rot13(string input)
        {
            var chInput = input.ToList();
            var result = string.Empty;

            foreach (char t in chInput)
                if (high1.Contains(t))
                    result += high2[high1.IndexOf(t)];
                else if (high2.Contains(t))
                    result += high1[high2.IndexOf(t)];
                else if (low1.Contains(t))
                    result += low2[low1.IndexOf(t)];
                else if (low2.Contains(t))
                    result += low1[low2.IndexOf(t)];
                else
                    result += t;
            return result;
        }


        private void button_convert_Click(object sender, EventArgs e)
        {
            richTextBox_output.Text = rot13(richTextBox_input.Text);
        }
    }
}