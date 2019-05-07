using System;
using System.Collections.Generic;
using System.Text;





namespace ScrapFII
{
    public class FII
    {
        string _razaoSocial;
        string _fundo;
        string _segmento;
        string _codigo;


        public FII(string rzoSocial, string fundo, string segmento, string codigo)
        {
            _razaoSocial = rzoSocial;
            _fundo = fundo;
            _segmento = segmento;
            _codigo = codigo;
        }

        private string RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }
        private string Fundo { get => _fundo; set => _fundo = value; }
        private string Segmento { get => _segmento; set => _segmento = value; }
        private string Codigo { get => _codigo; set => _codigo = value; }
    }
}
