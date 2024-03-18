using System;

public class Giorno6_Extra{
    public static void Main(){
        decimal importo;
        AccountBancario a = new AccountBancario("Mario", "Rossi", 12345);
        a.Pagamento();
        a.Pagamento();
        a.Pagamento();
        Console.WriteLine("1) Deposito\n2)Prelievo\n3)Bilancio\n4)Storico\n5)Pagamento\n6)Esci");
        int scelta = Convert.ToInt32(Console.ReadLine());
        bool end = false;
            switch(scelta){
                case 1:
                    Console.WriteLine("Inserire l'importo da depositare");
                    importo = Convert.ToDecimal(Console.ReadLine());
                    a.Deposito(importo);
                    a.Bilancio();
                    break;
                case 2:
                    Console.WriteLine("Inserire l'importo da prelevare");
                    importo = Convert.ToDecimal(Console.ReadLine());
                    a.Ritiro(importo);
                    a.Bilancio();
                    break;
                case 3:
                    a.Bilancio();
                    break;
                case 4:
                    a.Storico();
                    break;
                case 5:
                    a.Pagamento();
                    break;
                case 6:
                    end = true;
                    return;
                default:
                    Console.WriteLine("Scelta non valida");
                break;
        }
    }
}

public struct Persona{
    public string Nome;
    public string Cognome;

}

public class Transazione{
    public Transazione next{get; set;}
    
    public DateTime dt{get; set;}
    public string to{get; set;}
    public string note{get; set;}
    public decimal importo{get; set;}
    public Transazione(DateTime dt, string note, decimal importo){
        this.dt = DateTime.Now;
        this.note = note;
        this.importo = importo;
    }
}
public class Lista{
    public Transazione head{get; set;}
    public Transazione tail{get; set;}
    public void Add(Transazione t){
        if(head == null){
            head = t;
            tail = t;
        }else{
            tail = t;
        }
    }
}

public class AccountBancario{
    private Lista L{get; set;}
    private Persona proprietario;
    private decimal bilancio;
    private int numero;
    public AccountBancario(string nm,string cn, int numero){
        proprietario = new Persona();
        proprietario.Nome = nm;
        proprietario.Cognome = cn;
        this.numero = numero;
        this.bilancio = 1000;
        L = new Lista();
    }
    public void Storico(){
        Console.WriteLine("Storico transazioni:");
        while(L.head != null){
            Console.WriteLine($"Data: {L.head.dt}, Destinatario: {L.head.to}, Note: {L.head.note}, Importo: {L.head.importo}");
            L.head = L.head.next;        
        }
    }
    public void Deposito(decimal importo){
        bilancio += importo;
        Console.WriteLine("Deposito di {0} effettuato", importo);
    }
    public void Ritiro(decimal importo){
        if(bilancio < importo){
            Console.WriteLine("Fondi insufficienti");
            return;
        }
        bilancio -= importo;
        Console.WriteLine("Ritiro di {0} effettuato", importo);
    }
    public void Bilancio(){
        Console.WriteLine($"Bilancio: {bilancio}");
    }
    public void Pagamento(){
        Console.WriteLine("Inserire l'importo da pagare");
        decimal importo = Convert.ToDecimal(Console.ReadLine());
        if(bilancio < importo){
            Console.WriteLine("Fondi insufficienti");
            return;
        }
        bilancio -= importo;
        Transazione t = new Transazione(DateTime.Now, "Pagamento", importo);
        L.Add(t);
    }
}
