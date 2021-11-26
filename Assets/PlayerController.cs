using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float forwardSpeed;
    public float normalSpeed = 0.01f;
    public float sprintSpeed = 0.02f;
    public float strafeSpeed = 0.006f;

    float rotation = 0.0f;
    float camRotation = 0.0f;
    public float rotationSpeed = 2.0f;
    float camRotationSpeed = 1.5f;
    GameObject cam;
    Rigidbody myRigidbody;

    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;
    public float jumpForce = 300.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
        
        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

        if (isOnGround && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(transform.up * jumpForce);
        }

        if (isOnGround && Input.GetKey(KeyCode.LeftShift))
        {
            forwardSpeed = sprintSpeed;
        }
        else
        {
            forwardSpeed = normalSpeed;
        }

        transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * forwardSpeed);
        transform.position = transform.position + (transform.right * Input.GetAxis("Horizontal") * strafeSpeed);

        rotation = rotation + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(-camRotation, 0.0f, 0.0f));
    }
}
