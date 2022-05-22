using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscribeConsola : MonoBehaviour
{
    public Text IngresoUsuario;

    public void EscribeCosasConsola()
    {
        {
            if (IngresoUsuario.text == "")
            {
                Debug.LogError("El campo no pueda estar vacio");
            }

            else
            {
                Debug.Log(IngresoUsuario.text);
            }

        }
    }

    public void EscribeDoble()
    {
        if (IngresoUsuario.text == "")
        {
            Debug.LogError("El campo no pueda estar vacio");
        }

        else
        {
            Debug.Log(int.Parse(IngresoUsuario.text) * int.Parse(IngresoUsuario.text));
        }
        
    }

}
