using Mana.Cards.API.ServiceInterfaces;
using Mana.Cards.API.Services;
using Mana.Cards.API.ViewModels;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mana.Cards.Client
{
    public partial class ClientSearchForm : MetroForm
    {
        public ClientSearchForm()
        {
            InitializeComponent();
        }

        private void ClientSearchForm_Load(object sender, EventArgs e)
        {
            clientsGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 83, 129);
        }

        private void search_Click(object sender, EventArgs e)
        {
            search.Text = "Duke kërkuar...";
            search.Enabled = false;

            backgroundSearcher.RunWorkerAsync();
        }
        private void backgroundSearcher_DoWork(object sender, DoWorkEventArgs e)
        {
            IClientService c = new ClientService();
            try
            {
                var clients = c.Search(firstnameTxt.Text, lastnameTxt.Text, emailTxt.Text, phoneTxt.Text);
                e.Result = clients;
            }
            catch (Exception ex)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        MetroMessageBox.Show(this, ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
                else
                {
                    MetroMessageBox.Show(this, ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backgroundSearcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var clients = e.Result as IEnumerable<ClientViewModel>;

            if (clients == null) return;

            var action = new Action(() =>
            {
                clientsGrid.Columns.Clear();
                clientsGrid.DataSource = clients;
                clientsGrid.Columns["Id"].Visible = false;
                clientsGrid.Columns["Gender"].Visible = false;
                clientsGrid.Columns["Address"].Visible = false;

                clientsGrid.Columns["Firstname"].HeaderText = "Emri";
                clientsGrid.Columns["Lastname"].HeaderText = "Mbiemri";
                clientsGrid.Columns["Email"].HeaderText = "E-maili";
                clientsGrid.Columns["Phone"].HeaderText = "Nr. tel";
                clientsGrid.Columns["Birthdate"].HeaderText = "Data e lindjes";
                clientsGrid.Columns["City"].HeaderText = "Qyteti";


                search.Text = "Kërko";
                search.Enabled = true;
            });

            if (clientsGrid.InvokeRequired)
            {
                clientsGrid.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void clientsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clientsGrid.SelectedRows.Count > 0)
            {
                var client = clientsGrid.SelectedRows[0].DataBoundItem as ClientViewModel;

                this.SelectedClient = client;
                this.Close();
            }
        }

        public ClientViewModel SelectedClient { get; set; }

        private void clientsGrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in ((DataGridView)sender).SelectedCells)
            {
                cell.Style = new DataGridViewCellStyle()
                {
                    SelectionForeColor = SystemColors.HighlightText,
                    SelectionBackColor = Color.FromArgb(0, 83, 129)
                };
            }
        }

    }
}
