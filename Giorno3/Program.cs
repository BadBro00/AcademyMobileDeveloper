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
    }
}
