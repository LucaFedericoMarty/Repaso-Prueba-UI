using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabFila : MonoBehaviour
{
    public GameObject prefabdefilas;
    public Text cantidadDePrefabsFila;
    
    public void FilaPrefab ()
    {
        int CantidadFinal;

        CantidadFinal = int.Parse(cantidadDePrefabsFila.text);

        GameObject clon;

        for (int i = 0; i < CantidadFinal; i++)
        {
            if (CantidadFinal != 0)
            {
                clon = Instantiate(prefabdefilas);
                clon.transform.Translate(i, 0, 0);
            }

            else if (CantidadFinal == 0 || CantidadFinal < 0)
            {
                Debug.Log("No puede ser 0 o Negativo");
            }

            else if (cantidadDePrefabsFila.text == "")
            {
                Debug.Log("INFINITOS CUBOS");
            }
        }
    }

}
