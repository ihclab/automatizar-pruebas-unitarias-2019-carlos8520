﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizarPruebasUnitarias {
    
    class Medias {

        /**
         * Calcula y regresa la media artimética
         */
        public static double mediaAritmetica(params int[] vals) { 
            double suma = 0;
                foreach(int param in vals) {
                    suma+=param;
                }
                return suma/vals.Length();
            //(Virgen Óscar, 2019, p.72)
            // ora si
        }     

        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n) { 
            double raiz = 0;
            raiz = Math.Pow(x,(1/n));
            return raiz;
        }

        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals) { 
            double sum = 0;
                foreach(int i in vals) {
                    sum+=i;
                }
            return raizEnesima(suma, vals.Length());
        }

        /**
         * Este método no está implementado
         */
        public static double mediaArmonica(params int[] vals) { 
            
        }
    }
}