using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlPagamento
    {
        private short opcao;
        Pagamento pgto;
        public ControlPagamento()
        {
            pgto = new Pagamento();


        }//fim do construtor


        // get set

        public short ModificarOpcao
        {
            get { return opcao; }
            set { this.opcao = value; }
        }
        public void EscolherFormaDePagamento()
        {
            Console.WriteLine(pgto.MenuFormaDePagamento());// mostrando menu na tela
            ModificarOpcao = Convert.ToInt16(Console.ReadLine());// coletando a resposta


        }// fim do registrar pagamento

        public void Operacao()
        {
            EscolherFormaDePagamento();


            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Pagamento com Dinheiro: \n \n");
                    Console.WriteLine("Valor inserido na máquina: ");
                    double valorInserido = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\n Valor do Produto: ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());

                    // utilizar o método efetuar pagamento dinheiro

                    pgto.EfetuarPagamentoDinheiro(valorInserido, valorProduto);
                    Console.WriteLine(pgto.imprimir());

                    break;

                case 2:

                    Console.WriteLine("Pagamento com Cartão: \n \n");
                    Console.WriteLine("\n\n Valor do Produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\n Código do Cartão: ");
                    int codCartao = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n Bandeira do Cartão:\n1. Visa\n2.Mastercard\n3.Elo");
                    short bandeiraCartao = Convert.ToInt16(Console.ReadLine());

                    // utilizar o metodo efetuar pagamento dinheiro

                    pgto.EfetuarPagamentoCartao(valorProduto, codCartao, bandeiraCartao);
                    Console.WriteLine(pgto.imprimir());

                    break;

                default:

                    Console.WriteLine("Impossível realizar a operação, tente novamente!");
                    break;


            }// fim do switch
        }// fim do operacao
    }// fim da classe
}// fim do metodo
