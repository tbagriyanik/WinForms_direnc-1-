using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace direnc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        rezistor bizimDirenc = new rezistor();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bizimDirenc.renk1 = comboBox1.SelectedIndex;
            bizimDirenc.DirencDegeri(); //direnç hesaplama metodu
            textBox1.Text = bizimDirenc.direncOhm.ToString();
            if (comboBox1.SelectedIndex == 0) renkPanel1.BackColor = Color.Black;
            if (comboBox1.SelectedIndex == 1) renkPanel1.BackColor = Color.SaddleBrown;
            if (comboBox1.SelectedIndex == 2) renkPanel1.BackColor = Color.Red;
            if (comboBox1.SelectedIndex == 3) renkPanel1.BackColor = Color.Orange;
            if (comboBox1.SelectedIndex == 4) renkPanel1.BackColor = Color.Yellow;
            if (comboBox1.SelectedIndex == 5) renkPanel1.BackColor = Color.Green;
            if (comboBox1.SelectedIndex == 6) renkPanel1.BackColor = Color.Blue;
            if (comboBox1.SelectedIndex == 7) renkPanel1.BackColor = Color.Purple;
            if (comboBox1.SelectedIndex == 8) renkPanel1.BackColor = Color.Gray;
            if (comboBox1.SelectedIndex == 9) renkPanel1.BackColor = Color.White;
            label8.Text = bizimDirenc.tolerans;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bizimDirenc.renk2 = comboBox2.SelectedIndex;
            bizimDirenc.DirencDegeri();
            textBox1.Text = bizimDirenc.direncOhm.ToString();
            if (comboBox2.SelectedIndex == 0) renkPanel2.BackColor = Color.Black;
            if (comboBox2.SelectedIndex == 1) renkPanel2.BackColor = Color.SaddleBrown;
            if (comboBox2.SelectedIndex == 2) renkPanel2.BackColor = Color.Red;
            if (comboBox2.SelectedIndex == 3) renkPanel2.BackColor = Color.Orange;
            if (comboBox2.SelectedIndex == 4) renkPanel2.BackColor = Color.Yellow;
            if (comboBox2.SelectedIndex == 5) renkPanel2.BackColor = Color.Green;
            if (comboBox2.SelectedIndex == 6) renkPanel2.BackColor = Color.Blue;
            if (comboBox2.SelectedIndex == 7) renkPanel2.BackColor = Color.Purple;
            if (comboBox2.SelectedIndex == 8) renkPanel2.BackColor = Color.Gray;
            if (comboBox2.SelectedIndex == 9) renkPanel2.BackColor = Color.White;
            label8.Text = bizimDirenc.tolerans;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            bizimDirenc.renk3 = comboBox3.SelectedIndex;
            bizimDirenc.DirencDegeri();
            textBox1.Text = bizimDirenc.direncOhm.ToString();
            if (comboBox3.SelectedIndex == 0) renkPanel3.BackColor = Color.Black;
            if (comboBox3.SelectedIndex == 1) renkPanel3.BackColor = Color.SaddleBrown;
            if (comboBox3.SelectedIndex == 2) renkPanel3.BackColor = Color.Red;
            if (comboBox3.SelectedIndex == 3) renkPanel3.BackColor = Color.Orange;
            if (comboBox3.SelectedIndex == 4) renkPanel3.BackColor = Color.Yellow;
            if (comboBox3.SelectedIndex == 5) renkPanel3.BackColor = Color.Green;
            if (comboBox3.SelectedIndex == 6) renkPanel3.BackColor = Color.Blue;
            if (comboBox3.SelectedIndex == 7) renkPanel3.BackColor = Color.Purple;
            if (comboBox3.SelectedIndex == 8) renkPanel3.BackColor = Color.Gray;
            if (comboBox3.SelectedIndex == 9) renkPanel3.BackColor = Color.White;
            if (comboBox3.SelectedIndex == 10) renkPanel3.BackColor = Color.Goldenrod;
            if (comboBox3.SelectedIndex == 11) renkPanel3.BackColor = Color.Silver;
            label8.Text = bizimDirenc.tolerans;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            bizimDirenc.renk4 = comboBox4.SelectedIndex;
            bizimDirenc.DirencDegeri();
            textBox1.Text = bizimDirenc.direncOhm.ToString();
            label8.Text = bizimDirenc.tolerans;
            renkPanel4.Visible = true;
            if (comboBox4.SelectedIndex == 0) renkPanel4.BackColor = Color.Goldenrod;
            if (comboBox4.SelectedIndex == 1) renkPanel4.BackColor = Color.Silver;
            if (comboBox4.SelectedIndex == 2) renkPanel4.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sadece basamakları alıp Renk Panelleri güncellenecek
            bizimDirenc.metindenRengeCevir(textBox1.Text);
            renkPanel1.BackColor = bizimDirenc.renkColor1;
            renkPanel2.BackColor = bizimDirenc.renkColor2;
            renkPanel3.BackColor = bizimDirenc.renkColor3;
        }
    }
}
