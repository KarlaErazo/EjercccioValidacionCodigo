using System;
using System.Collections.Generic;
using System.Text;

namespace EjercccioValidacion
{
    public class ClaseNombre

    {
        public string longnombres(string nombre1, string nombre2, string apellidos){
        int total;
        string result;
        total = nombre1.Length + nombre2.Length + apellidos.Length;

            if (total > 50){
            result = "ERROR";
            }
            else {
             result="CORRRECTOS";

}
return result;
}
    }
}
