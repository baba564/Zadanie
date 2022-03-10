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
using Raport.Enitity;

namespace Raport
{
    public partial class Form1 : Form
    {
        public Model1 model { get; set; } 
       
        public Form1()
        {
            UserSetting.LoadSetting();
            InitializeComponent();
            model = new Model1();
            LoadComboBox();
            Load();
        }

        public List<ListaRaportu> LoadElements(int rokOd,int miesiacOd,int dzienOd, int rokDo, int miesiacDo, int dzienDo,string lokal)
        {
            

            var lista = model.Database.SqlQuery<ListaRaportu>($@"select Nazwa,Data,Godzina,Użytkownik,Lokal from dbo.Raport where Lokal='{lokal}' and Data between '{rokOd}-{miesiacOd}-{dzienOd}' and '{rokDo}-{miesiacDo}-{dzienDo}'
					").ToList();


            return lista;
        }
        public void Load()
        {
          

            var lista = model.Database.SqlQuery<ListaRaportu>($@"select Nazwa,Data,Godzina,Użytkownik,Lokal from dbo.Raport
					").ToList();

            dataGridView1.DataSource = lista;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //od
            int rokOd = dateTimePicker1.Value.Date.Year;
            int miesiacOd = dateTimePicker1.Value.Date.Month;
            int dzienOd = dateTimePicker1.Value.Date.Day;
            //do
            int rokDo = dateTimePicker2.Value.Date.Year;
            int miesiacDo = dateTimePicker2.Value.Date.Month;
            int dzienDo = dateTimePicker2.Value.Date.Day;

            string lokal = comboBox1.Text;
            dataGridView1.DataSource = LoadElements(rokOd, miesiacOd, dzienOd, rokDo, miesiacDo, dzienDo,lokal);

        }
        public void LoadComboBox()
        {
            var itemsComboBox= model.Database.SqlQuery<string>($@"select distinct Lokal from dbo.Raport
					").ToList();
            foreach(string i in itemsComboBox)
            {
                comboBox1.Items.Add(i);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
