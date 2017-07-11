using System;
using System.Windows.Forms;

namespace AutoVideoWidthAndHeightCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            WidthAndHeightXYCalc();
        }

        private void WidthAndHeightXYCalc()
        {
            double source_width = 0;
            double source_height = 0;
            double out_width = 0;
            double out_height = 0;

            try
            {
                source_width = Convert.ToDouble(this.textBox5.Text);
                source_height = Convert.ToDouble(this.textBox6.Text);
                out_width = Convert.ToDouble(this.textBox7.Text);
                out_height = Convert.ToDouble(this.textBox8.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"输入有误：{ex.Message}，请输入数字！");
            }

            this.textBox1.Text = $"{source_width}";
            this.textBox2.Text = $"{Convert.ToInt32((source_width / out_width)* out_height)}";

            this.textBox3.Text = $"{0}";
            this.textBox4.Text = $"{Convert.ToInt32((source_height - Convert.ToInt32(this.textBox2.Text))/2)}";







            this.textBox9.Text = $"{this.textBox1.Text}:{this.textBox2.Text}:{this.textBox3.Text}:{this.textBox4.Text}";
            this.textBox10.Text = $"{out_width}x{out_height}";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            WidthAndHeightXYCalc();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            WidthAndHeightXYCalc();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            WidthAndHeightXYCalc();
        }

        private void textBox5678_Enter(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.SelectAll();
        }
    }
}
