using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiPrefab : MonoBehaviour
{
    public Text CantidadDePrefabs;
    public GameObject PrefabMulti;

    public void MultiInstantiatePrefab()
    {
        int CantFinal;
        CantFinal = int.Parse(CantidadDePrefabs.text);


        if (CantFinal > 0)
        {
            for (int i = 0; i < CantFinal; i++)
            {
                Instantiate(PrefabMulti);
            }
        }
        
        else if (CantFinal < 0)
        {
            Debug.LogError("El numero no puede ser negativo");
        }
    }
}
