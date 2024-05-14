using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachersClassRecord
{
    public partial class teacherDashboard : KryptonForm
    {
        public teacherDashboard()
        {
            InitializeComponent();
        }

        private void teacherDashboard_Load(object sender, EventArgs e)
        {

        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            var respond = MessageBox.Show("Are you sure you want to leave the app?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respond == DialogResult.Yes)
            {
                this.Close();
            }
            else return;
        }
    }
}
