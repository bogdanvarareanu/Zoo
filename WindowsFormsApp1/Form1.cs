using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<CDelfin> Delfin= new List<CDelfin>();
        private List<CWahl> Wal = new List<CWahl>();
        private List<CElefant> Elefant = new List<CElefant>();
        private List<CNashorn> Nashorn= new List<CNashorn>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Name:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            switch (comboBox1.SelectedIndex) 
            {
                case 0: 
                    {
                        
                        Elefant.Add(new CElefant(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
                        

                    }
                    break;
                case 1: 
                    {
                       
                        Nashorn.Add(new CNashorn(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));

                    } break;
                case 2:
                    {

                        Delfin.Add(new CDelfin(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));


                    } break;
                case 3:
                    {
                        
                        
                        Wal.Add(new CWahl(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));

                    } break;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        richTextBox1.Text = "Elefanten \n\n";
                        foreach (CElefant E in Elefant)
                        {
                            
                            richTextBox1.Text += E.get_EWerte();
                        }


                    }
                    break;
                case 1:
                    {
                        richTextBox1.Text = "Nashörner \n\n";

                        foreach (CNashorn N in Nashorn)
                        {
                            richTextBox1.Text += N.get_NWerte();
                        }

                    }
                    break;
                case 2:
                    {
                        richTextBox1.Text = "Delfine\n\n";

                        foreach (CDelfin D in Delfin)
                        {
                            richTextBox1.Text += D.get_DWerte();
                        }

                    }
                    break;
                case 3:
                    {
                        richTextBox1.Text = "Wale\n\n";
                        foreach (CWahl W in Wal)
                        {
                            richTextBox1.Text += W.get_WWerte();
                        }


                    }
                    break;



            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {


                        label2.Text = "Geschwindigkeit:";
                        label3.Text = "Rüssellänge:";
                    }
                    break;
                case 1:
                    {
                        label2.Text = "Geschwindigkeit:";
                        label3.Text = "Hornlänge:";

                    }
                    break;
                case 2:
                    {

                        label2.Text = "Tauchzeit:";
                        label3.Text = "Körperlänge:";

                    }
                    break;
                case 3:
                    {
                        label2.Text = "Tauchzeit:";
                        label3.Text = "Gewicht:";

                    }
                    break;



            }
        }
    }
}
