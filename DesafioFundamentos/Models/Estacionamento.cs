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
            // DESCOBRI O MEU ERRO
            //IMPLEMENTADO
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if(veiculos.Any(v => v.Equals(placa.ToUpper())))
                {
                    Console.WriteLine("Já existe um veículo com essa placa.");
                }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine(" Muito bem veículo estacionado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // iMPLEMENTADO
            string placa =  Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Olá meu senhor,Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //IMPLEMENTADO
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horas; 

                veiculos.Remove(placa.ToUpper());

                //IMPLEMENTADO

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                Console.WriteLine("Olá só estes veículos estacionados :");
                // IMPLEMENTADO
                foreach (var v in veiculos) //ESTE FOI O MAIS DIFICIL!
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
