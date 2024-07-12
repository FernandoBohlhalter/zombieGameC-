using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFPS : MonoBehaviour
{
    public float velocidade = 0.1f;
    // Start is called before the first frame update
    void Update()
    {
        Vector3 pos = transform.position;
        float moveHorizontal = Input.GetAxis("Horizontal"); // teclas direcionais h
        float moveVertical = Input.GetAxis("Vertical"); // teclas direcionais v
        pos.x += moveHorizontal * velocidade;
        pos.z += moveVertical * velocidade;
        transform.position = pos;

        
        /*if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * velocidade;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * velocidade;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * velocidade;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * velocidade;
        }*/
    }
}
