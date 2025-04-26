using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosUdemy {
    class Retangulo {
        public double Altura;
        public double Largura;
        public double Area() {
            return Altura * Largura;
        }
        public double Perimetro() {
            return (Altura * 2) + (Largura * 2);
        }
        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
        public override string ToString() {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) +
                " PERÍMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) +
                " DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
