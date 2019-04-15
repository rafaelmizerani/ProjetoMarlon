using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Marlon
{
    public partial class frmConversao : Form
    {
        public frmConversao()
        {
            InitializeComponent();
        }

        private void btnConversao_Click(object sender, EventArgs e)
        {

            switch (nmrBaseInicial.Value)
            {
                case 2:
                    try
                    {
                        MessageBox.Show($"Base  5: {ConvBase5.ConvTo5(Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 2)))}" +
                                        $"\nBase  8: {Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 2), 8)}" +
                                        $"\nBase 10: {Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 2), 10)}" +
                                        $"\nBase 16: {Convert.ToUInt32(txtEntrada.Text, 2).ToString("X")}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Use apenas os números 0 e 1!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 5:

                    try
                    {
                        Regex regex = new Regex(@"^[0-4]+$");
                        Match match = regex.Match(txtEntrada.Text);
                        if (match.Success)
                        {
                            MessageBox.Show($"Base  2: {Convert.ToString(Convert.ToUInt32(ConvBase5.ConvForAll(txtEntrada.Text), 10), 2)}" +
                                        $"\nBase  8: {Convert.ToString(Convert.ToUInt32(ConvBase5.ConvForAll(txtEntrada.Text), 10), 8)}" +
                                        $"\nBase 10: {ConvBase5.ConvForAll(txtEntrada.Text)}" +
                                        $"\nBase 16: {Convert.ToUInt32(ConvBase5.ConvForAll(txtEntrada.Text), 10).ToString("X")}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Use apenas os números de 0 a 4!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Use apenas os números de 0 a 4!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 8:
                    try
                    {
                        MessageBox.Show($"Base  2: {Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 8), 2)}" +
                                        $"\nBase  5: {ConvBase5.ConvTo5(Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 10)))}" +
                                        $"\nBase 10: {Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 8), 10)}" +
                                        $"\nBase 16: {Convert.ToUInt32(txtEntrada.Text, 8).ToString("X")}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Use apenas os números de 0 a 7!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    break;
                case 10:
                    try
                    {
                        MessageBox.Show($"Base  2: {Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 10), 2)}" +
                                        $"\nBase  5: {ConvBase5.ConvTo5(Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 10)))}" +
                                        $"\nBase  8: {Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 10), 8)}" +
                                        $"\nBase 16: {Convert.ToUInt32(txtEntrada.Text, 10).ToString("X")}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Use apenas os números de 0 a 9!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 16:
                    try
                    {
                        MessageBox.Show($"Base  2: {Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 16), 2)}" +
                                        $"\nBase  5: {ConvBase5.ConvTo5(Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 16)))}" +
                                        $"\nBase  8: {Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 16), 8)}" +
                                        $"\nBase 10: {Convert.ToString(Convert.ToUInt32(txtEntrada.Text, 16), 10)}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Use apenas os números de 0 a 9 e as letras de A a F!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    MessageBox.Show("Base Inválida!\nEscolha apenas as bases [2 - 5 - 8 - 10 - 16]", "Base Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }    
    }
}


