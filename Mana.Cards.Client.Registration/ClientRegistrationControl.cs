using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using Mana.Cards.API.Helpers;
using System.Web;
using System.Net;
using System.IO;
using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Services;
using Mana.Cards.API.ServiceInterfaces;
using MetroFramework;
using Mana.Cards.Client.Registration.Extensions;
using System.Threading;
using Newtonsoft.Json.Linq;
using Mana.Cards.API.ViewModels;

namespace Mana.Cards.Client
{
    public partial class ClientRegistrationControl : MetroUserControl
    {
        private AutoCompleteStringCollection CitiesAutocompleteCollection;

        public delegate void RegistrationHandler();

        public event RegistrationHandler OnSuccessfulRegistration;

        public ClientRegistrationControl()
        {
            InitializeComponent();
            CitiesAutocompleteCollection = new TaggedAutoCompleteStringCollection();
        }

        private void ClientRegistrationControl_Load(object sender, EventArgs e)
        {
            city.BackColor = Color.FromArgb(238, 238, 238);
            city.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;


            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            InitGenders();
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = e.Result as TaggedAutoCompleteStringCollection;

            if (result == null) return;

            if (city.InvokeRequired)
            {
                city.Invoke(new Action(() =>
                {
                    city.AutoCompleteCustomSource = result;
                }));
            }
            else
            {
                city.AutoCompleteCustomSource = result;
            }

        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var collection = new CitiesAutocompleter().SearchCities(city.Text);
            e.Result = collection;
        }
        private void InitGenders()
        {
            object[] genders = new[] { new { Value = "male", Text = "Mashkull" }, new { Value = "female", Text = "Femër" } };

            gender.DataSource = genders;
            gender.ValueMember = "Value";
            gender.DisplayMember = "Text";
            gender.SelectedIndex = -1;
        }

        private void registerClient_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (agree.Checked)
                {
                    bool result = false;
                    registerClient.Enabled = false;

                    if (CurrentClient == null)
                        result = this.CreateClient();
                    else
                        result = this.UpdateClient();

                    registerClient.Enabled = true;

                    if (result)
                    {
                        if (OnSuccessfulRegistration != null)
                        {
                            OnSuccessfulRegistration();
                        }

                        ClearFields();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this.ParentForm, "Ju duhet të pajtoheni me kushtet dhe afatet", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CreateClient()
        {
            IClientService service = new ClientService();
            int cityId = 0;

            Int32.TryParse(city.GetTag() != null ? city.GetTag().ToString() : string.Empty, out cityId);

            try
            {
                service.CreateClient(new Mana.Cards.API.Domain.Client()
                {
                    Firstname = firstName.Text,
                    Lastname = lastName.Text,
                    Email = email.Text,
                    Address = address.Text,
                    Phone = phone.Text,
                    City = cityId,
                    Gender = gender.SelectedValue as string,
                    Birthdate = birth_date.Value
                }, card.Text);

                MetroMessageBox.Show(this.ParentForm, "Të dhënat u regjistruan me sukses", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this.ParentForm, e.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool UpdateClient()
        {
            IClientService service = new ClientService();
            try
            {
                service.UpdateClient(new Mana.Cards.API.Domain.Client()
                {
                    Id = CurrentClient.Id
                }, card.Text);

                MetroMessageBox.Show(this.ParentForm, "Të dhënat u regjistruan me sukses", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this.ParentForm, e.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ClearFields()
        {
            firstName.Text = lastName.Text = phone.Text = email.Text = address.Text = city.Text = card.Text = "";


            this.CurrentClient = null;
        }
        private void EnableFields(bool value)
        {
            firstName.Enabled = lastName.Enabled = phone.Enabled = email.Enabled = address.Enabled = city.Enabled = gender.Enabled = birth_date.Enabled = value;
        }
        private void LoadFields(ClientViewModel client)
        {
            firstName.Text = client.Firstname;
            lastName.Text = client.Lastname;
            phone.Text = client.Phone;
            email.Text = client.Email;
            address.Text = client.Address;
            city.Text = client.City;


            if (client.Gender != null)
                gender.SelectedValue = client.Gender;

            if (client.Birthdate.HasValue)
                birth_date.Value = client.Birthdate.Value;
        }

        private bool IsValid()
        {
            bool valid = true;

            var requiredFields = new KeyValuePair<MetroLabel, IMetroControl>[] { 
                new KeyValuePair<MetroLabel, IMetroControl>(firstNameLabel, firstName), 
                new KeyValuePair<MetroLabel, IMetroControl>(lastNameLabel, lastName),
                new KeyValuePair<MetroLabel, IMetroControl>(phoneLabel, phone),
                new KeyValuePair<MetroLabel, IMetroControl>(cardLabel, card)
                };


            if (CurrentClient != null)
                requiredFields = new KeyValuePair<MetroLabel, IMetroControl>[] { requiredFields.Last() };


            foreach (var field in requiredFields)
            {
                var label = field.Key;
                var textField = field.Value as MetroTextBox;

                label.UseCustomForeColor = false;

                if (textField.Text.ToString().IsNullOrWhiteSpace())
                {
                    valid = false;

                    label.UseCustomForeColor = true;
                    label.ForeColor = Color.Red;
                }
                label.Refresh();
            }

            return valid;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (city.Text.Length < 2)
            {
                AutocompleteReset = true;
            }
            if (city.Text.Length >= 2 && AutocompleteReset)
            {
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
                AutocompleteReset = false;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            city.Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ClientSearchForm form = new ClientSearchForm();

            form.ShowDialog();

            if (form.SelectedClient != null)
            {
                this.CurrentClient = form.SelectedClient;
                this.EnableFields(false);
                this.LoadFields(this.CurrentClient);
            }
        }
        private void clearFieldsBtn_Click(object sender, EventArgs e)
        {
            this.ClearFields();
            this.EnableFields(true);
        }

        #region Private properties
        private bool AutocompleteReset = true;
        private ClientViewModel CurrentClient { get; set; }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("KushtetDheAfatet.txt");
        }

    }
}
