using System.Collections.Generic;

App.Run();

public class Controller
{   
    public int Controle { get; set;} 
    public float[] Valores { get; set;} = new float[40];
    public float Media { get; set;}
    public float SaidaSemRuido { get; set;}
    public float Control(float x)
    {
        Valores[Controle] = x;
        Controle++;
        for (int i = 0; i < Valores.Length; i++)
        {
            Media += Valores[i];
        }
        if(Controle == 40)
        {
            Controle = 0;
        }
        Media = Media / 40;
        SaidaSemRuido = (float)(Media * 1.57) - 285;
        return SaidaSemRuido;
    }
}