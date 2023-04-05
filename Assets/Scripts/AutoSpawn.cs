using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawn : MonoBehaviour
{
    private float spawnTime = 4f;
    public GameObject Bus;
    public Vector3 Position=new Vector3(4,0,150);
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnBus", spawnTime, spawnTime);
        Object.Destroy(Bus, 5f);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnBus()
    {
        var newbus = GameObject.Instantiate(Bus,Position,Quaternion.Euler(0,180,0));
        newbus = null;
    }
}

