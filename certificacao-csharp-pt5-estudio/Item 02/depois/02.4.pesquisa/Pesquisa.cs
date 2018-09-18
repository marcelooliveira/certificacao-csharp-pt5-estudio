using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _02._4.pesquisa
{
    internal class Pesquisa
    {
        private readonly TextBox txtPesquisa;
        private readonly List<string> parametros;
        private int indiceDe;

        public Pesquisa(TextBox txtPesquisa, List<string> parametros)
        {
            this.txtPesquisa = txtPesquisa;
            this.parametros = parametros;
        }

        internal string ExecutarComando(string tipoComando)
        {
            if (parametros
                .Where(p => string.IsNullOrWhiteSpace(p))
                .Any())
                return "Os parâmetros precisam ser preenchidos";

            switch (tipoComando)
            {
                case "Contem":
                    return Contem();
                case "ComecaCom":
                    return ComecaCom();
                case "TerminaCom":
                    return TerminaCom();
                case "IndiceDe":
                    return IndiceDe();
                case "UltimoIndiceDe":
                    return UltimoIndiceDe();
                case "Trecho":
                    return Trecho();
                case "Substituir":
                    return Substituir();
                default:
                    return string.Empty;
            }
        }

        private string Contem()
        {
            var textoBusca = parametros.FirstOrDefault();

            var contem = txtPesquisa.Text.Contains(textoBusca);

            if (contem)
            {
                return "A caixa de texto CONTÉM a string '" + textoBusca + "'";
            }
            else
            {
                return "A caixa de texto NÃO CONTÉM a string '" + textoBusca + "'";
            }
        }

        private string ComecaCom()
        {
            var textoBusca = parametros.FirstOrDefault();

            var comecaCom = txtPesquisa.Text.StartsWith(textoBusca);

            if (comecaCom)
            {
                return "A caixa de texto COMEÇA COM a string '" + textoBusca + "'";
            }
            else
            {
                return "A caixa de texto NÃO COMEÇA COM a string '" + textoBusca + "'";
            }
        }

        private string TerminaCom()
        {
            var textoBusca = parametros.FirstOrDefault();

            var comecaCom = txtPesquisa.Text.EndsWith(textoBusca);

            if (comecaCom)
            {
                return "A caixa de texto TERMINA COM a string '" + textoBusca + "'";
            }
            else
            {
                return "A caixa de texto NÃO TERMINA COM a string '" + textoBusca + "'";
            }
        }

        private string IndiceDe()
        {
            var textoBusca = parametros.FirstOrDefault();

            indiceDe = txtPesquisa.Text.IndexOf(textoBusca, indiceDe);

            if (indiceDe == -1)
            {
                return "String não encontrada: '" + textoBusca + "'";
            }
            else
            {
                return "Índice da string '" + textoBusca + "' é: " + indiceDe;
            }
        }

        private string UltimoIndiceDe()
        {
            var textoBusca = parametros.FirstOrDefault();

            indiceDe = txtPesquisa.Text.LastIndexOf(textoBusca);

            if (indiceDe == -1)
            {
                return "String não encontrada: '" + textoBusca + "'";
            }
            else
            {
                return "Último índice da string '" + textoBusca + "' é: " + indiceDe;
            }
        }

        private string Trecho()
        {
            int.TryParse(parametros[0], out int indiceInicial);
            int.TryParse(parametros[1], out int comprimento);

            txtPesquisa.SelectionStart = indiceInicial;
            txtPesquisa.SelectionLength = comprimento;
            txtPesquisa.Focus();

            string trecho = txtPesquisa.Text.Substring(indiceInicial, comprimento);

            return "O trecho selecionado é: " + trecho;
        }

        private string Substituir()
        {
            var antigoTexto = parametros[0];
            var novoTexto = parametros[1];

            txtPesquisa.Text =
                txtPesquisa.Text.Replace(antigoTexto, novoTexto);

            return "Trecho substituído com sucesso.";
        }
    }
}