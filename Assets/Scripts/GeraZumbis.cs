using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraZumbis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject ZumbiPrefab;
    // Update is called once per frame
    void Update()
    {
        if(Zumbi.NumZumbi < 4)
        {
            GameObject ZumbiClone = (GameObject)Instantiate(ZumbiPrefab,
                transform.position + new Vector3((float) Random.Range(-2,2), 0.5f, 0f), transform.rotation);
            print(Zumbi.NumZumbi);
        }
    }
}
