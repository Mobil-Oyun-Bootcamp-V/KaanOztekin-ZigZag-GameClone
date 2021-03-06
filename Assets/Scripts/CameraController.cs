using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //first we are going to assign our camera location to ball's location.
    public Transform locationBall;
    Vector3 distance;



    void Start()
    {
        //when game starts we calculate the difference the distance between ball and camera
        distance = transform.position - locationBall.position;
    }

    
    void Update()
    {
        if (!PlayerController.isFalling)
        {
            //now our camera is going to follow the new vector3 distance
            transform.position = locationBall.position + distance;
        }


    }
}
