using System;
using System.Windows.Forms;
using DTD.Capawcino.BusinessLogic;
using DTD.Capawcino.DatabaseManager;
using DTD.Capawcino.Entities;

namespace DTD.Capawcino.UIExtra
{
    public partial class BusinessView : BaseControl
    {
        private BusinessConfigurations BusinessConfigurations;
        public BusinessView()
        {
            InitializeComponent();
            BusinessConfigurations = BusinessLogicManager.BusinessConfigurations;
            InitializeUI(BusinessConfigurations);
            EventSubscriber();
        }

        public void InitializeUI(BusinessConfigurations configs)
        {
            VatNumeric.Value = (decimal)configs.VatAmount*100;
        }


        private void EventSubscriber()
        {
            VatNumeric.ValueChanged += VatNumeric_ValueChanged;
        }

        private void VatNumeric_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown) sender;
            BusinessConfigurations.VatAmount = (float) numericUpDown.Value/100;
        }

        
        public void SaveConfigs()
        {
            new CRUDManager().UpsertRecord(DatabaseStrings.BusinessConfigTable,BusinessConfigurations.Id,BusinessConfigurations);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveConfigs();
        }
    }
}
