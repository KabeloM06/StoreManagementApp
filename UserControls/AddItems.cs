using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementApp.UserControls
{
    public partial class AddItems : UserControl
    {
        // Connect to database
        function fn = new function();
        String query;
        public AddItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
