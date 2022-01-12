using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject enemi;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<25; i++){
            Vector3 pos = new Vector3(Random.Range(0,5000), 242 ,  Random.Range(0,5000));
            Instantiate(enemi , pos, Quaternion.identity);  
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
