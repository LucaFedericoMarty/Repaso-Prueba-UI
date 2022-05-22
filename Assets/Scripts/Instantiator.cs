using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject myCube;
    public Text cantidadPrefabs;
    int cantidadPrefabsReal;

    public void InstantiatorDeObjetos()
    {
        Instantiate(myCube);
    }

    public void OnceInstantiator()
    {
        for (int i = 0; i < 1; i++)
        {
            Instantiate(myCube);
        }
    }

    public void MultiInstantiator()
    {
        cantidadPrefabsReal = int.Parse(cantidadPrefabs.text);

        int contador = 0;

        for(int i = 0; i < cantidadPrefabsReal; i++)
        {
            if (contador < cantidadPrefabsReal)
            {
                contador++;
                Instantiate(myCube);
            }

            else
            {
                Debug.LogError("Ya has alcanzado el limite de prefabs");
            }
        }
        
    }

    void Update()
    {
        cantidadPrefabsReal = int.Parse(cantidadPrefabs.text);

        int contador = 0;

        if (contador < cantidadPrefabsReal)
        {
            contador++;
            Instantiate(myCube);
        }

        else
        {
            Debug.LogError("Ya has alcanzado el limite de prefabs");
        }
    }
}
