using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour
{
    public static int NumZumbi;
    public bool morte;
    public GameObject player;
    public float velocidade = 0.01f;
    private int vidaZumbi = 2;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Main Camera");
        NumZumbi++;
        print(NumZumbi);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcao = (player.transform.position - transform.position).normalized;
        float distancia = (player.transform.position - transform.position).magnitude;
        Vector3 move = transform.position + (direcao * velocidade) + Random.insideUnitSphere * 0.01f;;
        move.y = 1.0f;
        transform.position = move;

        if(distancia <= 1.2f){
            morte = true;
            NumZumbi--;
            Destroy(this.gameObject);
        }
        /*if (morte){
            NumZumbi--;
            Destroy(gameObject);
        }*/
    }

    void OnTriggerEnter(Collider outro){
        if(outro.gameObject.tag == "bala"){
            vidaZumbi --;
        }
        if (vidaZumbi == 0){
            morte = true;
            NumZumbi--;
            Destroy(this.gameObject);
        }
    }
}
