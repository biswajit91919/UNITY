using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector3.left * speed);
        }
        if(Input.GetKey("w"))
        {
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(Vector3.back * speed);
        }
    }
}
