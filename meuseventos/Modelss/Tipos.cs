using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meuseventos.Modelss
{
    public class Tipos
    {
        public Eventoo EventoSelecionado { get; set; }
        public int QntHomens { get; set; }
        public int QntMulheres { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string NomeEvento { get; set; }
        public int NumeroEvento { get; set; }
        public string LocalEvento { get; set; }
        public double CustoEvento { get; set; }

        public int Periodo
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }
        public double ValorTotal
        {
            get
            {
                double valor_homens = QntHomens * EventoSelecionado.ValorHomem;
                double valor_mulheres = QntMulheres * EventoSelecionado.ValorMulher;

                double total = (valor_homens + valor_mulheres) * Periodo;

                return total;
            }
        }

    }
}
