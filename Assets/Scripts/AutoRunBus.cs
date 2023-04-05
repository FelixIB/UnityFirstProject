using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRunBus : MonoBehaviour
{
    private float speed ;
    // Start is called before the first frame update
    void Start()
    {
       
        speed = Random.Range(30, 40);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    
}