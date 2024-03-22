//----------------------------------------|Domande|----------------------------
teoriche:
1. Cosa si intende per programmazione?
2. Cosa è .NET Framework?
3. Cos'è un compilatore? A che cosa serve?
4. Qual è la differenza fra programmazione procedurale e programmazione ad oggetti?
5. Fornire un esempio di scrittura e lettura da Console
6. Qual è la differenza fra conversione implicita e conversione esplicita fra tipi? Indicare inoltre alcuni esempi.
7. Cosa è una variabile? Quali informazioni detiene in caso di assegnazione di un tipo riferimento?
8. Fornire un esempio di istruzione condizionale if-elseif-else
9. Come funziona il ciclo while? E il ciclo for?
10. Cosa è un metodo? Quali sono gli elementi che compongono la firma di un metodo? Con esempio. 
11. Qual è il ruolo di return nei metodi?
12. Definire il concetto di overloading e sue regole
13. Cosa si intende per classe in un linguaggio di programmazione OOP?
14. Qual è la differenza fra classe ed oggetto?
15. Spiegare gli spazi dei nomi in C#
16. Cos'è un array?
17. Cos'è una sequenza di escape?

----------------------------------|RISPOSTE|----------------------------------
1. La programmazione è l'attività di scrivere del "codice", ovvero un insieme di istruzioni, che verranno compilate ed eseguite da
    una macchina (computer), per raggiungere un risultato (output).
2. .NET Framework è un framework sviluppato da Microsoft che fornisce un ambiente di esecuzione per i programmi scritti in diversi
    linguaggi di programmazione, tra cui C#.
3. Un compilatore è un programma che, preso un codice sorgente, lo traduce nel linguaggio macchina, o un linguaggio interpretabile dalla macchina,
    in modo che possa essere eseguito.
4. La programmazione procedurale si fonda sull'utilizzo di 'procedure', ovvero pezzi di codice che eseguono un compito specifico, venendo eseguiti
    in maniera sequenziale. La programmazione ad oggetti, invece, si fonda sull'utilizzo di oggetti, che sono appunto istanze di classi, ovvero insieme di dati e funzioni,
    riutilizzabili più volte in differenti punti, e che possono interagire fra loro.
5. Un esempio di scrittura e lettura da console è proprio l'inserimento di dati per un processo. Ad esempio, se scrivessimo un programma che calcola
    l'area di un quadrato, dovremo chiedere all'utente di dirci qual è la dimensione del lato, e quindi avremo un "input" al processo. In C#, questo
    avviene tramite il metodo ReadLine(), che legge una stringa da tastiera (std input). Per poi restituire all'utente l'area, bisognerà usare il metodo
    WriteLine(), per poter scrivere a schermo il risultato (std output).
6.  La conversione implicita avviene quando non andiamo ad effettuare alcun cast, ovvero senza specificare esplicitamente il tipo in cui andiamo a convertire.
    Ad esempio, la conversione Int->Double può essere implicita, perchè non vengono perse informazioni sul valore, dato che un int è un double con mantissa nulla.
    La conversione esplicita avviene quando bisogna effettuare un cast, ovvero specificare il tipo in cui andiamo a convertire. Ad esempio, se vogliamo convertire
    un double in un int, dobbiamo specificare il cast, perchè potremmo perdere informazioni sulla parte decimale.
7. Una variabile è un'area di memoria, che può o meno contenere un valore. L'area di memoria sarà "vuota" finchè non verrà inizializzata tale variabile. In realtà,
    avremo un valore predefinito per ogni tipo di variabile. Ogni variabile ha un tipo, che definisce che informazione sta raccogliendo. Alcuni tipi possono essere:
        Int, Double, Float, Char, String, Bool,...
    Nel caso di assegnazione di un tipo riferimento, la variabile conterrà un riferimento ad un'area di memoria, che conterrà il valore.
8. Il costrutto di programmazione if-else if-else è un costrutto "a 3 vie", che opera seguendo una semplice logica condizionale:
        1. La prima condizione è vera? Si -> esegui il blocco di codice associato
        2. La prima condizione è falsa, ma la seconda è vera? Si -> esegui il blocco di codice associato
        3. La prima e la seconda condizione sono false? Si -> esegui il blocco di codice associato
    Un semplice esempio è il seguente:
        int x;
        //L'utente inserisce un valore per x
        if(x>5){
            //Codice se x è maggiore di 5
        }else if(x>1 && x<=4){
            //Codice se x è compreso fra 1 e 4
        }else{
            //Codice se x è minore o uguale a 1
        }
    Dipendentemente dal valore di x, verrà eseguito uno dei 3 blocchi di codice, in base alla condizione booleana che diverrà true.
9. Il ciclo while è un costrutto di programmazione che permette di eseguire un blocco di codice finchè la condizione risulta vera.
    Il ciclo for, invece, è un costrutto di programmazione che permette di eseguire un blocco di codice per un numero di volte definito,
    in base ad una condizione.
    Per fare un esempio di ciascuno:
        int indice = 0;
        while(indice < 5){                      for(indice=0;indice<5;indice++){
            //Codice                              //Codice
            indice++;                           }
        }
    La differenza è che con il ciclo while, non sappiamo sempre quante iterazioni avremo, mentre col for sì, perchè sono pre-specificate dal programmatore.
    Infine, la variabile indice è incrementata ad ogni iterazione, per evitare un ciclo infinito, mentre nel ciclo for, l'incremento è specificato nella dichiarazione.
10. Un metodo è un insieme di istruzioni che eseguono un compito. Un metodo è composto da:
        - Tipo di ritorno: il tipo di dato che il metodo restituirà
        - Nome del metodo: il nome con cui il metodo verrà chiamato
        - Parametri: gli input che il metodo riceverà
    Inoltre, i metodi hanno anche un "modificatore d'accesso", ovvero un'etichetta che definisce chi può accedere al metodo, e da dove.
    Il metodo poi è costituito da un "corpo", ovvero l'insieme di istruzioni che, quando richiamato, andrà a svolgere. Possiamo quindi vedere i metodi come dei
        moduli, o sottoprogrammi, che vengono eseguiti solamente quando l'utente/il programmatore li richiama.
11. return è una keyword che consente al metodo di ritornare un valore, ovvero restituirlo in output. Un metodo che non deve restituire valori è definito void, altrimenti
        dovrà restituire un valore del tipo specificato nel tipo di ritorno. Il return consente quindi di usare l'output di un metodo come parametro di un altro metodo, oppure
        di assegnarlo ad una variabile, o anche solo di stamparlo.
12. L'overloading è un concetto che consente di avere più metodi con lo stesso nome, ma con firme diverse. Le firme dei metodi sono composte da:
        - Nome del metodo
        - Tipo e ordine dei parametri
        - Tipo di ritorno
    Le regole dell'overloading sono:
        - I metodi devono avere lo stesso nome
        - I metodi devono avere firme diverse
        - I metodi possono avere tipi di ritorno diversi
    Un esempio di overloading è:
        int somma(int a, int b){
            return a+b;
        }
        double somma(double a, double b){
            return a+b;
        }
    In questo caso, abbiamo due metodi con lo stesso nome, ma con firme diverse, e con tipi di ritorno diversi.
13. Una classe è un costrutto di programmazione che consente di definire un tipo di dato personalizzato. Una classe è composta da:
        - Campi: ovvero le variabili che definiscono lo stato dell'oggetto
        - Proprietà: ovvero i metodi che permettono di accedere e modificare i campi
        - Metodi: ovvero le funzioni che l'oggetto può eseguire
        - Costruttori: ovvero i metodi che vengono eseguiti quando l'oggetto viene istanziato
    Le classi sono quindi un modo per organizzare il codice, e per definire un tipo di dato personalizzato, che può essere usato in più punti del programma.
14. La differenza fra classe ed oggetto è che la classe è un tipo di dato personalizzato, che definisce un insieme di dati e funzioni, mentre l'oggetto è un'istanza di tale classe,
        ovvero un'area di memoria che contiene i dati e le funzioni della classe. In pratica, la classe è il "progetto" dell'oggetto, mentre l'oggetto è l'istanza di tale progetto.
15. Gli spazi dei nomi in C# sono un modo per organizzare il codice in maniera gerarchica. Gli spazi dei nomi consentono di organizzare il codice in maniera modulare, e di evitare
        conflitti fra nomi di classi, metodi, variabili, ecc. Gli spazi dei nomi sono utili per organizzare il codice in maniera più leggibile e manutenibile.
16. Un array è un tipo di dato che consente di memorizzare più valori dello stesso tipo in un'unica variabile. Gli array sono utili per memorizzare insiemi di dati, e per poterli
        manipolare in maniera più semplice. Gli array sono composti da:
            - Tipo di dato: il tipo di dato che l'array conterrà
            - Dimensione: il numero di elementi che l'array conterrà
            - Indice: l'indice con cui si accede ad un elemento dell'array
