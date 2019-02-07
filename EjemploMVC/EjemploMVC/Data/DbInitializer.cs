using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjemploMVC.Models;


namespace sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize(EjemploMVCContext context)
        {
            context.Database.EnsureCreated();

            //Buscar registros en la tabla

            if (context.Persona.Any())
            {
                return;
            }

            var consultas = new Persona[]
            {
                new Persona{ nombre="Carlos Lopez",fecha="23-03-2019",hora="10:15" }
            };

            foreach (Persona c in consultas)
            {
                context.Persona.Add(c);
            }
            context.SaveChanges();
        }

    }

}
