using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(
                "Persist Security Info=False; server=localhost;database=db_conexaomysql;uid=root");

            mConn.Open(); // Abre a conexão

            // Monta a consulta SQL
            string consultaSql = String.Format("INSERT INTO produto(nome, descr, valor) values ('{0}', '{1}', {2})",
                txtNome.Text, txtDescr.Text,
                double.Parse(txtValor.Text).ToString(CultureInfo.InvariantCulture));

            MySqlCommand command = new MySqlCommand(consultaSql, mConn);
            command.ExecuteNonQuery(); // Executa a consulta SQL na conexão aberta

            mConn.Close(); // Fecha a conexão
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            mDataSet = new DataSet(); // Cria um conjunto de dados para receber resultado da consulta SQL

            mConn = new MySqlConnection(
                "Persist Security Info=False; server=localhost;database=db_conexaomysql;uid=root");

            mConn.Open(); // Abre a conexão

            // cria um adapter utilizando a instrução SQL para aceder à tabela
            mAdapter = new MySqlDataAdapter("SELECT * FROM produto ORDER BY id", mConn);

            // preenche o dataset através do adapter
            mAdapter.Fill(mDataSet, "produto");

            // atribui o resultado à propriedade DataSource da dataGridView
            dataGridView2.DataSource = mDataSet;
            dataGridView2.DataMember = "produto";
        }
    }
}
