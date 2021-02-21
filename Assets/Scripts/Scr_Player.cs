using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scr_Player : MonoBehaviour
{

    public Vector3 movimiento;
    public float velocidad;
    public GameObject bala;
    public float timer, tiempoDeEspera;
    public int puntos;
    public Text puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        movimiento = movimiento.normalized;
        transform.position += movimiento * velocidad * Time.deltaTime;

        if (Input.GetKey("space") && timer <= 0)
        {
            Instantiate(bala, transform.position, Quaternion.Euler(0, 0, 90));
            timer = tiempoDeEspera;
        }

        timer -= Time.deltaTime;

        puntuacion.text = puntos.ToString("");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Enemy")
        {
            SceneManager.LoadScene("Juego");
        }
    }

}
