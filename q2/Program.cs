using System.Collections.Generic;

App.Run();

public class BluerControl
{   
    public void ApplyBlur(byte[] data)
    {
        byte[] vetorTemp = new byte[data.Length];

        for (int i = 0; i < data.Length; i++)
        {
            double mediaCalc = 0;
            double somaCalc = 0;
            vetorTemp[i] = data[i];
            if(i >= 20 && i <= data.Length - 20)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if(j >= i - 20 && j < i + 20)
                    {
                        somaCalc += data[j];
                    }
                }
                mediaCalc = somaCalc/41;
                vetorTemp[i] = (byte) mediaCalc;
            }
        }
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = vetorTemp[i];
        }
    }
}