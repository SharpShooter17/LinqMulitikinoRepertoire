using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqMultikinoRepertoire
{
    public partial class Form1 : Form
    {
        private MultikinoXmlReader multikino;
        
        public Form1()
        {
            InitializeComponent();
            multikino = new MultikinoXmlReader();
            multikinoData.DataSource = MultikinoXmlReader.ConvertToEventList(multikino.Element.Elements());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String s1 = searchText1.Text;
            String s2 = searchText2.Text;
            String q1 = MultikinoXmlReader.Map(comboBoxType1.Text);
            String q2 = MultikinoXmlReader.Map(comboBoxType2.Text);
            String orderBy = MultikinoXmlReader.Map(comboBoxSortBy.Text);
            if (orderBy == "")
            {
                orderBy = "cinema_name";
            }

            IEnumerable<XElement> result;

            if ( q1 != "" && q2 != "" )
            {
                result = multikino.FindBy(s1, q1, s2, q2, orderBy);
            } else if (q1 != "")
            {
                result = multikino.FindBy(s1, q1, orderBy);
            } else if (q2 != "")
            {
                result = multikino.FindBy(s2, q2, orderBy);
            } else
            {
                result = multikino.Element.Elements();
            }

            multikinoData.DataSource = MultikinoXmlReader.ConvertToEventList(result);
        }
    }
}
