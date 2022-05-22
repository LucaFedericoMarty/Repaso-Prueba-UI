using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject myCube;
    public Text cantidadPrefabs;
    public Text clonesLeft;
    int cantidadPrefabsReal;
    int counter = 0;
    int contador = 0;

    public void InstantiatorDeObjetos()
    {
        Instantiate(myCube);
    }

    public void OnceInstantiator()
    {
        if (counter < 1)
        {
            Instantiate(myCube);
            counter++;
        }

        else
        {
            Debug.Log("Instancia ya creada");
        }
    }

    public void MultiInstantiator()
    {
        cantidadPrefabsReal = int.Parse(cantidadPrefabs.text);

        if (cantidadPrefabs.text != "")
        {
            if (contador < cantidadPrefabsReal)
            {
                Instantiate(myCube);
                contador++;
                clonesLeft.text = (cantidadPrefabsReal - contador).ToString();

            }

            else
            {
                Debug.LogError("Ya has alcanzado el limite de prefabs");
            }
        }

        else
        {
            Debug.LogError("No se puede ingresar NADA");
        }

            
        }
        
}
