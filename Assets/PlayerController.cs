using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 0.05f;
    public float strafeSpeed = 1.0f;
    float rotation = 0.0f;
    float camRotation = 0.0f;
    public float rotationSpeed = 2.0f;
    float camRotationSpeed = 1.5f;
    GameObject cam;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    void Update()
    {
        transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed);
        transform.position = transform.position + (transform.right * Input.GetAxis("Horizontal") * strafeSpeed);

        rotation = rotation + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, -rotation, 0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(-camRotation, 0.0f, 0.0f));
    }
}
