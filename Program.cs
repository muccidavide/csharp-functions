// See https://aka.ms/new-console-template for more information

// Creare funzione che ti stampa un array

using System.Diagnostics.Metrics;

int[] arrayEx = { 1, 2, 3, 4, 5, 7, 8, 9, };

void StampaArray(int[] array)
{
    Console.Write("[");
    int i;
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]);
        Console.Write(", ");
    }

    Console.Write(array[i]);
    Console.Write("]");
    Console.WriteLine("");

}

StampaArray(arrayEx);

Console.WriteLine("Quadrato");

Console.WriteLine(Quadrato(5));

int Quadrato(int numero)
{
    return numero * numero;
}

Console.WriteLine("Array elevato al quadrato:");

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = (int[])array.Clone();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = Quadrato(newArray[i]);
    }
    return newArray;
}
int[] elevatedArray = ElevaArrayAlQuadrato(arrayEx);
StampaArray(elevatedArray);

int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}

Console.WriteLine("La somma elementi array:");
Console.WriteLine(sommaElementiArray(arrayEx));


int[] arrayEx2 = { 2, 6, 7, 5, 3, 9 };
Console.Write("Array: ");
StampaArray(arrayEx2);
int[] arrayEx2Elevated = ElevaArrayAlQuadrato(arrayEx2);
Console.Write("Array elevato: ");
StampaArray(arrayEx2Elevated);
Console.Write("Array originale: ");
StampaArray(arrayEx2);

int sommaArray = sommaElementiArray(arrayEx);
int sommaArrayElevato = sommaElementiArray(arrayEx2Elevated);
Console.Write("La somma elementi array: ");
Console.WriteLine(sommaArray);
Console.Write("La somma elementi array elevato: ");
Console.WriteLine(sommaArrayElevato);

// Bonus:

int[] InsertArray(){

    Console.WriteLine("Inserisci numero elementi array");

    int counter = Convert.ToInt32(Console.ReadLine());
    int[] insertArray = new int[counter];
    Console.WriteLine("Inserisci numeri array");
    for (int i = 0; i < insertArray.Length; i++)
    {
        insertArray[i] = Convert.ToInt32(Console.ReadLine());

    }

    return insertArray;

}

void StampaArrayBonus()
{
    int[] array = InsertArray();
    Console.Write("[");
    int i;
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]);
        Console.Write(", ");
    }

    Console.Write(array[i]);
    Console.Write("]");
    Console.WriteLine("");

}

int[] ElevaArrayAlQuadratoBonus()
{
    int[] array = InsertArray();
    int[] newArray = (int[])array.Clone();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = Quadrato(newArray[i]);
    }
    return newArray;
}

int sommaElementiArrayBonus()
{
    int[] array = InsertArray();
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}

StampaArrayBonus();
int[] elevatedArrayBonus = ElevaArrayAlQuadratoBonus();
StampaArray(elevatedArrayBonus);
int sommaBonus = sommaElementiArrayBonus();
Console.WriteLine(sommaBonus);