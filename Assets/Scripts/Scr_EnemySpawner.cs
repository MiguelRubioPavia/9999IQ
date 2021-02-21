using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float timer, tiempoEspera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= 0)
        {
            Instantiate(enemy, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
            timer = tiempoEspera;
        }

        timer -= Time.deltaTime;

    }
}
