using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementYRotation : MonoBehaviour
{
    public float movementSpeed;
    public float movementRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles += new Vector3(0, -movementRotation, 0);
        }

        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles += new Vector3(0, movementRotation, 0);
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, movementSpeed, 0);
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -movementSpeed, 0);
        }
    }
}
