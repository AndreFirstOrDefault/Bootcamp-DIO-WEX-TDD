using System;
using System.Collections.Generic;
using System.Text;

namespace New_Talents
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string _data;
        private int _resultado;

        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            _data = data;
        }

        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            AdicionarHistorico(_resultado, _data);
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            AdicionarHistorico(_resultado, _data);
            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            int resultado = val1/ val2;
            AdicionarHistorico(_resultado, _data);
            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            AdicionarHistorico(_resultado, _data);
            return resultado;
        }

        public void AdicionarHistorico(int resultado, string data)
        {
            _resultado = resultado;
            _data = data;
            listahistorico.Insert(0, "Res: " + resultado + " data: " + _data);
        }

        public List<string> historico()
        {
            List<string> res;
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }


    }
}
