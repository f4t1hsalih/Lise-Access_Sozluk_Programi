using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Access_Sozluk_Programi
{
    public partial class FormCeviri : Form
    {
        public FormCeviri()
        {
            InitializeComponent();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            if (rbtn1.Checked)
            {
                string yol = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + @"\\ceviri.accdb";
                OleDbConnection cnn = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter da = new OleDbDataAdapter();
                DataTable dt = new DataTable();

                cnn.ConnectionString = yol;
                cmd.Connection = cnn;
                cmd.CommandText = "SELECT * FROM ceviri2 WHERE Tur LIKE '" + txtarama.Text + "%'";

                da.SelectCommand = cmd;
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            else if (rbtn2.Checked)
            {
                string yol = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + @"\\ceviri.accdb";
                OleDbConnection cnn = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter da = new OleDbDataAdapter();
                DataTable dt = new DataTable();

                cnn.ConnectionString = yol;
                cmd.Connection = cnn;
                cmd.CommandText = "SELECT * FROM ceviri1 WHERE Ing LIKE '" + txtarama.Text + "%'";

                da.SelectCommand = cmd;
                da.Fill(dt);
                dgv.DataSource = dt;
            }
        }
    }
}
