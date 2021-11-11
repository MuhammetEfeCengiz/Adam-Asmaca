using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void OyunaBasla_btn_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            int number = r.Next(0, 4);


            string []sehirler={ "İstanbul" , "Ankara" , "İzmir" , "Antalya" };
            char[] alfabe = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ".ToCharArray();
            for (int i = 0; i < alfabe.Length; i++)
            {
                Button btn = new Button();
                
                btn.Text = alfabe[i].ToString();
                btn.Width = 40;
                btn.Height = 20;
                flowLayoutPanel1.Controls.Add(btn);
            }
            

            for (int i = 0; i < sehirler.Length; i++)
            {
                TextBox text = new TextBox();
            
                text.Text = sehirler[i].ToString();
                text.Width = 40;
                text.Height = 20;
                flowLayoutPanel2.Controls.Add(text);

            }
            

        }
    }
}
