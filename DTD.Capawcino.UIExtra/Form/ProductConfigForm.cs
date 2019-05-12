using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Capawcino.DatabaseManager;
using DTD.Capawcino.Entities;

namespace DTD.Capawcino.UIExtra.Form
{
    public partial class ProductConfigForm : BaseForm
    {
        public List<ProductType> Types;


        public ProductConfigForm()
        {
            InitializeComponent();
            TypeGrid.CellContentClick += TypeGrid_CellContentClick;
            UpdateTypes();
        }

        private void UpdateTypes()
        {
            Types = new CRUDManager().LoadRecords<ProductType>(DatabaseStrings.TypeTable);
            TypeGrid.DataSource = null;
            TypeGrid.Columns.Clear();
            TypeGrid.DataSource = Types;
            ButtonsColumnSetup(TypeGrid);
        }

        private void ButtonsColumnSetup(DataGridView dataGrid)
        {
           
            DataGridViewButtonColumn updatebuttons = new DataGridViewButtonColumn();
            {
                updatebuttons.HeaderText = @"Update";
                updatebuttons.Text = "Update";
                updatebuttons.UseColumnTextForButtonValue = true;
                updatebuttons.FlatStyle = FlatStyle.Flat;
                updatebuttons.CellTemplate.Style.BackColor = Color.DimGray;
                updatebuttons.CellTemplate.Style.ForeColor = Color.White;
            }

            dataGrid.Columns.Add(updatebuttons);



            DataGridViewButtonColumn removebuttons = new DataGridViewButtonColumn();
            {
                removebuttons.HeaderText = @"Remove";
                removebuttons.Text = "Remove";
                removebuttons.UseColumnTextForButtonValue = true;
                removebuttons.FlatStyle = FlatStyle.Flat;
                removebuttons.CellTemplate.Style.BackColor = Color.Red;
                removebuttons.CellTemplate.Style.ForeColor = Color.White;
            }

            dataGrid.Columns.Add(removebuttons);



        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TypeText.Text))return;
            new CRUDManager().InsertRecord(DatabaseStrings.TypeTable,new ProductType(){Name = TypeText.Text,Active = true});
            TypeText.Text = "";
            UpdateTypes();
        }



        private void TypeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                // to do: edit actions here
                MessageBox.Show("Update");
            }


            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                // to do: edit actions here
                MessageBox.Show("Remove");
            }

        }

    }
}
