using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Camera1"))
        {
            Cam1.SetActive(true);
            Cam2.SetActive(false);
        }
       if(Input.GetButtonDown("Camera2"))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(true);
        }
    }
}
