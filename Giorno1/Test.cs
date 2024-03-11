//Librerie di sistema
using System;
//Classe principale
public class Prova{
  //Function (esterna) per eseguire l'insertion sort
    public void InsertionSort(int[] array){
        for(int i = 1; i < array.Length; i++){
            int key = array[i];
            int j = i - 1;
            while(j >= 0 && array[j] > key){
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }
  //Function (esterna) per eseguire il Merge
    public void Merge(int[] array, int l, int m, int r){
        int n1 = m - l + 1;
        int n2 = r - m;
        int[] L = new int[n1];
        int[] R = new int[n2];
        for(int i = 0; i < n1; i++){
            L[i] = array[l + i];
        }
        for(int j = 0; j < n2; j++){
            R[j] = array[m + 1 + j];
        }
        int k = l;
        int a = 0;
        int b = 0;
        while(a < n1 && b < n2){
            if(L[a] <= R[b]){
                array[k] = L[a];
                a++;
            }else{
                array[k] = R[b];
                b++;
            }
            k++;
        }
        while(a < n1){
            array[k] = L[a];
            a++;
            k++;
        }
        while(b < n2){
            array[k] = R[b];
            b++;
            k++;
        }
    }
  //Function (esterna) per eseguire il merge sort
    public void MergeSort(int[] array,int l, int r){
        if(r>l){
            int m = l + (r - l) / 2;
            MergeSort(array, l, m);
            MergeSort(array, m + 1, r);
            Merge(array, l, m, r);
        }
    }
  //Main di TUTTA la classe
    public static void Main(){
        int arraySize = 10;
        int[] array = new int[arraySize];
        Random random = new Random();
        for(int i = 0; i < arraySize; i++){
            array[i] = random.Next(0, 100);
        }
        Console.WriteLine("Array non ordinato");
        for(int i = 0; i < arraySize; i++){
            Console.WriteLine(array[i]);
        }
      //ISTANZIAMENTO DELLA CLASSE, PER USARE I METODI
        Prova prova = new Prova();
      //Utilizzo del metodo InsertionSort
        prova.InsertionSort(array);
        Console.WriteLine("Array ordinato");
        for(int i = 0; i < arraySize; i++){
            Console.WriteLine(array[i]);
        }
        for(int i = 0; i < arraySize; i++){
            array[i] = random.Next(0, 100);
        }
        Console.WriteLine("Array non ordinato");
        for(int i = 0; i < arraySize; i++){
            Console.WriteLine(array[i]);
        }
      //Utilizzo del metodo MergeSort
        prova.MergeSort(array, 0, arraySize - 1);
        Console.WriteLine("Array ordinato");
        for(int i = 0; i < arraySize; i++){
            Console.WriteLine(array[i]);
        }
    }
}
