using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Src_MovimientoFondo : MonoBehaviour
{

    public float velocidad;
    public GameObject objDebajo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10)
        {
            transform.position = objDebajo.transform.position + new Vector3(0, 10, 0);
        }

        transform.position += new Vector3(0, velocidad * Time.deltaTime, 0);
    }
}
