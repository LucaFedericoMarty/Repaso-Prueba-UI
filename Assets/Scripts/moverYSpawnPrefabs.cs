using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverYSpawnPrefabs : MonoBehaviour
{
    public float xSpeed;
    public float rectanguloMaxPosicionDerecha;
    public float rectanguloMaxPosicionIzquierda;
    public bool toRight;

    public GameObject sphereSpawn;
    public GameObject cylinderSpawn;

    public GameObject BaseIZQ;
    public GameObject BaseDER;

    int altura;

    // Start is called before the first frame update
    void Start()
    {
        altura = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject clon;

        if (transform.position.x >= rectanguloMaxPosicionDerecha)
        {
            
            toRight = false;
            clon = Instantiate(sphereSpawn);
            clon.transform.position = BaseDER.transform.position + new Vector3 (0,altura,0);
            altura++;
        }

        else if (transform.position.x <= rectanguloMaxPosicionIzquierda)
        {
            
            toRight = true;
            clon = Instantiate(cylinderSpawn);
            clon.transform.position = BaseIZQ.transform.position + new Vector3(0, altura, 0);
            
        }


        if (toRight)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }

        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }

    }
}
