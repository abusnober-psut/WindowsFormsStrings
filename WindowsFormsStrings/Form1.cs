using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String mob =  textBox1.Text;
            String mob = normalize(textBox1.Text);
            MessageBox.Show(mob);
            if (mob.Length == 10)
                if (mob.IndexOf("079") == 0 || mob.IndexOf("077") == 0 || mob.IndexOf("078") == 0)
                    MessageBox.Show("Valid Jordanian Number");
                else
                    MessageBox.Show("Invalid - not in Jordan");
            else
                MessageBox.Show("Invalid - number digits are not 10");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        String normalize(String n)
        {
            String temp ="";
            for (int i = 0; i < n.Length; i++)
                if (n[i] != '-')
                    temp = temp + n[i];
            return temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String email = textBox2.Text;
            MessageBox.Show(email.IndexOf("@").ToString());
            if (email.IndexOf("@") > 0)
                MessageBox.Show("Valid E-mail");
            else
                MessageBox.Show("Invalid E-mail");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String main = textBox3.Text;
            String part = textBox23.Text;
            int p = main.LastIndexOf(part);
            MessageBox.Show(p.ToString(), "Index of first occurance");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string stringList = textBox5.Text;
            for (int i = stringList.Length-1; i > 0; i--)
            {
                listBox1.Items.Add(stringList[i]);
            }

            foreach (char c in stringList)
            { listBox1.Items.Add(c);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String mainString = textBox10.Text;
            MessageBox.Show(mainString);
            int start = int.Parse(textBox6.Text);

            if (textBox6.Text == "")
                start = 0;


            String temp = mainString.Substring(start);
            textBox8.Text = temp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String mainString = textBox10.Text;
            MessageBox.Show(mainString);
            int start = int.Parse(textBox6.Text);
            int length = int.Parse(textBox7.Text);
            
            String temp = mainString.Substring(start, length);
            textBox9.Text = temp;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String arabic = textBox11.Text;
            if (arabic.Length >= 5 && arabic.IndexOf("ال") == 0)
                arabic = arabic.Substring(2);

            textBox12.Text = arabic;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String arabic = textBox11.Text;
            if (arabic.Length >= 5 && arabic.IndexOf("ون") == arabic.Length - 2)
                arabic = arabic.Substring(0, arabic.Length - 2);
            
            textBox12.Text = arabic;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String s = textBox13.Text;
            string m = textBox14.Text;
            //Compare using ==
            if (s == m)
                MessageBox.Show("The Two Strings Are Equal", "Compare using ==");
            else
                MessageBox.Show("The Two Strings Are NOT Equal", "Compare using ==");

            //Compare using Equals
            if (s.Equals(m))
                MessageBox.Show("The Two Strings Are Equal", "Compare using .Equals");
            else
                MessageBox.Show("The Two Strings Are NOT Equal", "Compare using .Equals");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            String string1 = textBox13.Text;
            String string2 = textBox14.Text;
            int v = 0;
            if (string1.CompareTo(string2) == 0) // true because they are equal.
                MessageBox.Show("The Two Strings Are Equal", "Compare using .Equals");
            
            v = string1.CompareTo(string2);
            MessageBox.Show(v.ToString(), "Compare result");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox15.Text = replaceText(textBox15.Text, textBox16.Text, textBox17.Text);
        }
        String replaceText(String s, String target, string replacement)
        {
            String part1, part2;
            int pos;
            return s.Replace(target, replacement);
            /*pos = s.IndexOf(target);
            part1 = s.Substring(0, pos);
            part2 = s.Substring(pos + target.Length);
            return part1 + replacement + part2;*/ }

        private void button13_Click(object sender, EventArgs e)
        {
            String state = textBox3.Text; // "Mississippi";
            int index = 0;
            index = int.Parse(textBox4.Text.ToString());
            int p = state.IndexOf(textBox18.Text, index); // puts 1 in 
                                                          //p (same state.IndexOf("is") )
                                                          //p = state.IndexOf("is", 2); 
                                                          // will put 4 inside pp = state.indexOf("is", 5);
            MessageBox.Show(p.ToString(), "Result of Index of");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            /**/

            var words = textBox19.Text.Split(' ', ',', ':', '.');
            MessageBox.Show(words.Length.ToString());

            int startIndex = 0, count = 0, spaceIndex = 0;
            String s = textBox19.Text;
            spaceIndex = s.IndexOf(" ", startIndex);
            while (spaceIndex != -1)
            {
                startIndex = spaceIndex + 1;
                count++;
                spaceIndex = s.IndexOf(" ", startIndex);
            }
            int numOfWords = count + 1;
            textBox20.Text = numOfWords.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string s = textBox21.Text;
            char[] s2 = new char[textBox21.Text.Length];

            int index = 0; // for new string

            for (int i = 0; i < s.Length; i++) // traverse all elemnts
            {

                
                int j;
                // Check if s[i] exists before
                for (j = 0; j < i; j++)
                    if (s[i] == s[j])
                        break;

                // If not present, then add it to
                // result.
                if (j == i)
                {
                    s2[index] = s[i];
                    index++;
                }
            }
            textBox22.Text = new string(s2);

            /*
            int dup = 0;
            String part1 ="", part2 = "";
            int pos = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                int j = i;
                while(s[j] == s[j+1])
                {
                    dup++;
                    part1 = s.Substring(0, j);
                    pos = j;
                    j++;
                }
            }
            part2 = s.Substring(pos+dup);
            */
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox13.Text = textBox13.Text.ToUpper();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox14.Text = textBox14.Text.ToLower();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
