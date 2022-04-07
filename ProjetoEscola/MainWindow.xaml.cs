using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoEscola
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cbEstado.Items.Add("Rondônia");
            cbEstado.Items.Add("São Paulo");
            cbEstado.Items.Add("Rio de Janeiro");
            cbEstado.Items.Add("Acre Republica comunista dos dinos");

        }


        public static string pessoa;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton sexoType = (sender as RadioButton);
            pessoa = sexoType.Content.ToString();

        }
        public static int numero;
        public static string nomeFantasia, razaoSocial, cnpj, responsavel, telefone, rua, cidade, insEstadual, cep, email, telefoneResponsavel, estado;
        public static DatePicker dtPicker;

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            nomeFantasia = txtNameFantasia.Text;
            razaoSocial = txtRazaoSocial.Text;
            cnpj = txtCNPJ.Text;
            responsavel= txtResponsavel.Text;
            telefone= txtNumero.Text;
            rua = txtRua.Text;
            cidade= txtCidade.Text;
            insEstadual= txtInscEstuda.Text;
            cep = txtCep.Text;
            email = txtEmail.Text;
            numero = (Convert.ToInt32(txtNumero.Text));
            dtPicker = dtSolution;
            ShowMenssageJão();
            telefoneResponsavel = txtTelfone.Text;
            estado = cbEstado.Text;
        }

        private void ShowMenssageJão()
        {
            MessageBox.Show("nome fantasia= "+ nomeFantasia + Environment.NewLine+"razão social= " + razaoSocial + Environment.NewLine+"cnpj= " + 
                            cnpj+ Environment.NewLine + "responsavel= " + responsavel + Environment.NewLine + "telefone= " + telefone + Environment.NewLine +
                            "estado= "+ estado+ Environment.NewLine +
                            " rua= " + rua + Environment.NewLine + "cidade= " + cidade + Environment.NewLine + "telefone estadual= "+ telefoneResponsavel+  
                            Environment.NewLine + "inscrição estadual= " + insEstadual + Environment.NewLine + "cep= " + cep + Environment.NewLine + 
                            "e-mail= " + email + Environment.NewLine + "numero= " + numero + Environment.NewLine + "data criação= " + dtPicker 
                            );
            
                
        }
    }
}
