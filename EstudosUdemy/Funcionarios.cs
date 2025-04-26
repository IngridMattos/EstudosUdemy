using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosUdemy {
    class Funcionarios {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
            double aumento = SalarioBruto * (porcentagem / 100);
            SalarioBruto += aumento;
        }

        public override string ToString() {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
