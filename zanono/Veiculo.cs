using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zanono
{
    public class Veiculo
    {
        // declaração de atributos
        string marca;
        string modelo;
        string placa;
        int ano;
        // método para atributos valores
        public void atribuir(string ma,
            string mo, string pl, int a)
        {
            this.ano = a;
            this.marca = ma;
            this.modelo = mo;
            this.placa = pl;
        }
        public string retorna()
        {
            return "Modelo=" + this.marca +
                 "\nModelo=" + this.modelo +
                 "\nAno de fabricação=" + this.ano
                 + "\nPlaca=" + this.placa;
        } 
    }
}
