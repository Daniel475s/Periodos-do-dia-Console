using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap1
{
    class Mensagem
    {

        #region Métodos Void
        public void MensagemBomDia()
        {
            Console.WriteLine("Bom dia!");
        }

        public void MensagemBoaTarde()
        {
            Console.WriteLine("Boa Tarde!");

        }

        public void MensagemBoaNoite()
        {
            Console.WriteLine("Boa Noite!");

        }

        public void MensagemAlmoco()
        {
            Console.WriteLine("Bom Almoço!");

        }

        #endregion

        #region Métodos Com Return

        public static string Bomdia()
        {
            string mensagem = "Bom dia";
            return mensagem;
        }

        public static string BoaTarde()
        {
            return "Boa Tarde";
        }

        public static string BoaNoite()
        {
            return "Boa Noite";
        }

        #endregion

    }
}
