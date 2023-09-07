// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;



int[] arrayNum = { 2, 6, 7, 5, 3, 9 };

StampaArray(arrayNum);

int numeroUtente = int.Parse(Console.ReadLine());
Quadrato(numeroUtente);
Console.WriteLine($"Numero al quadrato: {Quadrato(numeroUtente)}");

Console.Write($"Array al quadrato = ");
StampaArray(ElevaArrayAlQuadrato(arrayNum));
Console.Write($"Array originale = ");
StampaArray(arrayNum);


sommaElementiArray(arrayNum);
Console.WriteLine($"Somma dell'array = {sommaElementiArray(arrayNum)}");



//FUNZIONI


void StampaArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
       {
            Console.Write(array[i]);
        }
    }

    Console.WriteLine("]");
}


double Quadrato(int numero)
{
  double numeroAlQuadrato = Math.Pow(numero, 2);
    return numeroAlQuadrato;
}




int[] ElevaArrayAlQuadrato(int[] array) 
{
    int[] arrayClone = (int[])array.Clone();

    for(int i = 0; i < arrayClone.Length; i++)
    {
        double numeroAlQuadrato = Math.Pow(arrayClone[i], 2);
        arrayClone[i] = (int)numeroAlQuadrato;
    }
    return arrayClone;

}




int sommaElementiArray(int[] array)
{
    int[] arrayCopia = (int[])array.Clone();
    int somma = 0;

    for (int i = 0; i < arrayCopia.Length; i++)
    {
        somma += arrayCopia[i];
    }

    return somma;
}




