using System;

double[] array = new double[]
{
    6.6, 7.2, 7.2, 8.4, 8.6, 8.4, 9.4, 9.8, 10.0
};
Console.WriteLine(mediaEspecial(array));

double mediaEspecial(double[] array)
{   
    double media = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if(i >= array.Length/2)
       {
            media = (array[i] + array[i-1] + array[i+1])/3;
            return media;
       } 
    }
    return float.NaN;
    
}