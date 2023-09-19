using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    Rigidbody2D rb;
    public float movespeed;




    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Touchmove();
    }



    void Touchmove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(touchPos.x > 0)
            {
                //move left
                rb.velocity = Vector2.right * movespeed;
              
            }
            else 
            {
                //move right
                rb.velocity = Vector2.left * movespeed;
            }

        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }


}
