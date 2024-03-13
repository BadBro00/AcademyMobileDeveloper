public class Giorno3{
    //Definire il metodo static aiuta a non dover istanziare la classe per chiamare il metodo
    public static void Somma(int a,int b){
        Console.WriteLine($"La somma è: {a+b}");
    }
    public static void Main(){
        //Un metodo statico può essere chiamato senza istanziare la classe
        //Giorno3 g = new Giorno3();
        int n1,n2;
        Console.WriteLine("Inserisci primo numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci secondo numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Somma(n1,n2);
      //Variabile REFERENCE per il GARBAGE COLLECTOR - Passaggio valore per *Riferimento*
        int a = ref n1;
        //----------------|DATE|--------------
        DateTime data = new DateTime(2024,3,13);
        Console.WriteLine(data.ToString());
        int day = data.Day;
        int month = data.Month;
        int year = data.Year;
        Console.WriteLine("Giorno: " + day + ", Mese: " + month + ", Anno: " + year);
        string weekday = data.DayOfWeek.ToString();
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
}
