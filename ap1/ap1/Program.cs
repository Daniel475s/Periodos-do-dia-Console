using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Apresentacao();
            string periodo = PegaValorDoUsuario();

            Validacao(periodo);

            Console.ReadLine();
        }

        public static void Apresentacao()
        {
            Console.WriteLine("Olá! Manhã = M, Tarde = T, Noite = N, Almoço = A Selecione em qual período do dia estamos no momento: ");
        }

        public static string PegaValorDoUsuario()
        {
            string valorInseridoPeloUsuario = Console.ReadLine();

            return valorInseridoPeloUsuario;
        }

        public static void Validacao(string p_periodo)
        {
            Mensagem msg = new Mensagem();


            if (p_periodo == "M")
            {
                msg.MensagemBomDia();
            }
            else if (p_periodo == "T")
            {
                msg.MensagemBoaTarde();
            }
            else if (p_periodo == "N")
            {
                msg.MensagemBoaNoite();
            }
            else if (p_periodo == "A")
            {
                msg.MensagemAlmoco();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Período não informado corretamente.");
            }

        }

    }



}

