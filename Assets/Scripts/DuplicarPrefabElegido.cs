using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuplicarPrefabElegido : MonoBehaviour
{
    public Text testNprefab;
    public GameObject PrefabN1;
    public GameObject PrefabN2;
    public GameObject PrefabN3;

    public void DuplicateNPrefab()
    {
        GameObject clon;

        if (testNprefab.text == "Prefab 1 Activado")
        {
            for (int i = 0; i < 1; i++)
            {
                clon = Instantiate(PrefabN1);
                Destroy(clon, 2);
            }
            
        }

        else if (testNprefab.text == "Prefab 2 Activado")
        {
            for (int i = 0; i < 1; i++)
            {
                clon = Instantiate(PrefabN2);
                Destroy(clon, 2);
            }
        }

        else if (testNprefab.text == "Prefab 3 Activado")
        {
            for (int i = 0; i < 1; i++)
            {
                clon = Instantiate(PrefabN3);
                Destroy(clon, 2);
            }
        }

    }
}


