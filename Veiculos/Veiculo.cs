using System;

namespace Estacionamento.Veiculos
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; set; } // Usar DateTime? para permitir valor nulo

        public Veiculo(string placa, string marca, string modelo)
        {
            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo))
                throw new ArgumentException("Placa, Marca e Modelo são obrigatórios.");
            
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
        }

        public double CalcularValor()
        {
            if (!HoraSaida.HasValue) return 0.0;

            var duracao = HoraSaida.Value - HoraEntrada;
            var horas = Math.Ceiling(duracao.TotalHours);
            return horas * 5; // R$5 por hora
        }

        public void RegistrarSaida()
        {
            if (HoraSaida.HasValue)
                throw new InvalidOperationException("O veículo já registrou a saída.");
            
            HoraSaida = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Placa: {Placa}, Marca: {Marca}, Modelo: {Modelo}, Entrada: {HoraEntrada}, Saída: {HoraSaida?.ToString() ?? "Não registrado"}, Valor: R${CalcularValor()}";
        }
    }
}
