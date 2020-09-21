using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{

    public Rigidbody rb;

    public int launchForce = 6000;

    public int launchHeight = 1000;


    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(transform.forward * launchForce + new Vector3(0, launchHeight, 0));
        Debug.Log("launch");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
