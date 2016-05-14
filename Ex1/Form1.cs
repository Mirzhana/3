using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Green);

            Graphics graph = panel.CreateGraphics();
            //Oprava speedometra
            graph.FillEllipse(Brushes.Black , 35, 25, 300, 300); 
            graph.FillEllipse(Brushes.White, 55, 45, 260, 260);
            //Izmeritelnaya
            
            Rectangle rec = new Rectangle(85,75,195,185);
           
            Pen ppp = new Pen(Color.Black);
            graph.DrawArc(ppp, rec, -20, -200);
      
            Rectangle rec2 = new Rectangle(105, 95, 155, 145);
           
            graph.DrawArc(ppp, rec2, -20, -200);
            graph.FillEllipse(Brushes.Black, 180, 162, 10, 10);
            graph.DrawLine(ppp, 185, 165, 160, 125);
        }
    }
}
