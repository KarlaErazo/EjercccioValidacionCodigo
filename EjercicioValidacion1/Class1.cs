using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioValidacion1
{
    public class ClassProducto
    {

        public string longcodigo(string codigo)
        {
            string result;
            int longitud = codigo.Length;

            if (longitud > 10) {
                result = "ERROR";
            } else {
                result = "CORRRECTO";
            }

            return result;
        }

    }
}
