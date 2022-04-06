using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPBolillero.core
{
    public class Aleatorio
    {
        Random aleatorio = new Random();

            for (int i = 0; i < 9; i++)
            {
                numeros.Add(aleatorio.Next(100));
            }  


