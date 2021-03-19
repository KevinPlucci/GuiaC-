using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            // Variables
            float valorHora, anosAntiguedad,
                horasPorMes, totalHotas,
                totalAntiguedad, totalBruto,
                totalDescuento, totalNeto;
            string nombreEmpleado;

            // Mensajes
            Console.Title = "Ejercicio 08";
            Console.WriteLine("Cálculo de sueldo\n" +
                              "-----------------");

            // Ingreso de datos
            Console.Write("Ingrese el valor de la hora del empleado: ");
            valorHora = float.Parse(Console.ReadLine());
            Console.Write("Ingrese nombre del empleado: ");
            nombreEmpleado = Console.ReadLine();
            Console.Write("Ingrese antiguedad: ");
            anosAntiguedad = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de horas trabajadas en el mes: ");
            horasPorMes = float.Parse(Console.ReadLine());

            // Calculo
            totalHotas = valorHora * horasPorMes;
            totalAntiguedad = anosAntiguedad * 30;
            totalBruto = totalHotas + totalAntiguedad;
            totalDescuento = (float)(totalBruto * 1.13) - totalBruto;
            totalNeto = totalBruto - totalDescuento;

            //Mostrar en pantalla
            Console.Clear();
            Console.WriteLine("   Recibo de sueldo:" + "\n" +
                            "   -----------------" + "\n" +
                            "             Nombre: " + nombreEmpleado + "\n" +
                            "         Antiguedad: " + anosAntiguedad + "\n" +
                            "     Valor por hora: " + valorHora + "\n" +
                            " Total sueldo bruto: " + totalBruto + "\n" +
                            "         Descuentos: " + totalDescuento + "\n" +
                            "Valor neto a cobrar: " + totalNeto + "\n");
            Console.ReadLine();
        }
    }
}
