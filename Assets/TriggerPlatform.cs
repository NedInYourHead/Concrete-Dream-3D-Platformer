using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{
    public Transform myPlatform;
    public Transform myStartPoint;
    public Transform myEndPoint;

    public float speed = 0.1f;

    public bool isActive = false;
    void Start()
    {
        myPlatform.position = myStartPoint.position;
    }


    // Update is called once per frame
    void Update()
    {
        if (isActive == true)
        {
            myPlatform.position = Vector3.MoveTowards(myPlatform.position, myEndPoint.position, speed);

            if (myPlatform.position == myEndPoint.position)
            {

                isActive = false;
            }
        }
        else
        {
            myPlatform.position = Vector3.MoveTowards(myPlatform.position, myStartPoint.position, speed);
        }
    }
}
