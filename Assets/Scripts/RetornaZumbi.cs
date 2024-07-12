using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetornaZumbi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Zumbi alvo = PegaZumbi();
        if (alvo != null)
        {
            Debug.DrawLine(transform.position, PegaZumbi().transform.position);
        }    
    }
    Zumbi PegaZumbi()
    {
        return(Zumbi)GameObject.FindObjectOfType(typeof(Zumbi));
    }
}
