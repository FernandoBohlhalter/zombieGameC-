using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlvoFPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float mouseX;
    float mouseY;
    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");
        //Debug.Log(mouseX);
        //Debug.Log(mouseY);
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0f);
    }
}
