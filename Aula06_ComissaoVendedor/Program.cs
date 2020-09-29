using System;
using System.Xml;

using System.Globalization;

namespace Aula06_ComissaoVendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

            /***
             * Um vendendor trabalha com frios. Para cada produto há uma aliquota de comissão,
             * conforme a especificação abaixo:
             * Mussarela:     5.0%   Preço kg: 22,60
             * Mortadela:     6.5%   Preço kg:  8,98
             * Presunto:      4.5%   Preço kg: 31,03
             * Peito de Peru: 2.5%   Preço kg: 58,90 
             * Sabendo da aliquota da comissão: faça um programa que leia as quantidades vendidas
             * pelo vendedor e calcule a comissão.
             */
            double qnt_vendida_mussarela  = 0.0; // kg
            double qnt_vendida_mortadela  = 0.0;
            double qnt_vendida_presunto   = 0.0;
            double qnt_vendida_peito_peru = 0.0;


            double valor_vendido_mussarela  = 0.0; // R$
            double valor_vendido_mortadela  = 0.0;
            double valor_vendido_presunto   = 0.0;
            double valor_vendido_peito_peru = 0.0;

            double comissao_mussarela = 0.0; // R$
            double comissao_mortadela = 0.0;
            double comissao_presunto = 0.0;
            double comissao_peito_peru = 0.0;


            Console.WriteLine("Qual a quantidade de mussarela vendida em kilos:");
            qnt_vendida_mussarela = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a quantidade de mortadela vendida em kilos:");
            qnt_vendida_mortadela = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a quantidade de presunto vendida em kilos:");
            qnt_vendida_presunto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a quantidade de peito de peru vendida em kilos:");
            qnt_vendida_peito_peru = Convert.ToDouble(Console.ReadLine());

            /**
             * Calculando os valores vendidos.
             */ 
            valor_vendido_mussarela = qnt_vendida_mussarela * 22.6;
            valor_vendido_mortadela = qnt_vendida_mortadela * 8.98;
            valor_vendido_presunto = qnt_vendida_presunto * 31.03;
            valor_vendido_peito_peru = qnt_vendida_peito_peru * 58.90;


            /**
             * Calculando a comissão
             */
            comissao_mussarela = valor_vendido_mussarela * 0.05;
            comissao_mortadela = valor_vendido_mortadela * 0.065;
            comissao_presunto = valor_vendido_presunto * 0.045;
            comissao_peito_peru = valor_vendido_peito_peru * 0.025;

            double total_comissao = comissao_mussarela + comissao_mortadela + comissao_presunto + comissao_peito_peru;


            /**
             * Apresentando resultados
             */
            Console.WriteLine("Você vendeu {0} de MUSSARELA e terá comissão de {1}", valor_vendido_mussarela.ToString("C", nfi), comissao_mussarela.ToString("C", nfi));
            Console.WriteLine("Você vendeu {0} de MORTADELA e terá comissão de {1}", valor_vendido_mortadela.ToString("C", nfi), comissao_mortadela.ToString("C", nfi));
            Console.WriteLine("Você vendeu {0} de PRESUNTO e terá comissão de {1}", valor_vendido_presunto.ToString("C", nfi), comissao_presunto.ToString("C", nfi));
            Console.WriteLine("Você vendeu {0} de PEITO DE PERU e terá comissão de {1}", valor_vendido_peito_peru.ToString("C", nfi), comissao_peito_peru.ToString("C", nfi));

            Console.WriteLine( "Você receberá {0} de comissão.", total_comissao.ToString("C", nfi) );
        }
    }
}
