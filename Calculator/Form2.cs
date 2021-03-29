using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            setLV();
            SetDGV();
        }
        public void setLV()
        {
            ColumnHeader c1 = new ColumnHeader();
            ColumnHeader c2 = new ColumnHeader();
            ColumnHeader c3 = new ColumnHeader();
            c1.Text = "MSSV";
            c2.Text = "Name";
            c3.Text = "DTB";

            listView1.Columns.AddRange(new ColumnHeader[] { c1, c2, c3 });
            ListViewItem listItem = new ListViewItem();
            listItem.Text = "101";
            ListViewItem.ListViewSubItem sbItem1 = new ListViewItem.ListViewSubItem();
            sbItem1.Text = "NVA";
            ListViewItem.ListViewSubItem sbItem2 = new ListViewItem.ListViewSubItem();
            sbItem2.Text = "1.1";
            listItem.SubItems.AddRange(new ListViewItem.ListViewSubItem[] { sbItem1, sbItem2 });
            listView1.Items.Add(listItem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           ListView.SelectedListViewItemCollection selected = listView1.SelectedItems;
            string s = "";
            if(selected.Count > 0){
                foreach (ListViewItem i in selected)
                {
                    string MSSV = i.Text;
                    string name = i.SubItems[1].Text;
                    string dtb = i.SubItems[2].Text;
                    s += MSSV + " " + name + " " + dtb;


                }
                MessageBox.Show(s);
            }
         
        }
        public void SetDGV()
        {
            SV[] arr = new SV[]
            {
               new SV ( "102", "NCN" , 2.2, true),
            };
            List<SV> l = new List<SV>();
            l.AddRange(new SV[]
            {
                new SV ( "101", "NCN" , 2.2, true),
                new SV ( "102", "HQ" , 2.2,false),
 new SV ( "103", "NTN" , 2.3, true), 
            });
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV"),
                new DataColumn("Name"),
                new DataColumn("DTB"),
                new DataColumn("Gender",typeof(bool))
            }); 

            foreach(SV sv in l)
            {
                DataRow dr = dt.NewRow();
                dr["MSSV"] = sv.MSSV;
                dr["Name"] = sv.Name;
                dr["DTB"] = sv.DTB;
                dr["Gender"] = sv.gender;
                dt.Rows.Add(dr);
             }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection rowSelected =dataGridView1.SelectedRows;
            if(rowSelected.Count >= 1)
            {
                string s = "";
                foreach(DataGridViewRow i in rowSelected)
                {
                    string MSSV = i.Cells["MSSV"].Value.ToString();
                    string name = i.Cells["Name"].Value.ToString();
                    double dtb = Convert.ToDouble(i.Cells["DTB"].Value.ToString());
                    bool Gender = Convert.ToBoolean(i.Cells["Gender"].Value.ToString());
                    s = MSSV + ", " + name + ", " + dtb + ", " + Gender + "\n";
                }
                MessageBox.Show(s);
            }
        }
    }
}
