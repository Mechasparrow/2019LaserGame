using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardBehavior : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("laser"))
        {
            Destroy(gameObject);
        }
    }

    
}
