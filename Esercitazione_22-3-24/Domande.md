//-----------------------------|DOMANDE|---------------------------
1. Indicare un esempio pratico di Ereditarietà in C# con commento.
2. Qual è la differenza fra metodo virtuale e metodo astratto?
3. Cos’è una eccezione. Indicare un esempio.
4. Qual è la differenza fra classe astratta e interfaccia?
5. Come funziona un delegate? Perché utilizzarli?
6. Indicare un esempio di delegate Func<int,int,int> e Action<string> tramite funzioni lambda
7. Quali sono i principali vantaggi nell’utilizzo di Collezioni rispetto agli array?
    Indicare inoltre un esempio di Dictionary e stampa in Console dei suoi elementi.
8. Che cos’è il codice gestito e non gestito?
9. Indica i diversi tipi di classe in C# (es classe astratta etc..)
10. Spiegare la compilazione in C#
12. Che cos’è l’istruzione using in C#?
13. Spiega l’astrazione e il polimorfismo
14. Come viene implementata la gestione delle eccezioni in C#?
15. Che cos'è un delegato?
16. Cosa significa delegati multicast?
17. Spiegare la proprietà get e set

//-----------------------------|RISPOSTE|---------------------------
1. Un esempio pratico di Ereditarietà è il seguente:
    public class Animale{
        public string nome_comune;
        public Animale(string nm){
            this.nome_comune = nm;
        }
        public void Verso();
    }
    public class Gatto : Animale{
        public Gatto(){
            this.nome_comune = gatto;
        }
        public void Verso(){
            Console.WriteLine("Meow");
        }
    }
    In questo caso, abbiamo che Gatto eredita da Animale, e quindi ne eredita i campi e i metodi. Inoltre, essendo due classi
        diverse, può ridefinire il metodo Verso(), impostandolo quindi a "meow", cioè il verso del gatto.
2. Un metodo astratto è un metodo definito tramite la keyword "abstract", che non viene implementato, e *può* essere definito nella sottoclasse. Un metodo virtual invece, è definito tramite la keyword *virtual abstract*, e *deve* essere implementato nelle sottoclassi.
3. Un'eccezione è un evento inatteso durante l'esecuzione di un processo. Esistono vari tipi di eccezioni, i più comuni sono il *FormatException*, in cui il tipo di dato dato come input è *di un formato diverso* rispetto a quello richiesto (int->char); Abbiamo poi la *DivideByZeroException*, in cui durante una divisione, *il dividendo è 0*, e quindi l'ALU genera questa eccezione; Un'altra è la *NullReferenceException*, in cui *si va ad utilizzare un dato che è NULL*.
4. Un'interfaccia è una collezione di metodi pubblici, e vanno implementati nelle classi che li ereditano dall'interfaccia. Una classe astratta è una classe con *almeno un metodo abstract*, che *dev'essere implementato* nella classe che la eredita.
5. Un delegate è un *tipo che rappresenta riferimenti a metodi con un particolare elenco di parametri e tipi di ritorno*. E' possibile associare il delegate a *qualsiasi metodo con firma compatibile*. I delegate sono utili per implementare *callback* ed *eventi*, ed inoltre sono la base per i metodi *anonimi* e le *espressioni Lambda*.
6. Un esempio della function *Action<string>*, tramite funzioni Lambda, in C# è il seguente:
        Action<string> display = *(message)=>{Console.WriteLine(message);}*
        display("Ciao");
    In questo snippet, *display è un metodo che andrà a printare a schermo la stringa message*.
   Un esempio della function *Func<int,int,int>*, tramite funzioni Lambda, in C# è il seguente:
        Func<int,int,int> sum = *(a,b) => {return a+b;}*
        sum(1,2) //Ritornerà 1+2=3
7. I vantaggi dell'utilizzo delle collezioni, rispetto agli array, sono molteplici.
    Il principale è sicuramente *un miglior utilizzo della memoria*, in quanto le collezioni gestiscono automaticamente la dimensione, mentre per gli array bisognerebbe riallocarla, §*all'aggiunta di elementi*.
    Le collezioni inoltre sono dotati di metodi di *ricerca, rimozione ed aggiunta*, molto *più performanti* rispetto ai semplici array.
    Un altro vantaggio è la possibilità di immagazzinare *anche tipi di dati diversi*, come le *KeyValuePair<T1,T2>* o i *Dictionary<T1,T2,...>*. Spesso inoltre, al posto di uno dei parametri (*T1,T2,..*), si può utilizzare anche *una diversa collezione*, come nel caso dei *Dictionary Multidimensionali/Annidati*.
    Per stampare gli elementi di una collezione, come una *List<>*, il metodo più semplice e comodo è quello di usare un *foreach*, iterando sugli elementi e stampandone le proprietà:
    
    *foreach(var elem in List<>){*
        *Console.WriteLine(...);*
    *}*

8. Il codice *gestito* è *la parte di codice eseguita sotto il controllo de Common Language Runtime*, che fornisce servizi come
    *gestione della memoria*, *gestione delle eccezioni*, e *sicurezza del tipo*. Quando viene compilato, è *convertito in un liguaggio intermedio*, eseguibile su qualsiasi piattaforma che supporta .NET.
   Il codice *non gestito* è invece quel codice che *non viene eseguito solamente sotto il controllo del CLR*, ed ha accesso diretto alla memoria ed alle risorse del sistema.
9. Vi sono diversi tipi di classi:
    1. Classe *Astratta* : Classe contenente *almeno un metodo definito abstract*
    2. Classi *Regolari* : Le regolari classi dichiarate tramite keyword *class*
    3. Classi *Parziali* : Classi definite *in più parti del codice o più file*
    4. Classi *Sigillate*: Classi che *non possono essere estese*.
    5. Classi *Statiche* : Classi che *non possono essere istanziate*, i cui membri *sono tutti statici*
10. La compilazione in C# segue i seguenti passaggi:
    1. *Analisi Sorgente*     : Il compilatore legge il codice sorgente, e ne verifica la sintassi
    2. *Generazione IL*       : Se il codice è corretto, il compilatore lo traduce nel *Common Intermediate Language*, a basso livello
    3. *Generazione Metadati* : Il compilatore genera metadati che descrivono l'*IL*
    4. *Creazione Assembly*   : Il codice IL e i metadati vengono *Incapsulati* nell'assembly, che può essere
        un eseguibile (*.exe*)
        oppure una libreria di *collegamento dinamico* (*.dll*)
12. L'istruzione *using* è una direttiva al preprocessore, che serve a notificare l'utilizzo di librerie specifiche, esterne al codice scritto. Ad esempio, se volessimo usare le collezioni, come appunto una List<T>, dovremmo notificare al compilatore che andremo ad utilizzare la libreria che le contiene, altrimenti verrà generato un errore.
13. L'astrazione è il processo di *nascondere i dettagli d'implementazione complessi*, e mostrare all'utente *solo le funzionalità*. In C#, è implementata mediante *classi astratte* od *interfacce*. Il polimorfismo invece è la possibilità di un oggetto di *adottare più forme*, quindi permette ad una classe di essere usata *come il suo tipo di base*, oppure come *qualsiasi tipo di interfaccia che la classe implementa*. Ciò significa che un metodo che accetta un tipo come parametro, *accetterà come parametro anche un suo sottotipo*.
14. In C# la gestione delle eccezioni avviene secondo lo schema *try-catch-finally*.
    Il *try* cerca di effettuare un'operazione che può generare l'eccezione.
    Il *catch* cattura l'eccezione, e la gestisce in qualche modo.
    Il *finally* invece procede a completare l'operazione.
15. Un delegato è un tipo che rappresenta riferimenti a metodi con un particolare elenco di parametri e tipi di ritorno. Quando si istanzia, si può associare ad un metodo con firma compatibile.
16. E' un tipo di delegato che *fa riferimento a più di un metodo* per volta. Quando un delegato multicast viene richiamato, *tutti i metodi collegati sono richiamati in ordine*
17. Le proprietà *get* e *set* servono a ritornare e settare le proprietà di un oggetto. Tramite queste due proprietà, possiamo infatti andare a *"prendere"* e ad *assegnare* i valori a/da un campo di una classe, come ad esempio:
    public class Studente{
        public ID {get;set;}
        public nome {get;set;}
        public Studente(string nome,int ID){
            this.nome=nome;
            this.ID=ID;
        }
        //Codice...
    }
    //MAIN:
    Studente s = new Studente("Studente",1);
    s.ID = 2; //s.SetID(2);
    Console.WriteLine("Nuovo ID: "+s.ID);//s.GetID()
