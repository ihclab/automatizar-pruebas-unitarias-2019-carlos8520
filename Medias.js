/**
 * Calcula y regresa la media artimética
 */
function mediaAritmetica(vals) {
    let suma = 0;
    vals.forEach(vals => {
        suma+=vals;
    });
    return suma;
    // (Virgen Óscar, 2019, p.72)    
}
   

/**
 * Calcula y regresa la raíz enésima = x^(1/n)
 */

function raizEnesima(x,n) {
    return x**(1/n);
    // (Virgen Oscar, 2019, p.74)
}

/**
 *  Usa raizEnesima para calcular y regresar la media geométrica
 */
//public double mediaGeometrica(params int[] vals) { }

/**
 * Este método no está implementado
 */
//public static double mediaArmonica(params int[] vals) {}

mediaAritmetica(2,5,8);