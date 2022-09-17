// See https://aka.ms/new-console-template for more information

// Creare funzione che ti stampa un array

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

Console.WriteLine("");

Console.Write(Quadrato(5));

int Quadrato(int numero)
{
    return numero * numero;
}

Console.WriteLine("");

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

Console.WriteLine(sommaElementiArray(arrayEx));


int[] arrayEx2 = { 2, 6, 7, 5, 3, 9 };
StampaArray(arrayEx2);
int[] arrayEx2Elevated = ElevaArrayAlQuadrato(arrayEx2);
StampaArray(arrayEx2Elevated);
StampaArray(arrayEx2);

int sommaArray = sommaElementiArray(arrayEx);
int sommaArrayElevato = sommaElementiArray(arrayEx2Elevated);
Console.WriteLine(sommaArray);
Console.WriteLine(sommaArrayElevato);   

// Bonus: