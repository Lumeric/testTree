using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Drawing.Text;

namespace testTree
{
    public partial class mainForm : Form
    {
        private bool treeIsExpanded = false;

        public mainForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openXmlFileDialog = new OpenFileDialog();
            openXmlFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openXmlFileDialog.FilterIndex = 2;
            openXmlFileDialog.RestoreDirectory = true;

            if (openXmlFileDialog.ShowDialog() == DialogResult.OK)
            {
                RenderXMLFile(openXmlFileDialog.FileName);
            }
        }

        private void RenderXMLFile(string filepath)
        {
            try
            {
                string xmlString = File.ReadAllText(filepath, Encoding.UTF8);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlString);

                xmlTreeView.Nodes.Clear();
                xmlTreeView.Nodes.Add(new TreeNode(xmlDoc.DocumentElement.Name));

                TreeNode treeNode = new TreeNode();
                treeNode = xmlTreeView.Nodes[0];

                AddNode(xmlDoc.DocumentElement, treeNode);
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xmlNode;
            TreeNode treeNode;
            XmlNodeList xmlNodeList;

            if (inXmlNode.HasChildNodes)
            {
                xmlNodeList = inXmlNode.ChildNodes;

                for (int i = 0; i <= xmlNodeList.Count - 1; i++)
                {
                    xmlNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xmlNode.Name));
                    treeNode = inTreeNode.Nodes[i];
                    AddNode(xmlNode, treeNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.OuterXml.Trim();
            }
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            if (treeIsExpanded)
            {
                xmlTreeView.CollapseAll();
                treeIsExpanded = false;  
            }
            else
            {
                xmlTreeView.ExpandAll();
                treeIsExpanded = true;
            }
        }
    }
}

