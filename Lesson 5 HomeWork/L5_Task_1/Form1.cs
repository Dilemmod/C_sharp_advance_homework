using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5_Task_1
{
    public partial class Form1 : Form
    {
        private MyDatabaseEntities1 db;
        public Form1()
        {
            InitializeComponent();
            Database.SetInitializer(new DropCreateDatabaseAlways<MyDatabaseEntities1>());
            db = new MyDatabaseEntities1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.myTable.Load();
            dataGridView1.DataSource = db.myTable.Local.ToBindingList();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
        }
    }
}
