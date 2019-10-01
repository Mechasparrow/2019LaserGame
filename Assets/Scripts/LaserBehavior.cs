using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehavior : MonoBehaviour
{

    public Vector2 offsetDir;
    public float mag;

    // Update is called once per frame
    void Update()
    {
        MoveLaser();
    }

    //Moves the laser by the direction
    void MoveLaser()
    {
        //update the position
        Vector3 laserPosition = transform.position;
        laserPosition += (Vector3)(offsetDir * mag * Time.deltaTime);
        transform.position = laserPosition;
    }
}
