/*ES 1:
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
using System;
public class Giorno2{
    public static void Main(){
        //Esercizio 1
        //Dichiaro le variabili
        double h,w;
        Console.WriteLine("Inserisci l'altezza del rettangolo: ");
        h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci la larghezza del rettangolo: ");
        w = Convert.ToDouble(Console.ReadLine());
        //Stampa dell'area
        Console.WriteLine($"L'area del rettangolo è: {h*w}");
        //Esercizio 2
        //Inizializzo i costi, sconti e capacità
        int costo1 = 2500;
        int costo2 = 5000;
        int costo3 = 7500;
        //----------
        int sconto1 = 500;
        int sconto2 = 750;
        int sconto3 = 1000;
        //----------
        int cap1 = 50;
        int cap2 = 100;
        int cap3 = 120;
        //-----------
        int pers,sala,pack;
        double sconto,prezzo;
        //Scelta sala
        Console.WriteLine("Scegli la sala:\n1)50ps - EUR 2500\n2)100ps - EUR 5000\n3)120ps - EUR 7500: ");
        sala = Convert.ToInt32(Console.ReadLine());
        switch (sala){
            //Scelta la sala 1
            case 1:
                prezzo = costo1;
                //Scelta del pacchetto
                Console.WriteLine("Scegli il pacchetto:\n1)5% - EUR 500\n2)10% - EUR 750\n3)15% - EUR 1000: ");
                pack = Convert.ToInt32(Console.ReadLine());
                switch(pack){
                    //Scelto il pacchetto 1
                    case 1:
                        sconto = 5;
                        prezzo+=sconto1;
                        break;
                    //Scelto il pacchetto 2
                    case 2:
                        sconto = 10;
                        prezzo+=sconto2;
                        break;
                    //Scelto il pacchetto 3
                    case 3:
                        sconto = 15;
                        prezzo+=sconto3;
                        break;
                    //Qualunque altra scelta inserita
                    default:
                        Console.WriteLine("Pacchetto non valido");
                        return;
                }
                break;
            case 2:
                prezzo = costo2;
                Console.WriteLine("Scegli il pacchetto:\n1)5% - EUR 500\n2)10% - EUR 750\n3)15% - EUR 1000: ");
                pack = Convert.ToInt32(Console.ReadLine());
                switch(pack){
                    case 1:
                        sconto = 5;
                        prezzo+=sconto1;
                        break;
                    case 2:
                        sconto = 10;
                        prezzo+=sconto2;
                        break;
                    case 3:
                        sconto = 15;
                        prezzo+=sconto3;
                        break;
                    default:
                        Console.WriteLine("Pacchetto non valido");
                        return;
                }
                break;
            case 3:
                prezzo = costo3;
                Console.WriteLine("Scegli il pacchetto:\n1)5% - EUR 500\n2)10% - EUR 750\n3)15% - EUR 1000: ");
                pack = Convert.ToInt32(Console.ReadLine());
                switch(pack){
                    case 1:
                        sconto = 5;
                        prezzo+=sconto1;
                        break;
                    case 2:
                        sconto = 10;
                        prezzo+=sconto2;
                        break;
                    case 3:
                        sconto = 15;
                        prezzo+=sconto3;
                        break;
                    default:
                        Console.WriteLine("Pacchetto non valido");
                        return;
                }
                break;
            //Qualunque altra scelta inserita
            default:
                Console.WriteLine("Sala non valida");
                return;
        }
        //Controllo sul numero di persone (giusto per)
        Console.WriteLine("Inserisci il numero di persone: ");
        pers = Convert.ToInt32(Console.ReadLine());
        if(pers<cap1||pers>cap3){
            Console.WriteLine("Numero di persone non valido");
            return;
        }
        //Calcolo del prezzo
        double tot=prezzo-(prezzo*(sconto*0.01));
        Console.WriteLine($"Il prezzo totale è: {tot}");
        //Esercizio 3
        //Array di calorie in base ai vari ingredienti
        int tot_cal = 0;
        int cal_ing1 = 500;
        int cal_ing2 = 300;
        int cal_ing3 = 40;
        int cal_ing4 = 50;
        //Array di quantità per gestire gli ingredienti
        int cal_tot = 0;
        //Ciclo for per iterare su ciascun ingrediente, e quindi anche le capacità
        for(int i=0;i<4;i++){
            int times = 0;
            Console.WriteLine($"Inserisci quante volte inserire l'ingrediente: {i+1}: ");
            times = Convert.ToInt32(Console.ReadLine());
            for(int j=0;j<times;j++){
                int qt = 0;
                switch(i){
                    case 0:
                        Console.WriteLine($"Inserisci la quantità di calorie per l'ingrediente {i+1}: ");
                        qt = Convert.ToInt32(Console.ReadLine());
                        cal_tot+=cal_ing1*qt;
                        break;
                    case 1:
                        qt = Convert.ToInt32(Console.ReadLine());
                        cal_tot+=cal_ing2*qt;
                        break;
                    case 2:
                        qt = Convert.ToInt32(Console.ReadLine());
                        cal_tot+=cal_ing3*qt;
                        break;
                    case 3:
                        qt = Convert.ToInt32(Console.ReadLine());
                        cal_tot+=cal_ing4*qt;
                        break;
                }
            }
        }
        //Stampa del risultato
        Console.WriteLine($"Le calorie totali sono: {cal_tot}");
    }
}
