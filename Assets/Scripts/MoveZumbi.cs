using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZumbi : MonoBehaviour
{
    Vector3 pos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    Vector3 novapos = new Vector3();
    // Update is called once per frame
    void Update()
    {
        novapos = Random.insideUnitCircle * 0.2f;
        pos.x += novapos.x;
        pos.z += novapos.z;
        transform.position = pos;
    }
}
