using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public Transform ball;
    public float smoothspeed = 0.125f;
    public Vector3 offset;
    private void LateUpdate()
    {
   transform.position = ball.position + offset;
       




    }














    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
