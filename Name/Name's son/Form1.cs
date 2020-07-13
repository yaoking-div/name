using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_s_son
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeopleCurdRepository Database = new PeopleCurdRepository();
            this.dataGridView.DataSource = Database.GetAll();
        }
    }
    class PeopleCurdRepository : RepositoryBase<People> { }
    class People : DomainModel
    {
        public People()
        {


        }

        //成员方法 行为
        public void Eat(int foodSize)
        {
            HungerIndex = HungerIndex + foodSize / 2;
        }
        //成员变量
        int HungerIndex;
        public string Name;
        public bool Gender;
        public int Age;
        public DateTime Birthday;
        public string Professional;
    }
}   
