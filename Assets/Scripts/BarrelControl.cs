using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelControl : MonoBehaviour
{

    //upper and lower bounds for movement
    public float upperBound;
    public float lowerBound;

    public AudioSource pew;

    //The laser
    public GameObject laserObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementHandling();

        if (shouldShoot())
        {
            Shoot();
        }
    }

    void MovementHandling()
    {

        float deltaY = (getInput() * 10) * Time.deltaTime;

        Vector3 position = transform.position;

        if (deltaY > 0 && position.y <= upperBound)
        {
            position.y += deltaY;
        }

        if (deltaY < 0 && position.y >= lowerBound)
        {
            position.y += deltaY;
        }


        transform.position = position;
    }

    //Check if barrel should shoot
    bool shouldShoot()
    {
        bool button = Input.GetKeyDown(KeyCode.Space);
        return button;
    }

    //handling shooting
    void Shoot()
    {
        //Debug
        Debug.Log("Shooting!");


        //Spawn the laser
        GameObject laser = Instantiate(laserObject);
        laser.SetActive(false);

        //Update position to the barrel
        Vector3 laserPosition = transform.position;
        laserPosition.z = laser.transform.position.z;
        laser.transform.position = laserPosition;

        laser.SetActive(true);

        pew.Play();

    }

    //Get Movement Input
    float getInput()
    {
        float vertical = Input.GetAxis("Vertical");
        return vertical;
    }


}
