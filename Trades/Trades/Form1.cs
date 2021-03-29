using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trades.Model;
using Trades.Model.Interfaces;
using Trades.Services.Interfaces;

namespace Trades
{
    public partial class Form1 : Form
    {
        private static List<string> tradeCategories;
        private static List<ITrade> portfolio;
        private readonly ITradeService _tradeService;

        public Form1(ITradeService tradeService)
        {
            InitializeComponent();
            _tradeService = tradeService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValor.Text = string.Empty;
            tradeCategories = new List<string>();
            portfolio = new List<ITrade>();
            cmbSetor.Items.Add("Public");
            cmbSetor.Items.Add("Private");
            cmbSetor.SelectedIndex = 0;
        }

        private void btnListarCategorias_Click(object sender, EventArgs e)
        {
            tradeCategories.Clear();
            foreach(var i in portfolio)
            {
                tradeCategories.Add(_tradeService.GetCategory(i));
            }

            MessageBox.Show($"Categorias: {string.Join(" ", tradeCategories)}");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            portfolio.Add(new Trade { Value = Convert.ToDouble(txtValor.Text), ClientSector = cmbSetor.SelectedItem.ToString() });
            MessageBox.Show("Adicionado");
        }
    }
}
