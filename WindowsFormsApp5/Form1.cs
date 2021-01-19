using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        DataAccess dataAccess;

        public Form1()
        {
            InitializeComponent();
            mi_restart_Click(null, null);
        }

        private void bn_bad_Click(object sender, EventArgs e)
        {
            try
            {
                dataAccess.AddDataUnsecure(tb_bad.Text);
                tb_bad.Text = "";
            }
            catch (Exception ex)
            {
                mi_msg.Text = ex.Message;
            }
            UpdateList();
        }
        private void bn_good_Click(object sender, EventArgs e)
        {
            try
            {
                dataAccess.AddDataSecure(tb_good.Text);
                tb_bad.Text = "";
            }
            catch (Exception ex)
            {
                mi_msg.Text = ex.Message;
            }
            UpdateList();
        }

        private void UpdateList()
        {
            lbx_main.Items.Clear();
            List<string> users = dataAccess.GetTable();
            foreach (string user in users)
            {
                lbx_main.Items.Add(user);
            }
        }

        private void mi_restart_Click(object sender, EventArgs e)
        {
            try
            {
                dataAccess = new DataAccess("Data Source=(local); Initial Catalog=SQLInjection; Integrated Security=SSPI");
                UpdateList();
            }
            catch (Exception ex)
            {
                mi_msg.Text = ex.Message;
            }
        }
    }
}
