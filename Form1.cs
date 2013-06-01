/*
 * Oregon Day of Civic Hacking
 * Coding: Sean Walsh
 * Graphics: Jung Ie Han
 * Project concept: Taizoon Doctor, Michael Galhouse
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ODCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 600;
            this.Width = 800;
            comboBox1.SelectedItem = "Economic";
            this.Text = "Ethical Choices";
        }
        int productID;
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Economic");
            comboBox1.Items.Add("Social");
            comboBox1.Items.Add("Environmental");

            label1.Visible = true;
            label2.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Environmental")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Responsible production");
                comboBox2.Items.Add("Sourcing");
                comboBox2.Items.Add("Certifications");
            }
            if (comboBox1.SelectedItem.ToString() == "Social")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Personal health");
                comboBox2.Items.Add("Producer conditions");
                comboBox2.Items.Add("Condition engagement");
            }
            if (comboBox1.SelectedItem.ToString() == "Economic")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Business type");
                comboBox2.Items.Add("Certifications");
                comboBox2.Items.Add("Local impact");
            }
            comboBox2.Visible = true;
        }

        private void hidePicBoxes()
        {
            label1.Visible = false;
            label2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
        }

        private void showPicBoxes()
        {
            label1.Visible = true;
            label2.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            hidePicBoxes();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            hidePicBoxes();
            button3.Visible = true;
            pictureBox15.Visible = true;
            button2.Visible = true;
            productID = 5;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            hidePicBoxes();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            hidePicBoxes();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            hidePicBoxes();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            hidePicBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            showPicBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (productID)
            {
                case 5:
                    System.Diagnostics.Process.Start("http://portlandbeebalm.com/shop/single-tube/");
                    break;
                default:
                    MessageBox.Show("Select an item first!", "Error");
                    break;
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            pictureBox16.Visible = true;
            button4.Visible = true;
            this.BackgroundImage = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            textBox1.Visible = true;
            label1.Visible = true;
            button1.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
        }

        private void guideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            button4.Visible = true;
            pictureBox17.Visible = true;
            this.BackgroundImage = null;
        }

    }
}
