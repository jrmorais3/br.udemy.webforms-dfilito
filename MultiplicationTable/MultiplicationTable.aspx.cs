using System;
using System.Web.UI.WebControls;

namespace MultiplicationTable
{
    public partial class MultiplicationTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Lista com os números disponíveis para a tabuada
            // IsPostBack método de verificação se é uma página nova ou apenas atualizada. Previne a duplicação de informações no DropDownList
            if (!IsPostBack)
            {
                for (int i = 1; i < 11; i++)
                {
                    dLista.Items.Add(i.ToString());
                }
            }

        }
        protected void btExecutar_Click(object sender, EventArgs e)
        {
            // limpa a ListBox para receber novos números
            lbDados.Items.Clear();

            // armazena o número selecionado na DropDownList
            ListItem li = dLista.SelectedItem;
            // converte essa string para Int32
            var n = Convert.ToInt32(li.Value);

            // faz a adição dos itens e retorna na tela
            for (int i = 1; i < 11; i++)
            {
                lbDados.Items.Add($"{i.ToString()} x {n.ToString()} = {i*n}");
            }
        }

        protected void dLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}