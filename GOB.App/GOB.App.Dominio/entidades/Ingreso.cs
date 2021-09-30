using System;

namespace GOB.App.Dominio
{
    public class Ingreso
    {
        public int    id{get;set;}
        public DateTime horaIngreso{get;set;}
        public DateTime horaSalida{get;set;}
        public string   sedeIngreso{get;set;}
        public string   oficinaIngreso{get;set;}
        public EstadoIngreso estadoIngreso{get;set;}
    }
}