using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Enemy : MonoBehaviour
{

    public float velocidadRot;
    public float velocidadBajada;
    public GameObject enemy;

    public int vida;
    public int randomScale;

    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0, 2) == 0)
        {
            randomScale = 1;
        }
        else
        {
            randomScale = -1;
        }
        transform.localScale = new Vector3(randomScale, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        enemy.transform.Rotate(0, 0, velocidadRot * Time.deltaTime);
        transform.position += new Vector3(0, velocidadBajada * Time.deltaTime, 0);

        if(vida <= 0)
        {
            GameObject.Find("Player").GetComponent<Scr_Player>().puntos += 1;
            Destroy(gameObject);
        }

    }
}
