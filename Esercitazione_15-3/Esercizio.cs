/*
----------------------------------------|ESERCIZIO|----------------------------
-------------------|Macchinetta del Caffè|-------------------
Si vuole realizzare un software testuale per la gestione di un distributore di bevande.
Il distributore prevede la scelta fra 3 possibili tipi:
    1. Caffè : costo 0.50€
    2. Decaffeinato : costo 0.50€
    3. Ginseng : costo 0.60€
Per le opzioni 1 e 2, sarà poi disponibile l'opzione per lo zucchero (0-4).
Una volta scelta l'opzione, sarà chiesto all'utente di inserire il relativo costo. Dovrà essere mostrato all'utente il messaggio "Inserisci Moneta",
    finchè non viene raggiunto il prezzo esatto.
Quando il credito sarà uguale, o maggiore, al costo della bevanda, la stessa sarà erogata tramite output.
In presenza del resto, sarà mostrato all'utente il messaggio "Questo è il tuo resto", con indicazione dell'ammontare.
Alla fine del processo, il distributore chiede all'utente se vuole acquistare un'altra bevanda, in tal caso espone il menù di scelta, altrimenti termina.
E' Inoltre necessario gestire le quantità di zucchero e prodotto. Ogni prodotto avrà una quantità che dovrà essere controllata prima di ogni erogazione, e diminuita ad ogni acquisto.
Le quantità saranno gestite dal gestore, ed inizialmente avranno tutte valore 10.
Ad inizio programma, inoltre, sarà mostrata un'interfaccia in cui viene chiesto se si è (1) Cliente o (2) Gestore.
In caso di (1), prosegue il normale flusso di navigazione.
In caso di (2), si aprirà un menù con le seguenti scelte:
    a. Preleva Monete
    b. Aggiorna Quantità
La funzione a. preleva tutte le monete all'interno della macchinetta, azzerando quindi il totale incassato (si prevede quindi che ad ogni vendita il distributore tenga conto del ricavo),
    mentre la funzione b. permette di aggiornare le quantità di zucchero e prodotto.
*/
using System;

public class Esercitazione{
    public static void Main(){
        Console.WriteLine("\t\t[Benvenuto al distributore più figo del mondo]");
        Distributore d = new Distributore();
        d.Menu();
    }
}

public class Distributore{
    //Variabili private, "interne" al distributore
    private string pw = "69420"; //PW per accedere in modalità Gestore
    private double ricavi,guadagni,credito; //Variabili per tenere traccia dei soldi
    private string[] prodotti = {"Caffè","Decaffeinato","Ginseng"}; //Tipi di prodotti
    private double[] monete = {0.10,0.20,0.50,1.00}; //Tipi di monete accettati
    private int[] quantita = new int[4]; //Quantità di prodotti e zucchero
    private double[] prezzi = {0.50,0.50,0.60}; //Prezzi dei tre prodotti
    //Costruttore per inizializzare le variabili
    public Distributore(){
        credito = ricavi = guadagni = 0;
        for(int i=0;i<3;i++){
            quantita[i] = 2;
        }
        quantita[3] = 40;
    }
    //Function per prelevare le monete, stampando quanto si è guadagnato
    public void PrelevaMonete(){
        guadagni+=ricavi+credito;
        ricavi = credito = 0;
        Console.WriteLine("Hai guadagnato "+guadagni);
    }
    //Function per aggiornare le quantità di un prodotto (zucchero/caffè/...)
    public void AggiornaQuantita(int idx, int qt){
        quantita[idx] = qt;
    }
    public void StampaQt(){
        Console.WriteLine("Quantità di prodotti disponibili:");
        for(int i=0;i<3;i++){
            Console.WriteLine("|Quantità di "+prodotti[i]+": "+quantita[i]+"|");
        }
        Console.WriteLine("|Quantità di zucchero: "+quantita[3]+"|");
    }
    //Function per erogare una bevanda
    public void ErogaBevanda(int idx, int zucchero){
        //Se ho scelto una quantità di zucchero maggiore di quella disponibile, la aggiorno
        if(quantita[3]<zucchero){
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Non c'è abbastanza zucchero\nInserisco: "+(quantita[3]));
            Console.WriteLine("-----------------------------------");
            zucchero=quantita[3];
        }
        quantita[3]-=zucchero;
        //Finchè non ho abbastanza soldi, chiedo all'utente di inserirne, dandogli le opzioni accettate dal distributore
        while(credito<prezzi[idx]){
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Costo : {prezzi[idx]}\nCredito: {credito}");
            Console.WriteLine("Inserisci Moneta\n1)10c\n2)20c\n3)50c\n4)1EUR");
            Console.WriteLine("------------------------------");
            int indice =Convert.ToInt32(Console.ReadLine());
            if(indice>0 && indice<5)
                credito += monete[indice-1];
            else{
                Console.WriteLine("Moneta non accettata");
            }
        }
        //Erogo effettivamente la bevanda
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("Bevanda erogata,ritirarla...");
        Console.WriteLine("------------------------------\n");
        //Se ho abbastanza soldi, erogo la bevanda
        quantita[idx]--;
        //Gestione del resto
        if(credito>prezzi[idx]){
            double resto = credito-prezzi[idx];
            Console.WriteLine("Questo è il tuo resto: "+(credito-prezzi[idx]));
            credito-=resto;
        }
        //"Salvo" le monete all'interno della macchinetta
        ricavi = credito;
        credito = 0;
    }
    //Function per il menu iniziale
    public void Menu(){
        Console.WriteLine("----------------------");
        Console.WriteLine("1)Cliente\n2)Gestore");
        Console.WriteLine("----------------------");
        int scelta1 = Convert.ToInt32(Console.ReadLine());
        if(scelta1==1){
            MenuCliente();
        }else if(scelta1==2){
            Console.WriteLine("----------------------");
            Console.WriteLine("Inserisci la password");
            Console.WriteLine("----------------------");
            string pass = Console.ReadLine();
            if(pass==pw){
                MenuGestore();
            }else{
                Console.WriteLine("[Password errata]");
            }
        }
    }
    public bool Ordinabile(int idx){
        return quantita[idx]>0;
    }
    public void MenuCliente(){
        scegli:
        StampaQt(); //Stampo le quantità ogni volta, per emulare lo schermo del distributore, mostrando quanti prodotti sono disponibili
                    //  e in che quantità
        Console.WriteLine("------------------------------");
        Console.WriteLine("1)Caffè [50cent]\n2)Decaffeinato [50cent]\n3)Ginseng [60cent]");
        Console.WriteLine("------------------------------");
        int scelta2;
        try{
            scelta2 = Convert.ToInt32(Console.ReadLine());
        }catch(FormatException){
            Console.WriteLine("\t\t|Inserire un formato valido|\n");
            goto scegli;
        }
        //Controllo se il prodotto scelto è disponibile (>0)
        if(Ordinabile(scelta2-1)){
            //Se scelgo caffè o decaffeinato, chiedo se voglio zucchero
            if(scelta2==1 || scelta2==2){
                Console.WriteLine("-------------------------");
                Console.WriteLine("Quanto zucchero vuoi?\n0-1-2-3-4");
                Console.WriteLine("-------------------------");
                int zucchero;
                try{
                    zucchero = Convert.ToInt32(Console.ReadLine());
                }catch(FormatException){
                    Console.WriteLine("\t\t|Inserire un formato valido|\n");
                    goto scegli;
                }
                ErogaBevanda(scelta2-1,zucchero); //Passo al modulo "ErogaBevanda", che vale per tutti i prodotti (riutilizzo del codice)
            }else if(scelta2==3){
                //Se scelgo il ginseng, erogo ma senza zucchero
                ErogaBevanda(scelta2-1,0);
            }else{
                //Se inserisco una scelta non valida, gestisco il caso facendo riscegliere l'utente
                Console.WriteLine("------------------------------");
                Console.WriteLine("Scelta non valida, reinserirne una");
                Console.WriteLine("------------------------------");
                goto scegli;
            }
            //Se il prodotto è terminato, devo far scegliere un altro all'utente
        }else if(!Ordinabile(scelta2-1)){
            Console.WriteLine("------------------------------");
            Console.WriteLine("Prodotto terminato, sceglierne un altro");
            Console.WriteLine("------------------------------");
            goto scegli;
        }else if(scelta2<1 || scelta2>3){
            //Se la scelta del prodotto non è valida, l'utente deve ripeterla
            Console.WriteLine("------------------------------");
            Console.WriteLine("Scelta non valida, reinserirne una");
            Console.WriteLine("------------------------------");
            goto scegli;
        }
        //Chiedo all'utente se vuole comprare un'altra bevanda
        Console.WriteLine("------------------------------");
        Console.WriteLine("Vuoi acquistare un'altra bevanda?\n1)Sì\n2)No");
        Console.WriteLine("------------------------------");
        int scelta3 = Convert.ToInt32(Console.ReadLine());
        if(scelta3==1){
            MenuCliente();//Ritorno al menu cliente, per far scegliere nuovamente il prodotto
        }else{
            //Altrimenti esco dal programma
            return;
        }
    }
    //Function per gestire le attività che il gestore del distributore potrebbe fare
    public void MenuGestore(){
        menug:
        int idx;
        Console.WriteLine("------------------------------");
        Console.WriteLine("a)Preleva Monete\nb)Aggiorna Quantità\ne)Esci");
        Console.WriteLine("------------------------------");
        char scelta;
        try{
            scelta = Convert.ToChar(Console.ReadLine());
        }catch(FormatException){
            Console.WriteLine("\t\t|Inserire un formato valido|\n");
            goto menug;
        }
        switch(scelta){
            case 'a':
                PrelevaMonete();
                break;
            case 'b':
            agg:
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Quale prodotto vuoi aggiornare?\n1)Caffè\n2)Decaffeinato\n3)Ginseng\n4)Zucchero");
                Console.WriteLine("--------------------------------------");
                try{
                    idx = Convert.ToInt32(Console.ReadLine());
                }catch(FormatException){
                    Console.WriteLine("\t\t|Inserire un formato valido|\n");
                    goto agg;
                }
                quant:
                Console.WriteLine("------------------------------");
                Console.WriteLine("Inserisci la nuova quantità:");
                Console.WriteLine("------------------------------");
                int qt;
                try{
                    qt = Convert.ToInt32(Console.ReadLine());
                }catch(FormatException){
                    Console.WriteLine("\t\t|Inserire un formato valido|\n");
                    goto quant;
                }
                AggiornaQuantita(idx-1,qt);
                break;
            default:
                Console.WriteLine("------------------------------");
                Console.WriteLine("Scelta non valida, reinserirne una");
                Console.WriteLine("------------------------------");
                goto menug;
                break;
        }
    }
}
