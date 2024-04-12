using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1); hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");












// tentativa de implementar um MENU


// List<Pessoa> hospedes = new List<Pessoa>();

// Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Reserva reserva= new Reserva(diasReservados: 5);
// reserva.CadastrarSuite(suite);

// while (true) {
//     Console.Clear();
//     Console.WriteLine("\t\tMENU\t\t\t");
//     Console.WriteLine("1.\tCadastrar Hospede\t\t");
//     Console.WriteLine("2.\tCalcular valor da diária\t\t ");
//     Console.WriteLine("3.\tSair");

//     string opcao = Console.ReadLine();

//     switch (opcao) {
//         case "1":
//         Console.WriteLine("Digite o nome do hospede"); 
//         string nomeHospede = Console.ReadLine();
//         Pessoa novoHospede = new Pessoa(nome : nomeHospede);
//         hospedes.Add(novoHospede); 

//         break;

//         case "2":
//         Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
//         Console.ReadKey();
//         break;
//     }
// }