using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            if (box.Text.StartsWith("0"))
                box.Text = "";

        }

        private void Calculeaza_Click(object sender, EventArgs e)
        { int numar, i, ok = 1;

            try
            {
                numar = Convert.ToInt32(TextBox.Text);
            }


            catch (Exception a)
            {
                numar = 0;
                TextBox.Text = "";


            }
            if (numar <= 0) ok = -1;
            if(numar>0)
            for(i=2;i<=numar/2;i++)
                if(numar%i==0) { ok = 0; i = numar; }

            if (ok==-1) { BackColor = Color.Gray; Mesaj.Text = "Valoare introdusa gresit"; }
               else if (ok == 1){ BackColor = Color.Cyan; Mesaj.Text = "Este numar prim"; }
                      else { BackColor = Color.IndianRed;  Mesaj.Text = "Nu e numar prim"; }
                            
                    


        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
