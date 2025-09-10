using System.Collections.Generic;
using System.Linq;

namespace Estacionamento
{
    public class Estacionamento
    {
        private List<Veiculos.Veiculo> _veiculos = new List<Veiculos.Veiculo>();

        public void AdicionarVeiculo(Veiculos.Veiculo veiculo)
        {
            veiculo.HoraEntrada = DateTime.Now;
            _veiculos.Add(veiculo);
        }

        public void RemoverVeiculo(string placa)
        {
            var veiculo = _veiculos.FirstOrDefault(v => v.Placa == placa);
            if (veiculo == null)
            {
                Console.WriteLine($"Veículo com placa {placa} não encontrado.");
                return;
            }

            veiculo.RegistrarSaida();
            _veiculos.Remove(veiculo);
            Console.WriteLine($"Veículo com placa {placa} foi removido. Valor cobrado: R${veiculo.CalcularValor()}");
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Veículos no estacionamento:");
            foreach (var veiculo in _veiculos)
            {
                Console.WriteLine(veiculo.ToString());
            }
        }
    }
}
