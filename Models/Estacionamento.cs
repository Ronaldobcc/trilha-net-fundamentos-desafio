namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"

            Console.WriteLine("Digite a placa do veículo para estacionar:");

             string placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa))
            {
               veiculos.Add(placa.ToUpper()); // Armazena a placa em letras maiúsculas
               Console.WriteLine($"Veículo com placa {placa.ToUpper()} adicionado com sucesso.");
            }
            else
            {
               Console.WriteLine("Placa inválida. Tente novamente.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string inputHoras = Console.ReadLine();
                int horas;
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                     
                if (int.TryParse(inputHoras, out horas) && horas > 0)
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);
                    // TODO: Remover a placa digitada da lista de veículos
                    veiculos.Remove(veiculos.First(x => x.ToUpper() == placa.ToUpper()));
                    Console.WriteLine($"O veículo {placa.ToUpper()} foi removido. Valor total a pagar: R$ {valorTotal:F2}");
                }
                else
                {
                    Console.WriteLine("Quantidade de horas inválida.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
    
        }

        public void ListarVeiculos()
        {
           
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                int contador = 1;
                foreach (string placa in veiculos)
                {
                Console.WriteLine($"{contador++}. {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
