using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscribirConsola : MonoBehaviour
{
    public Text UserName;
    public GameObject inputField;
    
    public void EscribirEnConsola()
    {
        Debug.Log("Hello World " + UserName.text);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inputField.SetActive(!inputField.activeInHierarchy);
        }
    }
}
