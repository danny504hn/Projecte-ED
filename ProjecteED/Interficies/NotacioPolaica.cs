using System;
using System.Collections.Generic;
namespace ProjecteED
{
    public class NotacioPolaca
    {
        // Verifica si el símbol és un operador
        private static bool EsOperador(string simbol)
        {
            return simbol == "+" || simbol == "-" || simbol == "*" || simbol == "/";
        }

        // Realitza l'operació entre dos operands
        private static double RealitzarOperacio(double operand1, double operand2, string operador)
        {
            switch (operador)
            {
                case "+": return operand1 + operand2;
                case "-": return operand1 - operand2;
                case "*": return operand1 * operand2;
                case "/": return operand1 / operand2;
                default: throw new InvalidOperationException($"Operador no reconegut: {operador}");
            }
        }

        // Avalua l'expressió en notació polaca
        public static double AvaluarNotacioPolaca(string notacio)
        {
            Pila<double> pila = new Pila<double>();
            
            string[] tokens = notacio.Split(' ');

            foreach (var token in tokens)
            {
                if (EsOperador(token)) // Si és un operador
                {
                    double operand2 = pila.Pop();
                    double operand1 = pila.Pop();
                    
                    double resultat = RealitzarOperacio(operand1, operand2, token);
                    pila.Push(resultat);
                }
                else // Si és un número
                {
                    if (double.TryParse(token, out double numero))
                    {
                        pila.Push(numero);
                    }
                    else
                    {
                        throw new InvalidOperationException($"Token no vàlid: {token}");
                    }
                }
            }
            return pila.Pop();
        }
    }
}
