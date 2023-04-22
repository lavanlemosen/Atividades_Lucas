using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    public class Funcoes
    {
   
        public void Confere_numeros(KeyPressEventArgs e,TextBox Texto)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',') ? true : (e.KeyChar == ',' && (Texto.Text.Contains(",")) ? true : false);
        }
        public void Confere_letras( KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar!=32) ? true : false;
        }
        public void Confere_numerosinteiros(KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) ? true : false;
        }

       public void Sair_Vazio(TextBox Texto,String frase)
        {
            if (Texto.Text == "")
            {
                Texto.Text = frase;
            }
        }

        public void Entrar_Algo(TextBox Texto, String frase)
        {
            if (Texto.Text == frase)
            {
                Texto.Clear();
            }
        }
    }
  
}
