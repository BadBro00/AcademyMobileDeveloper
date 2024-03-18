using System;

public class Giorno6_ES2{
    public static void Main(){
        //Creo un oggetto Veicolo
        Veicolo2 v = new Veicolo2("Veicolo");
        Console.WriteLine("[MostraDettagli Veicolo] ");
        v.MostraDettagli();
        //Creo un oggetto Auto
        Auto2 a = new Auto2("Automobile ");
        Console.WriteLine("\t[MostraDettagli Auto] ");
        a.MostraDettagli();
    }
}

public class Veicolo2{
    private string nome;
    public Veicolo2(string nome){
        this.nome = nome;
    }
    public virtual void MostraDettagli(){
        Console.Write($"Nome Veicolo: {nome}");
    }
}

public class Auto2 : Veicolo2{
    public Auto2(string nome) : base(nome){}
    public override void MostraDettagli(){
        base.MostraDettagli();
        Console.Write("[Tipo: Auto]");
    }
}