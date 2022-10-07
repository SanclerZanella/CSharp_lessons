using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGoTo1_Click(object sender, EventArgs e)
        {
            Close();
            //Form1 form1 = new Form1();

            //form1.ShowDialog();  // Prevents yhe user interacting with the previous form while the new form is active
            //form1.Show();  // Allows interaction with any form.
        }
    }
}
