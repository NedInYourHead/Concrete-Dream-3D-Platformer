using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
    
    }

    public float sensitivity = 2.0f;
    public float speedMultiplier = 0.05f;
    
    float rotation = 0.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + ((transform.forward * speedMultiplier) * Input.GetAxis("Vertical"));
        rotation = rotation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation * sensitivity, 0));
    }
}
