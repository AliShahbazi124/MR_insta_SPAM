using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace MR_insta_SPAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                d.Navigate().GoToUrl("https://www.instagram.com");
                d.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[2]/div/label/input")).SendKeys(textBox1.Text);
                d.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[3]/div/label/input")).SendKeys(textBox2.Text);
                d.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div[4]")).Click();
                timer1.Start();
            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message,"error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        IWebDriver d = new FirefoxDriver();
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1;
            if(i == 1000)
            {
                try
                {
                    timer1.Stop();
                    d.FindElement(By.XPath("/html/body/div[1]/section/nav/div[2]/div/div/div[3]/div/div[2]/a")).Click();
                    DialogResult dd =  MessageBox.Show("select User to send Message!\n if you select User push Yes", "",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dd == DialogResult.Yes)
                    {
                        spam();
                    }
                }catch(Exception ee)
                {
                    MessageBox.Show(ee.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void spam()
        {
            int number = Convert.ToInt32(numericUpDown1.Value);
            for(int i = 0; i <= number; i++)
            {
                try
                {
                    d.FindElement(By.XPath("/html/body/div[1]/section/div/div[2]/div/div/div[2]/div[2]/div/div[2]/div/div/div[2]/textarea")).SendKeys(textBox3.Text);
                    d.FindElement(By.XPath("/html/body/div[1]/section/div/div[2]/div/div/div[2]/div[2]/div/div[2]/div/div/div[3]/button")).Click();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
