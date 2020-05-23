using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SMsaveEditorUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void gameDataToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        string SQLfilePath=":memory:";
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "All files (*.*)|*.*|db files (*.db)|*.db";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK) {
                string fileName;
                fileName = dlg.FileName;
                SQLfilePath = fileName;
            }
        }

        private void seedToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void seedToolStripMenuItem_Click_1(object sender, EventArgs e) {
            var con = new SQLiteConnection("Data Source=" + SQLfilePath);
            con.Open();
            var cmd = new SQLiteCommand("SELECT * FROM Game;", con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                MessageBox.Show(rdr.GetInt32(2).ToString());
            con.Dispose();
            rdr.Dispose();
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
