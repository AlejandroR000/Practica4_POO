using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Juego : Pajaro
    {
    private string habilidad;

    public Juego(string color, string habilidad): base(color)
    {
        this.habilidad = habilidad;
    }

    public string Habilidad { get => habilidad; set => habilidad = value; }
}


