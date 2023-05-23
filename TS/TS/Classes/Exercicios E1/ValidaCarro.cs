

using TS.Interfaces;

namespace TS.Classes.ExerciciosE1
{
    public class ValidaCarro : IValidarCarro
    {
        private IValidarCarro validaCarro;

        public ValidaCarro()
        {
            
        }
        public ValidaCarro(IValidarCarro repositorio)
        {

        }

        public bool ValidarCarro(Carro carro)
        {
            if (carro.codigo <= 0)
            {
                Console.WriteLine("Codigo invalido");
                return false;
            }

            if (carro.modelo?.Length > 20)
            {
                Console.WriteLine("modelo invalido");
                return false;
            }

            List<string> marcasDisponiveis = new List<string>()
            {
                "VW","Ford","GM","Fiat"
            };    
            if (!marcasDisponiveis.Any(x => x == carro.marca))
            {
                Console.WriteLine("marca invalido");
                return false;
            }

            if (carro.placa?.Length !=  8)
            {
                Console.WriteLine("placa invalido");
                return false;
            }

            if (carro.anoFabricacao < 1980)
            {
                Console.WriteLine("anoFabricacao invalido");
                return false;
            }

            if (carro.nomeProprietario?.Length > 25)
            {
                Console.WriteLine("nomeProprietario invalido");
                return false;
            }
   
            if (carro.valorTotal < 1 || carro.valorTotal > 50000)
            {
                Console.WriteLine("valorTotal invalido");
                return false;
            }

            if (carro.eFinanciado)
            {
                if (carro.valorFinanciamento < 1 || carro.valorFinanciamento > carro.valorTotal)
                {
                    Console.WriteLine("valorFinanciamento invalido");
                    return false;
                } 
            }

            return true;
        }
    }
} 
	
