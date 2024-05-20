
using Desafio_de_Projeto_2.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Figueiredo");
Pessoa p2 = new Pessoa(nome: "Marcela", sobrenome: "Araújo");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 8);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de Hospedes: {reserva.ObterQuantidadeDeHospedes()}");
Console.WriteLine($"Valor por pessoa: {reserva.CalcularValorDiaria()}");
Console.WriteLine($"Valor Total: {reserva.CalcularValorTotal()}");
