using System;
using System.Windows.Forms;


namespace FlatGUI
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("text 1", "text 2", MessageBoxButtons.OK);
        }
    }
}
