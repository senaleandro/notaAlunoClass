using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exeAlunoClass
{
    public class Aluno
    {
        public string A;
        public double X;
        public double Y;
        public double Z;

        public double NotaFinal()
        {
          double nota = X + Y + Z;
          return nota;
        }

        public double Resto()
        {
            double resto = (X + Y + Z) - 60.00;
            return Math.Abs(resto);
        }

    }
}