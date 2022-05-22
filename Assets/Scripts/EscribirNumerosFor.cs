using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscribirNumerosFor : MonoBehaviour
{
    public Text Numero1Str;
    public Text Numero2Str;

    public void NumerosDelCeroAlCien ()
    {
        int i = 0;
        while (i < 100)
        {
            Debug.Log(i);
            i++;
        }
    }

    public void NumerosDelCienAlCero ()
    {
        for (int i = 100; i > 0; i--)
        {
            Debug.Log(i);
        }
    }

    public void NumerosEntreSeleccion ()
    {
        int num1 = int.Parse(Numero1Str.text);
        int num2 = int.Parse(Numero2Str.text);

        if (num1 < num2)
        {
            while (num1 < num2)
            {
                Debug.Log(num1);
                num1++;
            }
        }

        else if (num1 > num2)
        {
            while (num1 > num2)
            {
                Debug.Log(num1);
                num1--;
            }
        }

        else if (num1 == num2)
        {
            Debug.Log("No pueden ser iguales");
        }
    }

    public void NumerosEntreSeleccionFor()
    {
        int num1 = int.Parse(Numero1Str.text);
        int num2 = int.Parse(Numero2Str.text);

        if (num1 < num2)
        {
            for (int num1v2 = num1; num1v2 < num2; num1v2++)
            {
                Debug.Log(num1v2);
            }
                       
        }

        else if (num1 > num2)
        {
            for (int num1v2 = num1; num1 > num2; num1--)
            {
                Debug.Log(num1);
            }
        }

        else if (num1 == num2)
        {
            Debug.Log("No pueden ser iguales");
        }
    }
}
