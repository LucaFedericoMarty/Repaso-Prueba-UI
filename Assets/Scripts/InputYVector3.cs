using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputYVector3 : MonoBehaviour
{
    public GameObject inputActivoDesactivo;
    public GameObject objectMove;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.A))
        //{
          //  Debug.Log("Has presionado la tecla A");
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            inputActivoDesactivo.SetActive(!inputActivoDesactivo.activeInHierarchy);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            objectMove.transform.position += new Vector3(movementSpeed, 0, 0);
        }

        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            objectMove.transform.position += new Vector3(-movementSpeed, 0, 0);
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            objectMove.transform.position += new Vector3(0, movementSpeed, 0);
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            objectMove.transform.position += new Vector3(0, -movementSpeed, 0);
        }


    }
}
