using System;
using System.Collections.ObjectModel;

namespace ConsultesPacients
{
    public class LogicClinica
    {
        public ObservableCollection<Visita> llistaVis { get; set; }

        public LogicClinica() 
        {
            llistaVis = new ObservableCollection<Visita>();
            llistaVis.Add(new Visita("John David", DateTime.Now.ToString(), "Sindrome de Estocolmo"));
            llistaVis.Add(new Visita("Manuela Jimenez", DateTime.Now.ToString(), "dump"));
            llistaVis.Add(new Visita("Alberto Fernandez", DateTime.Now.ToString(), "radiografia"));
        }

        public void AfegirVisita(Visita novaVisita)
        {
            llistaVis.Add(novaVisita);
        }

        public void ModificarVisita(int posicio, Visita instanciaVisitaJaModificada)
        {
            if(posicio >= 0 && posicio < llistaVis.Count) 
            {
                llistaVis[posicio] = instanciaVisitaJaModificada;
            }
            else
            {
                Console.WriteLine("Posición no válida para modificar la visita.");
            }
        }
    }
}
