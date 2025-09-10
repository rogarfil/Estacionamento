using System;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();
            
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar Veículo");
                Console.WriteLine("2 - Remover Veículo");
                Console.WriteLine("3 - Listar Veículos");
                Console.WriteLine("4 - Sair");
                
                var opcao = Console.ReadLine();
                
                if (string.IsNullOrEmpty(opcao))
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case "1":
                        Console.Write("Placa: ");
                        string? placa = Console.ReadLine();
                        if (string.IsNullOrEmpty(placa))
                        {
                            Console.WriteLine("Placa inválida. Tente novamente.");
                            continue;
                        }

                        Console.Write("Marca: ");
                        string? marca = Console.ReadLine();
                        if (string.IsNullOrEmpty(marca))
                        {
                            Console.WriteLine("Marca inválida. Tente novamente.");
                            continue;
                        }

                        Console.Write("Modelo: ");
                        string? modelo = Console.ReadLine();
                        if (string.IsNullOrEmpty(modelo))
                        {
                            Console.WriteLine("Modelo inválido. Tente novamente.");
                            continue;
                        }

                        estacionamento.AdicionarVeiculo(new Veiculos.Veiculo(placa, marca, modelo));
                        break;
                        
                    case "2":
                        Console.Write("Placa do veículo a ser removido: ");
                        string? placaRemover = Console.ReadLine();
                        if (string.IsNullOrEmpty(placaRemover))
                        {
                            Console.WriteLine("Placa inválida. Tente novamente.");
                            continue;
                        }

                        estacionamento.RemoverVeiculo(placaRemover);
                        break;
                        
                    case "3":
                        estacionamento.ListarVeiculos();
                        break;
                        
                    case "4":
                        Console.WriteLine("Saindo do sistema...");
                        return;
                        
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
