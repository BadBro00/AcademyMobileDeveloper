using System;

public class Giorno6{
    public static void Main(){
        //Creazione dell'oggetto tramite costruttore
        Progetto p = new Progetto("Progetto1", "Descrizione1", new string[]{"Tag1", "Tag2"});
        //Print tramite WriteLine
        System.Console.WriteLine(p);
    }
}
//Record : immutabile, Readonly
record Progetto(string Nome, string Descrizione, string[] Tags){
    //Override del ToString per stampare l'oggetto formattato
    public override string ToString() => $"Nome: {Nome}, Descrizione: {Descrizione}, Tags: {string.Join(", ", Tags)}";
}
