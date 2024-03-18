using System;

/*
NB:
    Avendo scritto tutti i file all'interno di un singolo progetto (per comodità e rapidità), per eseguire i vari 
    file bisogna andare nel file "Giorno6.csproj", commentare quelli che non vanno eseguiti e lasciarne uno alla
    volta "decommentato". L'esecuzione è automatica, sia con il comando "dotnet run", sia mediante l'editor normale.
    Per eseguire un file diverso, basta decommentare il file desiderato e commentare quello attualmente in esecuzione.
    Stavo cercando anche un modo per eseguirli singolarmente da riga di comando/prompt di VS, ma non sono riuscito ancora
    a trovare il comando specifico, dovrebbe andar aggiunta l'opzione /main, ma ancora non riesco a farla funzionare.
*/

//---------------------------------------------|ESERCIZI|------------------------------------------------
/*
1)
Creare una classe base chiamata "Veicolo" con una proprietà "Velocità" e un metodo "Accelerare" che incrementa la velocità del veicolo.
Creare una classe derivata chiamata "Automobile" che eredita dalla classe "Veicolo" e ha una proprietà aggiuntiva chiamata "Marca".
Creare un'istanza della classe "Automobile" e assegnare un valore alla proprietà "Marca". Successivamente, chiamare il metodo "Accelerare" per aumentare la velocità dell'automobile.
Creare una classe derivata chiamata "Motocicletta" che eredita dalla classe "Veicolo" e ha una proprietà aggiuntiva chiamata "Cilindrata".
Creare un'istanza della classe "Motocicletta" e assegnare un valore alla proprietà "Cilindrata". Successivamente, chiamare il metodo "Accelerare" per aumentare la velocità della motocicletta.
2)
Creare una classe base chiamata Veicolo con un metodo virtual MostraDettagli che restituisce una stringa con il nome del veicolo. 
Creare una classe derivata Auto che sovrascrive il metodo MostraDettagli per aggiungere il tipo di auto e inoltre richiama
il metodo MostraDettagli della classe padre.
3) Creare un'applicazione che converte una stringa in un numero intero e la divide per un altro numero fornito dall'utente.
Gestire specificamente le eccezioni di conversione e divisione per zero.
4) Creare un StringBuilder e aggiungere le seguenti parti per formare una frase completa: "Oggi", "è", "una", "bella", "giornata". Infine, stampare la frase completa sulla console.
5) Data la frase "Il C# è divertente!", utilizzare StringBuilder per sostituire "divertente" con "fantastico" e poi rimuovere "Il " dall'inizio della frase
6) Cambiare la C della frase dell'esercizio precedente in minuscolo
7) Utilizzando StringBuilder, creare la frase "C# fa divertire" e poi modificare per ottenere "C# fa molto divertire" inserendo la parola "molto ". Infine, rimuovere la parola "fa ".


Esercizio Extra)

scrivere un programma che permetta di operare con degli account bancari.
Ogni account bancario possiede un proprietario, un numero specifico e un insieme di transazioni

Ogni transazione presenta la data di emissione e delle note

L'account bancario possiede inoltre un bilancio 
che rappresenta la somma di tutte le transazionie e può visualizzarne lo storico

l'account bancario può eseguire operazioni di deposito e di ritiro (nuove transazioni)

Eseguire almeno una operazione di deposito e una di ritiro.
Verificare che somme e sottrazioni siano corrette

Infine stampare a video il bilancio corrente.
*/
public class Giorno6_ES1{
    public static void Main(){
        //Creo l'oggetto Auto
        Auto1 a = new Auto1();
        //L'auto è una fiat
        a.Marca = "Fiat Panda";
        Console.WriteLine($"L'auto è una {a.Marca},accelera di 10km/h");
        a.Accelerare(10);
        //Creo l'oggetto Motocicletta
        Motocicletta m = new Motocicletta();
        //Assegno la proprietà cilindrata
        m.Cilindrata = 125;
        Console.WriteLine($"La motocicletta ha una cilindrata di {m.Cilindrata}cc, accelera di 20km/h");
        m.Accelerare(20);
    }
}

public class Veicolo1{
    public int Velocità {get; set;}
    public void Accelerare(int incremento){
        Velocità += incremento;
    }
}
public class Auto1 : Veicolo1{
    public string Marca {get; set;}
}
public class Motocicletta : Veicolo1{
    public int Cilindrata {get; set;}
}
