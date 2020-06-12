namespace Construçao
{
    public class Carro
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public string cor { get; set; }

        public Carro(){

        }
         public Carro( string _marca, string _modelo ){
            this.marca = _marca;
            this.modelo = _modelo;
        }
         public Carro( string _marca, string _modelo, int _ano, string _cor ){
            this.marca = _marca;
            this.modelo = _modelo;
            this.ano = _ano;
            this.cor = _cor;
        }
    }
}