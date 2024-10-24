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
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaAutomovel = Console.ReadLine();
            string placa = placaAutomovel;

            //IMPLEMENTADO

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = 0;
                string horasEstacionado = Console.ReadLine();
                horas = Convert.ToInt32(horasEstacionado);
                decimal valorTotal = 0;
                
                //IMPLEMENTADO!!

                valorTotal = precoInicial + precoPorHora * Convert.ToDecimal(horas);
                Console.WriteLine(valorTotal);

                veiculos.Remove(placa);

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
        
            if (veiculos == null)
            {
                Console.WriteLine("Não há veiculos estacionados no momento");
                return; 
            }

            if (veiculos.Count == 0)
            {
                Console.WriteLine("Não há veiculos estacionados no momento");
                return;
            }
            Console.WriteLine("Os veículos estacionados são: ");
            foreach (string item in veiculos)
            {
                Console.WriteLine($"O veiculo estacionado é: {item}");
                
            }
            
                //IMPLEMENTADO!!
            
        
            
        }
    }
}
