using System;

namespace Exercicio04
{
    class ControleRemoto
    {
        int potenciaVol, canal;

        public int AumentarVol()
        {
            if (potenciaVol < 100)
            {
               return potenciaVol++;
            } else
            {
                return potenciaVol;
            }
        }

        public int DiminuirVol()
        {
            if (potenciaVol > 0)
            {
               return potenciaVol--;
            } else
            {
                return potenciaVol;
            }
        }
    }
}