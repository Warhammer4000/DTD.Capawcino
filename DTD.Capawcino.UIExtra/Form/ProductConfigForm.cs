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
        public List<Tag> Tags;

        public ProductConfigForm()
        {
            InitializeComponent();


            TagGrid.CellPainting += grid_CellPainting;
            TypeGrid.CellPainting += grid_CellPainting;

            TypeGrid.CellContentClick += TypeGrid_CellContentClick;
            TagGrid.CellContentClick += TagGrid_CellContentClick;

            

            UpdateTags();
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

        private void UpdateTags()
        {
            Tags = new CRUDManager().LoadRecords<Tag>(DatabaseStrings.TagsTable);
            TagGrid.DataSource = null;
            TagGrid.Columns.Clear();
            TagGrid.DataSource = Tags;
            ButtonsColumnSetup(TagGrid);
        }




        private void ButtonsColumnSetup(DataGridView dataGrid)
        {
           
            DataGridViewButtonColumn updatebuttons = new DataGridViewButtonColumn();
            {
                updatebuttons.HeaderText = @"Update";
                updatebuttons.FlatStyle = FlatStyle.Flat;
                updatebuttons.CellTemplate.Style.BackColor = Color.LightSeaGreen;
                updatebuttons.CellTemplate.Style.ForeColor = Color.White;
            }

            dataGrid.Columns.Add(updatebuttons);



            DataGridViewButtonColumn removebuttons = new DataGridViewButtonColumn();
            {
                removebuttons.HeaderText = @"Remove";
                
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

        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridView dataGrid = (DataGridView)sender;
   
            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var resource = Properties.Resources.diskette;
                var w = resource.Width;
                var h = resource.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(resource, new Rectangle(x, y, w, h));
                e.Handled = true;
            }


            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var resource = Properties.Resources.rubbish_bin;
                var w = resource.Width;
                var h = resource.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(resource, new Rectangle(x, y, w, h));
                e.Handled = true;
            }


        }

        private void TypeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0)return;

            DataGridView dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                // to do: edit actions here
                ProductType type = (ProductType)dataGrid.Rows[e.RowIndex].DataBoundItem;
                new CRUDManager().UpsertRecord(DatabaseStrings.TypeTable, type.Id,type);
                UpdateTypes();
            }


            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                // to do: edit actions here
                if (MessageBox.Show(@"This will be removed from database", @"Are You Sure?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Hand)==DialogResult.Yes)
                {
                    ProductType type = (ProductType)dataGrid.Rows[e.RowIndex].DataBoundItem;
                    new CRUDManager().DeleteRecord<ProductType>(DatabaseStrings.TypeTable,type.Id);
                    UpdateTypes();
                }
            }

        }



        private void TagGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
               
                Tag tag = (Tag)dataGrid.Rows[e.RowIndex].DataBoundItem;
                new CRUDManager().UpsertRecord(DatabaseStrings.TagsTable, tag.Id, tag);
                UpdateTags();
            }


            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
            
                if (MessageBox.Show(@"This will be removed from database", @"Are You Sure?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    Tag tag = (Tag)dataGrid.Rows[e.RowIndex].DataBoundItem;
                    new CRUDManager().DeleteRecord<Tag>(DatabaseStrings.TagsTable, tag.Id);
                    UpdateTags();
                }
            }

        }


        private void AddButtonTag_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TagText.Text)) return;
            new CRUDManager().InsertRecord(DatabaseStrings.TagsTable, new Tag() { Name = TypeText.Text, Active = true });
            TypeText.Text = "";
            UpdateTags();
        }
    }
}
