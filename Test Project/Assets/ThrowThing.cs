using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowThing : MonoBehaviour
{

    public Rigidbody projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e")) {

            Instantiate(projectile, transform.position, transform.rotation);

            // Rigidbody clone;
            // clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;

            // clone.AddForce(100, 100, 100);

            // Debug.Log(clone.transform.position);
        }
    }
}
