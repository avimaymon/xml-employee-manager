//Made By Avi Maymon 300632445
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace proj1___XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Boolean firstTime = true; //boolean for showing xml message only once
        private string xmlFilePath = Directory.GetCurrentDirectory() + @"\EmployeeList.xml";
        private void WriteXmlFile()
        {
            try
            {
                CheckInputIsValid();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            XElement inputEmployee = GenerateXElement(); //Creating XElement from entered input controls

            if (File.Exists(xmlFilePath)) //if xml file exist add to it
                AddElement(inputEmployee);
            else                          //else create file and save first element
                SaveFirstElement(inputEmployee);
            if (txt_Load.Enabled)
                btn_LoadTxt.Text = "REFRESH!";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            WriteXmlFile();
        }

        private void chk_Married_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Married.Checked)
                combo_Children.Enabled = true;              //enable\disable children combo box
            else combo_Children.Enabled = false;
        }

        private void btn_LoadTxt_Click(object sender, EventArgs e)
        {

            if ((!txt_Load.Enabled || btn_LoadTxt.Text == "REFRESH!") && File.Exists(xmlFilePath))
                LoadText();
            else
                LoadTextError();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlFilePath))
                DeleteXmlFile();
            else
                MessageBox.Show("EmployeeList.xml doesnt exist!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private String getSelectedRadioButtonName()
        {
            foreach (Control c in grp_radio.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    return c.Text;
                }
            }
            return "null";
        }
        private XElement GenerateXElement()  //generate XElement from entered input
        {
            return new XElement("Employee",
                    new XElement("Name", txt_Name.Text),
                    new XElement("Age", txt_Age.Text),
                    new XElement("Gender", getSelectedRadioButtonName()),
                    new XAttribute("Department", combo_Dept.SelectedItem),
                    new XElement("Mobile", chk_Mobile.Checked ? "Yes" : "No"),
                    new XElement("Married", chk_Married.Checked ? "Yes" : "No"),
                    new XElement("Children", chk_Married.Checked ? combo_Children.SelectedItem : null));
        }
        private void AddElement(XElement inputEmployee1)
        {
            XDocument employees = XDocument.Load(xmlFilePath);
            employees.Element("Employees").Add(inputEmployee1);
            employees.Save(xmlFilePath);
            MessageBox.Show("Successfully added to XML file", "info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SaveFirstElement(XElement inputEmployee1)
        {
            MessageBox.Show("XML file not found, Creating EmployeeList.xml", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            XDocument employees = new XDocument(new XElement("Employees", inputEmployee1));

            employees.Save("EmployeeList.xml");
            MessageBox.Show("EmployeeList.xml Created Successfully!", "info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadText()
        {
            XDocument doc = XDocument.Load(xmlFilePath);
            StreamReader sr = new StreamReader(xmlFilePath);
            txt_Load.Text = "";
            while (!sr.EndOfStream)
            {
                txt_Load.Text += sr.ReadLine() + "\n";
            }
            sr.Close();
            if (firstTime)
            {   //show message only once to keep sanity of user
                MessageBox.Show("Showing content of EmployeeList.xml", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                firstTime = false;
            }
            txt_Load.Enabled = true;
            btn_LoadTxt.Text = "CLOSE";
        }
        private void LoadTextError()
        {
            if (!File.Exists(xmlFilePath))
                MessageBox.Show("EmployeeList.xml doesnt exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txt_Load.Text = "";
            txt_Load.Enabled = false;
            btn_LoadTxt.Text = "LOAD TEXT";
        }
        private void CheckInputIsValid()
        {
            if (txt_Name.Text == "" || txt_Age.Text == "" || (!radio_Male.Checked && !radio_Female.Checked)
                    || combo_Dept.SelectedItem == null || (chk_Married.Checked && combo_Children.SelectedItem == null)
                    || !Int32.TryParse(txt_Age.Text, out int a))
                throw new Exception("Fill required fields!");
        }
        private void DeleteXmlFile()
        {
            System.Windows.Forms.DialogResult dr = MessageBox.Show("Are you sure you want to delete EmployeeList.xml?",
                    "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                File.Delete(xmlFilePath);
                MessageBox.Show("EmployeeList.xml deleted successfully!", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txt_Load.Text = "";
            txt_Load.Enabled = false;
            btn_LoadTxt.Text = "LOAD TEXT";
        }
    }
}
