using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DivisionEntreNumeros : MonoBehaviour
{
    public Text num1;
    public Text num2;
    public Text resultadofinal;
    int resultado;

    public void DivisionNumeros()
    {
        if (num1.text == ""|| num2.text == "")
        {
            Debug.LogError("Los campos no pueden estar vacios");
        }

        else if (num2.text == "0")
        {
            Debug.LogError("No se puede dividir por cero");
        }

        else
        {
           resultado = (int.Parse(num1.text) / int.Parse(num2.text));   
        }

        resultadofinal.text = resultado.ToString();
    }
}
