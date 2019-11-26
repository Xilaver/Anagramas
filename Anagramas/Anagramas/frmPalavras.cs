using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anagramas
{
    public partial class frmPalavras : Form
    {
        public frmPalavras()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtPalavra.Text;
                if (nome.Where(c => char.IsNumber(c)).Count() > 0)
                {
                    MessageBox.Show("Caracteres inválidos forem encontrados na expressão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (nome.Where(c => char.IsPunctuation(c)).Count() > 0)
                    {
                        MessageBox.Show("Caracteres inválidos forem encontrados na expressão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        if (nome.Where(c => char.IsSymbol(c)).Count() > 0)
                        {
                            MessageBox.Show("Caracteres inválidos forem encontrados na expressão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            if (nome.Where(c => char.IsControl(c)).Count() > 0)
                            {
                                MessageBox.Show("Caracteres inválidos forem encontrados na expressão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else
                            {
                                if (nome.Where(c => char.IsLowSurrogate(c)).Count() > 0)
                                {
                                    MessageBox.Show("Caracteres inválidos forem encontrados na expressão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                                else
                                {
                                    if (nome.Where(c => char.IsHighSurrogate(c)).Count() > 0)
                                    {
                                        MessageBox.Show("Caracteres inválidos forem encontrados na expressão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }
                                    else
                                    {


                                        MessageBox.Show("Não há Caracetres especiais.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }

                            }

                        }

                    }

                }
            }
            catch (Exception)
            {

            }

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ofdLocalizar.DefaultExt = "txt";
            ofdLocalizar.Filter = "TXT Files|*.txt";
            ofdLocalizar.ShowDialog();

            string fileName = ofdLocalizar.FileName;
            try
            {
                string readFile = File.ReadAllText(fileName);
                rtbPalavras.Text = readFile;
            }
            catch
            {

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // .....
        }
    }
}
