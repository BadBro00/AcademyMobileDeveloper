using System;
/*
 public class Giorno3{
    //Metodo static per poterlo richiamare senza istanziare la classe
    static void prt_day(DateTime dt){
        Console.WriteLine(dt.ToString());
        int day = dt.Day;
        int month = dt.Month;
        int year = dt.Year;
        Console.WriteLine("Giorno: " + day + ", Mese: " + month + ", Anno: " + year);
        string weekday = dt.DayOfWeek.ToString();
        switch(weekday){
            case "Monday":
                Console.WriteLine("Lunedì");
                break;
            case "Tuesday":
                Console.WriteLine("Martedì");
                break;
            case "Wednesday":
                Console.WriteLine("Mercoledì");
                break;
            case "Thursday":
                Console.WriteLine("Giovedì");
                break;
            case "Friday":
                Console.WriteLine("Venerdì");
                break;
            case "Saturday":
                Console.WriteLine("Sabato");
                break;
            case "Sunday":
                Console.WriteLine("Domenica");
                break;
        }
    }
    public static void Main(){
        DateTime dt = DateTime.Now;
        prt_day(dt);
        //"Aggiungo" un giorno alla data
        prt_day(dt.AddDays(1));

    }
 }*/
 //--------------------------------------------------------------------------------
 /*
 Es1:

 * Leggi un array di numeri interi ed estrai gli elementi che hanno lo stesso valore del loro indice.




Es2:
  *      Scrivere un programma che visualizzi informazioni su un personaggio di un videogioco.
  *      Si avrà  in output: nome, salute attuale, salute massima, energia attuale e massima  su righe separate.
  *      I valori correnti saranno uguali o inferiori ai rispettivi valori massimi
  *      Stampali nel formato come nell'esempio
  * 
  *      
  *      ESEMPIO:
  *      
  *      Nome: Mario
         Salute:  ||||||||||||||||||||||||||||||.......................................................................|
         Energia: |||||||||||||||||||||||||||||||||||||................................................................|

          Infliggere per 2 volte danni al personaggio, se la salute scende a zero terminare la partita


Es 3:

REALIZZARE L'ESERCIZIO DI IERI UTILIZZANDO UN METODO:

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
public class Esercizi3{
    public static void Esercizio1(int[] array){
        Console.WriteLine("Array: \n");    
        for(int i=0;i<array.Length;i++){
            Console.Write(array[i]+" ");
        }
        Console.WriteLine("\nValori uguali all'indice: \n");
        for(int i=0;i<array.Length;i++){
            if(array[i]==i){
                Console.Write(array[i]);
            }
        }
    }
    public static void Esercizio2(string nome,int saluteatt,int eneratt,int salutefin = 100,int enerfin=100){
        int turn = 0;
        do{
            Console.WriteLine($"Nome: {nome}\n");
            Console.WriteLine("Salute: ");
            for(int i=0;i<saluteatt;i++){
                Console.Write("|");
            }
            for(int i=saluteatt+1;i<salutefin;i++){
                Console.Write("-");
            }
            Console.Write("|\n");
            Console.WriteLine("Energia:");
            for(int i=0;i<eneratt;i++){
                Console.Write("|");
            }
            for(int i=eneratt+1;i<enerfin;i++){
                Console.Write("-");
            }
            Console.Write("|\n");
            Console.WriteLine("\n--------------------\nNuovo Turno\n--------------------\n");
            Random rnd = new Random();
            for(int i=0;i<2;i++){
                int dmg = rnd.Next(1,saluteatt);
                saluteatt-=dmg;
                if(saluteatt<=0){
                    Console.WriteLine("\nIl personaggio è morto");
                    break;
                }
            }
            turn++;
        }while(saluteatt>0 && turn<2);
    }
    public static void Esercizio3(){
        int totcal = 0;
        int[] cal = {500,300,40,50};
        int[] quant = new int[4];
        Random rnd = new Random();
        for(int i=0;i<4;i++){
            Console.WriteLine("Inserisci la quantità di ingrediente "+(i));
            quant[i] = int.Parse(Console.ReadLine());
            totcal+=cal[i]*quant[i];
        }
        Console.WriteLine("Calorie totali: "+totcal);
    }
    public static void Esercizio3BIS(){
        int choice;
        int totcal = 0;
        int[] cal = {500,300,40,50};
        int[] quant = new int[4];
        do{
            Console.WriteLine("Scegli cosa fare:\n1)Inserisci un ingrediente (1)\n2)Esci (0)");
            choice = int.Parse(Console.ReadLine());
            if(choice==1){
                Console.WriteLine("Inserisci l'ingrediente da aggiungere");
                int ing = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci la quantità di ingrediente "+(ing));
                quant[ing] = int.Parse(Console.ReadLine());
                totcal+=cal[ing]*quant[ing];
                Console.WriteLine("Calorie totali: "+totcal);
            }else if(choice==0){
                Console.WriteLine("Calorie totali: "+totcal);
                break;
            }else{
                Console.WriteLine("Scelta non valida,riprova!");
            }
        }while(choice!=0);
        //Console.WriteLine("Calorie totali: "+totcal);
    }
    public static void Main(){
        Random rd = new Random();
        Console.WriteLine("Esercizio 1\n-----------------");
        Console.WriteLine("Inserisci la lunghezza dell'array");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for(int i=0;i<n;i++){
            array[i] = rd.Next(0,n);
        }
        Esercizio1(array);
        Console.WriteLine("Esercizio 2\n------------------");
        int salatt = rd.Next(1,100);
        int eneratt = rd.Next(1,100);
        string nome;
        Console.WriteLine("Inserisci il nome del personaggio");
        nome = Console.ReadLine();
        Esercizio2(nome,salatt,eneratt);
        Console.WriteLine("Esercizio 3\n------------------");
        Esercizio3();
        Esercizio3BIS();
    }
}
