﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Business_Layer;
using Logic.Data_Layer;

namespace UI
{
    public partial class UserControlStaff : UserControl
    {
        public UserControlStaff()
        {
            InitializeComponent();
        }

        private void UserControlStaff_Load(object sender, EventArgs e)
        {
            DatagreedviewEmployees.DataSource = DbEmployees.GetAllEmployees();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DatagreedviewEmployees.DataSource = DbEmployees.SearchEmployee(TextBoxSearch.Text, DbEmployees.eSearchType.Name);
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            DatagreedviewEmployees.DataSource = DbEmployees.GetAllEmployees();
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            ComboBoxRole.SelectedIndex = ComboBoxRole.FindStringExact("All");
            TextBoxSearch.Text = "";
            TextBoxSearch.ForeColor = Color.Black;
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "")
            {
                TextBoxSearch.ForeColor = Color.Silver;
                TextBoxSearch.Text = "Type name here";
            }
        }

        private void ComboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatagreedviewEmployees.DataSource = DbEmployees.SearchEmployee(ComboBoxRole.Text, DbEmployees.eSearchType.Role);
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSearch.PerformClick();
            }
        }

        private void DatagreedviewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            TextBoxID.Text = string.Empty;
            TextBoxFullName.Text = string.Empty;
            TextBoxAddress.Text = string.Empty;
            TextBoxNumber.Text = string.Empty;
            TextBoxUsername.Text = string.Empty;
            TextBoxPassword.Text = string.Empty;
            TextBoxRetypePass.Text = string.Empty;
            ComboBoxEmployeeRole.ResetText();
            comboBoxEmployeeStatus.ResetText();
        }

        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee(TextBoxFullName.Text, TextBoxAddress.Text, TextBoxNumber.Text,
                TextBoxUsername.Text, ComboBoxEmployeeRole.SelectedIndex, comboBoxEmployeeStatus.SelectedIndex);

            DbEmployees.AddEmployee(newEmployee); //return bool
            clearFields();
            DatagreedviewEmployees.DataSource = DbEmployees.GetAllEmployees();
        }

        private void ButtonDeleteEmployee_Click(object sender, EventArgs e)
        {
            DbEmployees.DeleteEmployee(int.Parse(TextBoxID.Text)); //return bool
            clearFields();
            DatagreedviewEmployees.DataSource = DbEmployees.GetAllEmployees();
        }

        private void DatagreedviewEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (DatagreedviewEmployees.SelectedRows.Count > 0)
            {
                TextBoxID.Text = DatagreedviewEmployees.SelectedRows[0].Cells[0].Value.ToString();
                TextBoxFullName.Text = DatagreedviewEmployees.SelectedRows[0].Cells[1].Value.ToString();
                TextBoxAddress.Text = DatagreedviewEmployees.SelectedRows[0].Cells[2].Value.ToString();
                TextBoxNumber.Text = DatagreedviewEmployees.SelectedRows[0].Cells[3].Value.ToString();
                TextBoxUsername.Text = DatagreedviewEmployees.SelectedRows[0].Cells[5].Value.ToString();
                TextBoxPassword.Text = "****";
                ComboBoxEmployeeRole.SelectedIndex = ComboBoxEmployeeRole.
                    FindStringExact(DatagreedviewEmployees.SelectedRows[0].Cells[4].Value.ToString());
                comboBoxEmployeeStatus.SelectedIndex = comboBoxEmployeeStatus.
                    FindStringExact(DatagreedviewEmployees.SelectedRows[0].Cells[6].Value.ToString());
            }
        }

        private void DatagreedviewEmployees_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DatagreedviewEmployees.ClearSelection();
            clearFields();
        }
    }
}