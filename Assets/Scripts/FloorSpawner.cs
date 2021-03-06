using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    //we should add all new floors to the edge of last added floor
    public GameObject lastFloor;
    
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            createFloor();
        }
    }

    
    void Update()
    {
       
    }

    public void createFloor()
    {
        Vector3 direction;

        //creating random direction
        if(Random.Range(0,2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }

        lastFloor = Instantiate(lastFloor, lastFloor.transform.position + direction, lastFloor.transform.rotation);
    }
}
