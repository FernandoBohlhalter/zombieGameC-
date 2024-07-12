using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparos : MonoBehaviour
{
    public GameObject balas;
    public AudioClip somBala;
    public float velocidadeBala = 300f;
    private float limVolBaixo = 0.5f;
    private float limVolAlto = 1.0f;
    private bool atirar = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            atirar = true;
            Debug.Log("Atirei");
        }
    }

    void FixedUpdate()
    {
        if(atirar)
        {
            float vol = Random.Range(limVolBaixo, limVolAlto);
            GetComponent<AudioSource>().PlayOneShot(somBala, vol);
            GameObject bala = (GameObject)Instantiate(balas, transform.position, transform.rotation);
            Vector3 direcaoDirejada = Camera.main.transform.forward; //Calcula direção desejada (Câmera-Player)
            bala.transform.forward = direcaoDirejada; //Alinha a direção frontal da bala com a Direção desejada
            bala.GetComponent<Rigidbody>().velocity = direcaoDirejada * velocidadeBala; // "Velocity" receve a direção*velocidadeBala
            Destroy(bala, 15.0f);
            atirar = false;
        }
    }
}
