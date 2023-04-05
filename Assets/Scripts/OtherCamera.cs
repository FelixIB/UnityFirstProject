using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCamera : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(0, 2.63f, 1f);
    private float turnSpeed = 45;
    private float horizontalInput;
    private Vector3 rotateValue;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        rotateValue = new Vector3(0, Time.deltaTime* horizontalInput * -1 * turnSpeed, 0);
        transform.position = Player.transform.position + offset;
        transform.eulerAngles = transform.eulerAngles - rotateValue;
    }
}
