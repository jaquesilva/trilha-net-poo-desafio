namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // ATRIBUTOS/PROPRIEDADES
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo;
        private string Imei;
        private int Memoria;

        // CONSTRUTOR
        // public Smartphone()
        // {

        // }

        // CONSTRUTOR
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        // MÉTODO
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // MÉTODO
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // MÉTODO
        public abstract void InstalarAplicativo(string nomeApp);
    }
}