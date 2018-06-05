using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqMultikinoRepertoire
{
    public partial class Form1 : Form
    {
        private MultikinoXmlReader multikino;
        
        public Form1()
        {
            InitializeComponent();
            multikino = new MultikinoXmlReader();
            multikinoData.DataSource = MultikinoXmlReader.ConvertToEventList(multikino.Element.Elements().ToList());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
