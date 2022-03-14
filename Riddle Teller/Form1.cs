using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riddle_Teller
{
    public partial class Form1 : Form
    {
        int randomnumber;
        bool pressed = false;
        int count = 0;
        Random random = new Random();
        ArrayList riddlelist = new ArrayList();
        ArrayList answerlist = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        private void Riddles()
        {
            riddlelist.Add("The more you take, the more you leave behind.What am I ?");
            riddlelist.Add("What 8 letter word can have a letter taken away and it still makes a word. Take another letter away and it still makes a word. Keep on doing that until you have one letter left. What is the word?");
            riddlelist.Add("What has a head, a tail, is brown, and has no legs?");
            riddlelist.Add("David's father has three sons: Snap, Crackle, and _____?");
            riddlelist.Add("A doctor and a bus driver are both in love with the same woman, an attractive girl named Sarah. The bus driver had to go on a long bus trip that would last a week. Before he left, he gave Sarah seven apples. Why?");
            riddlelist.Add("A boy was at a carnival and went to a booth where a man said to the boy, \"If I write your exact weight on this piece of paper then you have to give me $50, but if I cannot, I will pay you $50.\" The boy looked around and saw no scale so he agrees, thinking no matter what the carny writes he'll just say he weighs more or less. In the end the boy ended up paying the man $50. How did the man win the bet?");
            riddlelist.Add("What comes once in a minute, twice in a moment, but never in a thousand years?");
            riddlelist.Add("What has many keys, but can't even open a single door?");
            riddlelist.Add("What has six faces, but does not wear makeup, has twenty-one eyes, but cannot see? What is it?");
            riddlelist.Add("wo fathers and two sons went fishing one day. They were there the whole day and only caught 3 fish. One father said, that is enough for all of us, we will have one each. How can this be possible?");

        }
        private void Answers()
        {
            answerlist.Add("Footsteps.");
            answerlist.Add("The word is starting! starting, staring, string, sting, sing, sin, in, I.  Cool,huh?");
            answerlist.Add("A Penny.");
            answerlist.Add("David.");
            answerlist.Add("An apple a day keeps the doctor away!");
            answerlist.Add("The man did exactly as he said he would and wrote \"your exact weight\" on the paper.");
            answerlist.Add("The letter \"m\".");
            answerlist.Add("What has many keys, but can't even open a single door?");
            answerlist.Add("A die (dice).");
            answerlist.Add("There was the father, his son, and his son's son. This equals 2 fathers and 2 sons for a total of 3!");

        }

        private void Riddlebutton_Click(object sender, EventArgs e)
        {
            pressed = true;
            Titlename.Text = "";
            if (count == 0)
            {
                Riddles();
                Answers();
                count++;
            }
            randomnumber = random.Next(10);
            Titlename.Font = new Font("Times New Roman",10, FontStyle.Bold);
            Titlename.Text = Convert.ToString(riddlelist[randomnumber]);
        }

        private void answerbutton_Click(object sender, EventArgs e)
        {
            if (pressed)
            {
                Titlename.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                Titlename.Text = Convert.ToString(answerlist[randomnumber]);
                pressed = false;
            }
            else
            {
                Titlename.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                Titlename.Text = "Press to riddle first!";
            }
        }

        private void quitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
