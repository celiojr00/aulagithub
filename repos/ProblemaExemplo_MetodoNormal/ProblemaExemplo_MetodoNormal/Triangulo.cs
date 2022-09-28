using System;  /*IMPORTAÇÃO DE DEPENDENCIA*/

namespace ProblemaExemplo_MetodoNormal    /*NAMESPACE DA CLASSE*/
{
    class Triangulo     /*NOME DA CLASSE*/
    {
        public double A;    /*O PREFIXO "PUBLIC" INDICA QUE P ATIBUTO/MÉTODO PODE SER USADO EM OUTROS ARQUIVOS*/
        public double B;    /* ATRIBUTOS DA CLASSE*/
        public double C;

        public double Area() /* O "DOUBLE" REFERE SE AO TIPO DO DADO QUE O MÉTODO RETORNA
                                     (SE O METODO NÃO RETORNA NADA, USA-SE A PALAVRA VOID)  */
                             /* A "AREA" É O NOME DO MÉTODO E AS "()" A LISTA DOS PARAMETROS DO MÉTODO */
        {
            double p = (A + B + C) / 2.0;                           
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));    /*CORPO DO MÉTODO*/
        }
    }
}
