using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Desafio_de_Projeto_2.Models
{
    public class Reserva
    {
        private List<Pessoa> Hospedes {get; set;}
        private Suite SuiteReserva {get; set;}
        private int DiasReservados {get; set;}
        private decimal ValorDiariaPorPessoa {get; set;}

        public Reserva(int diasReservados) {
            if (diasReservados < 0) {
                throw new ArgumentException("É necessário que o dia da reserva seja maior que 0.");
            } else {
                DiasReservados = diasReservados;
            }
        }

        public void CadastrarHospedes(List<Pessoa> hospedes) {
            if (hospedes.Count <= SuiteReserva.Capacidade && hospedes.Count > 0) {
                Hospedes = hospedes;
                Console.WriteLine("Hospedes cadastrados com sucesso");
            } else {
                string texto = SuiteReserva.Capacidade > 1 ? "pessoas" : "pessoa";
                throw new ArgumentException($"A suíte suporta no mínimo 1 pessoa e até {SuiteReserva.Capacidade} {texto}.");
            }
        }

        public void CadastrarSuite(Suite suite) {
            SuiteReserva = suite;
            Console.WriteLine("Suíte cadastrada com sucesso!");
        }

        public int ObterQuantidadeDeHospedes() {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria() {
            decimal desconto;

            if (DiasReservados >= 10) {
                desconto = 0.9M; // 10% de desconto
                decimal valorDiariaComDesconto = SuiteReserva.ValorDiaria * desconto;
                ValorDiariaPorPessoa = valorDiariaComDesconto * DiasReservados;
                return ValorDiariaPorPessoa;
            } else {
                ValorDiariaPorPessoa = SuiteReserva.ValorDiaria * DiasReservados;
                return ValorDiariaPorPessoa;
            }
        }

        public decimal CalcularValorTotal() {
            return ValorDiariaPorPessoa * Hospedes.Count;
        }
    }
}