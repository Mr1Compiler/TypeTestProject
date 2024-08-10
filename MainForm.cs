using Guna.UI2.HtmlRenderer.Adapters;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TypeTest.Colors;
using TypeTest.Keyboard;

namespace TypeTest
{
    public partial class MainForm : Form
    {
        public static RichTextBox tbText2 = new RichTextBox();
        public static int Counter = 0;
        public static bool[] Answer;
        public bool IsArray = true;
        clsColors MyColors;
        clsKeyboard MyKeyboard;

        public void TestArray()
        {
            if (IsArray)
            {
                Answer = new bool[tbText2.Text.Length];
            }
            tbText.HideSelection = true;
            tbText.Select(0, 1);
            tbText.SelectionBackColor = MyColors.SelectionColorOfLetter();

        }
        void AddingParaghraph()
        {
            tbText.Text = Paragraphs[GetRandomNumber(0, 10)];
            tbText2.Text = tbText.Text;
        }
        public void MainText()
        {
            AddingParaghraph();
        }
        public MainForm()
        {
            InitializeComponent();
        }
        public void InitializingColors()
        {
            MyColors = new clsColors(this);
        }
        public void InitialzingKeyboard()
        {
            MyKeyboard = new clsKeyboard(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MainText();
            InitializingColors();
            InitialzingKeyboard();
            tbText.Focus();
            this.KeyPreview = true;
            TestArray();
            listBox1.Visible = false;
        }
        public void Selection(int Counter, int SelectionIndex)
        {
            tbText.Select(Counter, SelectionIndex);
        }

        int GetRandomNumber(int Num1, int Num2)
        {
            Random rand = new Random();
            int RandomNumber = rand.Next(Num1, Num2);

            return RandomNumber;
        }

        string[] Paragraphs =
            { "The quick brown fox jumps over the lazy dog.",
            "A journey of a thousand miles begins with a single step.",
            "To be or not to be, that is the question.",
            "All that glitters is not gold.",
            "A picture is worth a thousand words.",
            "Fortune favors the bold.",
            "The early bird catches the worm.",
            "Actions speak louder than words.",
            "When in Rome, do as the Romans do.",
            "You can lead a horse to water, but you can't make it drink."
            };

        public bool IsItTrue(char ch1, char ch2)
        {
            return (ch1 == ch2);
        }

        public void TextColor()
        {
            tbText.Text = tbText2.Text;
            tbText.HideSelection = true;

            for (int i = 0; i < Counter + 1; i++)
            {
                tbText.Select(i, 1);

                if (Answer[i] == true)
                {
                    tbText.SelectionColor = MyColors.ColoringTrueLetter();
                }

                else
                {
                    tbText.SelectionColor = MyColors.ColoringWrongLetter();
                }

            }
            tbText.SelectionBackColor = Color.FromArgb(192, 192, 0);
        }

        public bool Close = false;
        private void btnfrmSettings_Click(object sender, EventArgs e)
        {

            if (Close == false)
            {
                listBox1.Visible = true;
                Close = true;
            }
            else
            {
                listBox1.Visible = false;
                Close = false;
            }

        }
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(Counter == tbText.Text.Length - 1)
            //{
            //    MessageBox.Show("The End");
            //}
            MyKeyboard.HoverTheButton(sender, e);
            tbText2.Select(Counter, 1);
            char TrueChar = Convert.ToChar(tbText2.SelectedText);
            char EnteredChar = Convert.ToChar(e.KeyChar);
            tbText2.SelectionStart++;

            if (e.KeyChar == '\b')
            {
                Counter--;
            }

            else if (IsItTrue(TrueChar, EnteredChar))
            {
                Answer[Counter] = true;
                Counter++;

            }

            else
            {
                Answer[Counter] = false;
                Counter++;
            }

            TextColor();
            tbText.Select(Counter, 1);
            tbText.SelectionBackColor = MyColors.SelectionColorOfLetter();
            tbText.SelectionColor = MyColors.SelectedLetterBackColor();
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            MyKeyboard.ButtonNormalColor(sender, e);

        }
    }
}
