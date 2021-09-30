using System;

namespace GOB.App.Dominio
{
    public class GobernadorAsesores : Persona
    {
        public int    id{get;set;}
        public System.Collections.Generic.List<Sedes>    sedesVisitadas{get;set;}
        public System.Collections.Generic.List<Oficina>  oficinasVisitadas{get;set;}
    }
}