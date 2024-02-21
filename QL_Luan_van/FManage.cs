using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Luan_van
{
    public partial class FManage : Form
    {
        public FManage()
        {
            InitializeComponent();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            FNextPage fNextPage = new FNextPage();
            this.Hide();
            fNextPage.Show();
        }
    }
}
