using System;

namespace GOB.App.Dominio
{
    public class Persona
    {
        public int      id{get;set;}
        public string   nombre{get;set;}
        public string   apellido{get;set;}
        public int      edad{get;set;}
        public int      identificacion{get;set;}
        public EstadoSalud estadoSalud{get;set;}
    }
}