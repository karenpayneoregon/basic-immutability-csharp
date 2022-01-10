using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountriesFormsApp.Classes;
using ThirdPartyLibrary.Classes;
using ThirdPartyLibrary.Models;

namespace CountriesFormsApp
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _countryRecordsBindingSource = new();
        private readonly BindingSource _countryClassBindingSource = new();
        public Form1()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _countryRecordsBindingSource.DataSource = Records.Countries();
            CountryRecordListBox.DataSource = _countryRecordsBindingSource;
            CountryRecordListBox.DisplayMember = "name";

            _countryClassBindingSource.DataSource = References.Countries();
            CountryClassListBox.DataSource = _countryClassBindingSource;
            CountryClassListBox.DisplayMember = "Name";
        }

        private void CurrentCountryRecordButton_Click(object sender, EventArgs e)
        {
            CountryRecord current =(CountryRecord)CountryRecordListBox.SelectedItem;
            Dialogs.Information(CurrentCountryRecordButton, $"Key: {current.id}");
        }

        private void CountryClassButton_Click(object sender, EventArgs e)
        {
            Country current = (Country)CountryClassListBox.SelectedItem;
            Dialogs.Information(CountryClassButton, $"Key: {current.Id}");
        }
    }

   
}
