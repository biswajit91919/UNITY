using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float bounceforce;
    bool gamestarted;


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
        if (!gamestarted)
        {


            if (Input.anyKeyDown)
            {
                startbounce();
                gamestarted = true;
                gamemanager.instance.gamestart();

            }
        }
    }
    void startbounce()
    {
        Vector2 randomdirection = new Vector2(Random.Range(-1, 1), 1);


        rb.AddForce(randomdirection * bounceforce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "fallobject")
        {
            gamemanager.instance.Restart();
        }
        else if(collision.gameObject.tag == "paddleBlu")
        {
            gamemanager.instance.scoreup();
        }
    }



}
