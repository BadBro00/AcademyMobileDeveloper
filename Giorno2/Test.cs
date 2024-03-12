ES 1:

/*
            Scrivere un programma che esegue il calcolo dell'area di un rettangolo
            leggendo la dimensione dei lati da Console. Utilizzare il tipo double
                 
Esercizio 2:
NB. Possibile utilizzo di REF (documentarsi)

Un ristorante desidera automatizzare il processo di prenotazione. 
                Hanno bisogno di un programma che legga il conteggio delle persone e del pacchetto dalla console e calcoli
                quanto il cliente dovrebbe pagare per prenotare il posto.


                    Sale diverse hanno prezzi diversi:

                    Sala piccola    Terrazza     Sala grande
          prezzo:    $  2500        $ 5000 $       7500 $
        capacità:        50           100          120

        
                    Il ristorante ha sconti a seconda del pacchetto di servizi che il gruppo desidera.

                      Puoi vedere gli sconti nella tabella sottostante:

                              Normal      Gold      Platinum
                    Sconto      5%        10%         15%
                    Prezzo      500      $ 750 $     1000 $


                    Dovresti aggiungere il prezzo del pacchetto al prezzo della sala.
                Lo sconto viene calcolato in base al prezzo della sala + il prezzo del pacchetto.


Esercizio 3

                Scrivere  un programma che conta le calorie per una ricetta della pizza.
                Nella ricetta sono presenti solamente quattro ingredienti.


                Ogni ingrediente contiene una quantità fissa di calorie:

                • ingrediente 1  - 500 calorie
                • ingrediente 2  - 300 calorie
                • ingrediente 3  -  40 calorie
                • ingrediente 4  -  50 calorie
                
                Il programma determina la quantità di ingredienti da inserire.
                Ogni ingrediente può essere inserito più di una volta:
                se accade, si dovrebbe aggiungere nuovamente le calorie all'importo totale.
                Al termine, stampa le calorie totali.


*/
public class Giorno2{
    public static void Main(){
        //Esercizio 1
        //Dichiaro le variabili
        double h,w,area;
        Console.WriteLine("Inserisci l'altezza del rettangolo: ");
        h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci la larghezza del rettangolo: ");
        w = Convert.ToDouble(Console.ReadLine());
        //Stampa dell'area
        Console.WriteLine($"L'area del rettangolo è: {h*w}");
        //Esercizio 2
        //Uso le pair per collegare costo e capienza (capacità)
        pair[] sale = new pair[3];
        //Inizializzo le coppie
        sale[0] = new pair(2500,50);
        sale[1] = new pair(5000,100);
        sale[2] = new pair(7500,120);
        //Array di pacchetti
        pair[] pacchetti = new pair[3];
        pacchetti[0] = new pair(500,5);
        pacchetti[1] = new pair(750,10);
        pacchetti[2] = new pair(1000,15);
        int s,p;
        //Selezione da parte dell'utente
        Console.WriteLine("Inserisci la sala desiderata (0: piccola, 1: terrazza, 2: grande): ");
        s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il pacchetto desiderato (0: normale, 1: gold, 2: platinum): ");
        p = Convert.ToInt32(Console.ReadLine());
        //Stampa del prezzo totale
        Console.WriteLine($"Il prezzo totale è: {sale[s].first+pacchetti[p].first-(sale[s].first+pacchetti[p].first*0.01*pacchetti[p].second)}");
        //Esercizio 3
        //Array di calorie in base ai vari ingredienti
        int[] calorie = new int[4];
        calorie[0] = 500;
        calorie[1] = 300;
        calorie[2] = 40;
        calorie[3] = 50;
        //Array di quantità per gestire gli ingredienti
        int[] quantita = new int[4];
        int tot = 0;
        //Ciclo for per iterare su ciascun ingrediente, e quindi anche le capacità
        for(int i=0;i<4;i++){
            Console.WriteLine($"Inserisci la quantità di ingrediente {i+1}: ");
            quantita[i] = Convert.ToInt32(Console.ReadLine());
            //Aumento le calorie totali in base alle quantità di ciascun ingrediente
            tot += quantita[i]*calorie[i];
        }
        //Stampa del risultato
        Console.WriteLine($"Le calorie totali sono: {tot}");
    }
}
