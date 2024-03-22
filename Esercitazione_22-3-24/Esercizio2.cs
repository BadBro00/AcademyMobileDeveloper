using System;

public class Esercizio2{
    public static void Main(){
        Console.WriteLine("Inserisci la dimensione dell'array: ");
        int dim = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[dim];
        for(int i=0;i<dim;i++){
            Console.WriteLine("Inserisci elemento "+i+": ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        sortingArray s = new sortingArray();
        Console.WriteLine("Array in ordine crescente: ");
        int[] sortedArray = s.sort(array);
        foreach(var n in sortedArray){
            Console.WriteLine(n+" ");
        }
    }
}

public class sortingArray{
    public int[] sort(int[] arr){
        for(int i=0;i<arr.Length;i++){
            for(int j=i+1;j<arr.Length;j++){
                if(arr[i]>arr[j]){
                    int tmp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = tmp;
                }
            }
        }
        return arr;
    }
}
