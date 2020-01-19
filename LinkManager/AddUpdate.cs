using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LinkManager
{
    public partial class AddUpdate : Form
    {
        string id, label, url, path;
        bool isAdd = true;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxLabel.Text) || string.IsNullOrEmpty(textBoxPath.Text) || string.IsNullOrEmpty(textBoxUrl.Text))
            {
                MessageBox.Show("Please enter the values.");
            }
            else
            {
                try
                {
                    Utility uti = new Utility();
                    XmlDocument inputXml = new XmlDocument();
                    inputXml = uti.readInputFile();
                    XmlNodeList nodeList = inputXml.SelectNodes("/ROOT/NODE");
                    int actualId = 0;
                    int maxId = 0;
                    foreach (XmlNode node in nodeList)
                    {
                        string id = node.Attributes["Id"].InnerText;
                        actualId = Convert.ToInt32(id);
                        if (actualId > maxId)
                            maxId = actualId;
                    }

                    XmlNode root = inputXml.DocumentElement;
                    XmlElement elem = inputXml.CreateElement("NODE");
                    elem.SetAttribute("Id", Convert.ToString(maxId+1));
                    elem.SetAttribute("Label", textBoxLabel.Text);
                    elem.SetAttribute("URL", textBoxUrl.Text);
                    elem.SetAttribute("PhysicalPath", textBoxPath.Text);
                    root.AppendChild(elem);

                    inputXml.Save(uti.getFileName());
                    this.Close();

                }
                catch (Exception ex) { }
            }
        }

        public AddUpdate()
        {
            InitializeComponent();
        }
        public void setValue(bool isAddValue, string idValue, string labelValue, string urlValue, string pathValue)
        {
            isAdd = isAddValue;
            id = idValue;
            label = labelValue;
            url = urlValue;
            path = pathValue;
        }
        private void AddUpdate_Load(object sender, EventArgs e)
        {
            //if (!isAdd)
            //{
            //    textBoxLabel.Text = label;
            //    textBoxUrl.Text = url;
            //    textBoxPath.Text = path;

            //    buttonAdd.Enabled = true;
            //    buttonUpdate.Enabled = false;
            //}
            //else
            //{
            //    buttonAdd.Enabled = false;
            //    buttonUpdate.Enabled = true;
            //}

        }
    }
}
