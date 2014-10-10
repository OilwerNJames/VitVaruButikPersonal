﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VitVaruPersonal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        MySqlConnection dbConn;
        
        

        public void connectToMySql()
        {
            string strConnect = "server=" + "195.178.235.60" + ";uid=" + "ad3193" + ";pwd=" + "941224" + ";database=" + "ad3193";
            try
            {
                dbConn = new MySqlConnection(strConnect);
                dbConn.Open();
                if (dbConn.State.ToString() != "Open")
                {
                    MessageBox.Show("Could not open database connection");
                    return;
                }
            }
            catch (Exception ex)  // catch on general exceptions, not specific
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchtext = txtSearch.Text;
            rdbUppdatera.Checked = true;
            search(searchtext);
            updateGUIuppdateraraiobuttonenabled();
        }

        private string createSqlQuery(string textbox)
        {
            string sql = ("SELECT namn, pris, tillverkare, modell, produktbeskrivning, inköpspris, varugrupp, energiklass, lagersaldo, artikelnummer FROM produkt WHERE artikelnummer = '" + textbox + "'");

            return sql;
        }
        
        private void search(string searchtext)
        {
            connectToMySql();

            string sql;
            MySqlCommand cmd;
            MySqlDataReader rdr;

            sql = createSqlQuery(searchtext);

            cmd = new MySqlCommand(sql, dbConn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                txtNamn.Text = rdr.GetString(0);
                txtPris.Text = rdr.GetString(1);
                txtTillverkare.Text = rdr.GetString(2);
                txtModel.Text = rdr.GetString(3);
                txtProduktBeskrivning.Text = rdr.GetString(4);
                txtInköpsris.Text = rdr.GetString(5);
                txtVarugrupp.Text = rdr.GetString(6);
                txtEnergiklass.Text = rdr.GetString(7);
                txtLagersaldo.Text = rdr.GetString(8);
                txtArtikelnummer.Text = rdr.GetString(9);
            }

        }
        private void updateGUI()
        {
            
        }

        private void updateGUIuppdateraraiobuttonenabled()
        {
            txtArtikelnummer.ReadOnly = true;
        }

        private void rdbLäggtill_CheckedChanged(object sender, EventArgs e)
        {
            btnLäggtill.Text = "Lägg till produkt";
            ClearAll();

            txtArtikelnummer.ReadOnly = false;
        }

        private void rdbUppdatera_CheckedChanged(object sender, EventArgs e)
        {
            btnLäggtill.Text = "Uppdatera produkt";
            updateGUIuppdateraraiobuttonenabled();
        }

        private void btnLäggtill_Click(object sender, EventArgs e)
        {
            if (rdbUppdatera.Checked)
            {
                if (
                    (txtLagersaldo.Text != string.Empty)
                    && (txtPris.Text != string.Empty)
                     && (txtNamn.Text != string.Empty)
                     && (txtModel.Text != string.Empty)
                     && (txtTillverkare.Text != string.Empty)
                     && (txtProduktBeskrivning.Text != string.Empty)
                     && (txtInköpsris.Text != string.Empty)
                     && (txtArtikelnummer.Text != string.Empty)
                     && (txtEnergiklass.Text != string.Empty)
                     && (txtVarugrupp.Text != string.Empty))
                {



                    connectToMySql();


                    string sql;
                    MySqlCommand cmd;

                    sql = "UPDATE produkt SET namn = '" + txtNamn.Text + "', pris = '" + txtPris.Text + "', tillverkare = '" + txtTillverkare.Text + "', modell = '" + txtModel.Text + "', energiklass = '" + txtEnergiklass.Text + "', produktbeskrivning = '" + txtProduktBeskrivning.Text + "', inköpspris = '" + txtInköpsris.Text + "', lagersaldo = '" + txtLagersaldo.Text + "' WHERE artikelnummer = '" + txtArtikelnummer.Text + "'";

                    cmd = new MySqlCommand(sql, dbConn);
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    ClearAll();

                }
                else
                {
                    MessageBox.Show("ERR");
                }
            }
            else // Uppdatera
            {
                if (
                    (txtLagersaldo.Text != string.Empty)
                    && (txtPris.Text != string.Empty)
                     && (txtNamn.Text != string.Empty)
                     && (txtModel.Text != string.Empty)
                     && (txtTillverkare.Text != string.Empty)
                     && (txtProduktBeskrivning.Text != string.Empty)
                     && (txtInköpsris.Text != string.Empty)
                     && (txtArtikelnummer.Text != string.Empty)
                     && (txtEnergiklass.Text != string.Empty)
                     && (txtVarugrupp.Text != string.Empty))
                {



                    connectToMySql();


                    string sql;
                    MySqlCommand cmd;

                    sql = "insert into produkt (artikelnummer, namn, pris, tillverkare, modell, produktbeskrivning, inköpspris, energiklass, varugrupp, lagersaldo) values( '" +
txtArtikelnummer.Text + "', '" + txtNamn.Text + "', '" + txtPris.Text + "', '" + txtTillverkare.Text + "', '" + txtModel.Text + "', '" + txtProduktBeskrivning.Text + "', '" + txtInköpsris.Text + "', '" + txtEnergiklass.Text + "', '" + txtVarugrupp.Text + "', '" + txtLagersaldo.Text + "' " + ")";
                   // sql = "UPDATE produkt SET namn = '" + txtNamn.Text + "', pris = '" + txtPris.Text + "', tillverkare = '" + txtTillverkare.Text + "', modell = '" + txtModel.Text + "', energiklass = '" + txtEnergiklass.Text + "', produktbeskrivning = '" + txtProduktBeskrivning.Text + "', inköpspris = '" + txtInköpsris.Text + "', lagersaldo = '" + txtLagersaldo.Text + "' WHERE artikelnummer = '" + txtArtikelnummer.Text + "'";

                    cmd = new MySqlCommand(sql, dbConn);
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    ClearAll();

                }
                else
                {
                    MessageBox.Show("ERR");
                }
            }
        }

        private void btnTarbort_Click(object sender, EventArgs e)
        {

            if (
                   (txtLagersaldo.Text != string.Empty)
                   && (txtPris.Text != string.Empty)
                    && (txtNamn.Text != string.Empty)
                    && (txtModel.Text != string.Empty)
                    && (txtTillverkare.Text != string.Empty)
                    && (txtProduktBeskrivning.Text != string.Empty)
                    && (txtInköpsris.Text != string.Empty)
                    && (txtArtikelnummer.Text != string.Empty)
                    && (txtEnergiklass.Text != string.Empty)
                    && (txtVarugrupp.Text != string.Empty))
            {
                connectToMySql();


                string sql;
                MySqlCommand cmd;

                sql = "delete from produkt where artikelnummer = '" + txtArtikelnummer.Text + "'";
               
                cmd = new MySqlCommand(sql, dbConn);
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
               
                ClearAll();
                
            }

        }

        private void ClearAll()
        {

            txtNamn.Clear();
            txtPris.Clear();
            txtTillverkare.Clear();
            txtModel.Clear();
            txtProduktBeskrivning.Clear();
            txtInköpsris.Clear();
            txtVarugrupp.Clear();
            txtEnergiklass.Clear();
            txtLagersaldo.Clear();
            txtArtikelnummer.Clear();
            txtSearch.Clear();
        }

    }   
}
