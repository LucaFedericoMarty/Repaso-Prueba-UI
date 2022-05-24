using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rectanguloMovedizoBehaviour : MonoBehaviour
{
    public float xSpeed;
    public float rectanguloMaxPosicionDerecha;
    public float rectanguloMaxPosicionIzquierda;
    public bool toRight;
    public GameObject sphereSpawn;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.x >= rectanguloMaxPosicionDerecha)
        {
            toRight = false;
            Instantiate(sphereSpawn);
            
        }

        else if (transform.position.x <= rectanguloMaxPosicionIzquierda)
        {
            toRight = true;
            Instantiate(sphereSpawn);
        }


        if (toRight)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }

        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }

        ////if (toRight)
        //{
        //    if (transform.position.x <= rectanguloMaxPosicionDerecha)
        //    {
        //        transform.position += new Vector3(xSpeed, 0, 0);

        //        if (transform.position.x == rectanguloMaxPosicionDerecha)
        //        {
        //            toRight = false;
        //        }
        //    }

        //}

        //else if (toRight == false)
        //{
        //    transform.position += new Vector3(-xSpeed, 0, 0);
        //}

    }
}
