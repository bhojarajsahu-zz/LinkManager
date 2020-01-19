using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LinkManager
{
    public partial class Home : Form
    {
        string Id, Label, Url, Path;
        bool isAdd = true;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            processFile();
        }
        

        private void dataGridViewLinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1)
            {
                try
                {
                    Id = dataGridViewLinks.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Label = dataGridViewLinks.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Url = dataGridViewLinks.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Path = dataGridViewLinks.Rows[e.RowIndex].Cells[3].Value.ToString();

                    string value = dataGridViewLinks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    if (value.Contains("http"))
                    {
                        //open web url
                        this.Cursor = Cursors.WaitCursor;
                        Process.Start(value);
                        //var prcess = Process.Start(value);
                        //prcess.WaitForExit();
                        this.Cursor = Cursors.Default;
                    }
                    else
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Process.Start("explorer.exe", value);
                        //var prcess = Process.Start("explorer.exe", value);
                        //prcess.WaitForExit();
                        this.Cursor = Cursors.Default;
                        //open file path
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select proper value.");
                }
            }
            //try
            //{
            //    Id = dataGridViewLinks.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    Label = dataGridViewLinks.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    Url = dataGridViewLinks.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    Path = dataGridViewLinks.Rows[e.RowIndex].Cells[3].Value.ToString();
            //}
            //catch (Exception ex) { }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AddUpdate au = new AddUpdate();
            au.setValue(false, Id, Label, Url, Path);
            au.Show();
        }

        private void dataGridViewLinks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = dataGridViewLinks.Rows[e.RowIndex].Cells[0].Value.ToString();
                Label = dataGridViewLinks.Rows[e.RowIndex].Cells[1].Value.ToString();
                Url = dataGridViewLinks.Rows[e.RowIndex].Cells[2].Value.ToString();
                Path = dataGridViewLinks.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void dataGridViewLinks_SelectionChanged(object sender, EventArgs e)
        {
        }

        public void processFile()
        {
            Utility uti = new Utility();
            XmlDocument inputXml = new XmlDocument();
            inputXml = uti.readInputFile();
            try
            {
                dataGridViewLinks.Columns.Clear();
                dataGridViewLinks.Rows.Clear();

                dataGridViewLinks.Columns.Add("Id", "Id");
                dataGridViewLinks.Columns.Add("Label", "Label");
                dataGridViewLinks.Columns.Add("URL", "URL");
                dataGridViewLinks.Columns.Add("Physical Location", "Physical Location");

                dataGridViewLinks.Columns[0].Visible = false;

                if (inputXml != null)
                {
                    XmlNodeList nodeList = inputXml.SelectNodes("/ROOT/NODE");
                    foreach (XmlNode node in nodeList)
                    {
                        string id = node.Attributes["Id"].InnerText;
                        string label = node.Attributes["Label"].InnerText;
                        string url = node.Attributes["URL"].InnerText;
                        string explorer = node.Attributes["PhysicalPath"].InnerText;

                        dataGridViewLinks.Rows.Add(id,label, url, explorer);
                    }
                }
            }
            catch(Exception ex)
            { }
        }

        private void dataGridViewLinks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUpdate au = new AddUpdate();
            au.FormClosed += Au_FormClosed;
            au.setValue(true, Id, Label, Url, Path);
            au.Show();
        }

        private void Au_FormClosed(object sender, FormClosedEventArgs e)
        {
            processFile();
        }
    }
}
