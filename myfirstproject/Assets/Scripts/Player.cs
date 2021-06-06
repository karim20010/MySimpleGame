using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody a;
    public Rigidbody b;
    public float rightleftmove ;
    public float forwardbackwardmove;
    public float updown;
    public Collision z;
    public Rigidbody y;
    public Rigidbody t;
    public float speedofbodyfalling;
    bool o = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey("d"))
            {
                a.AddForce(rightleftmove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                a.AddForce(-rightleftmove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("w"))
            {
                a.AddForce(0, 0, forwardbackwardmove * Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey("x"))
            {
                a.AddForce(0, 0, -forwardbackwardmove * Time.deltaTime, ForceMode.VelocityChange);
            }
        if(z.g ==true)
        {
            y.useGravity = true;
            y.AddForce(0, -speedofbodyfalling * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (z.k == true)
        {
            t.useGravity = true;
            t.AddForce(0, -speedofbodyfalling * Time.deltaTime, 0, ForceMode.VelocityChange);
            if (o ==false)
            {
                Debug.Log("the jump key and return key are both enabled, use q to jump and use e to return down ");
                o= true;
            }
            if (Input.GetKey("q"))
            {
                b.AddForce(0, updown * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("e"))
            {
                b.AddForce(0, -updown * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }
        if(a.position.y<-1f)
        {
            FindObjectOfType<gameover>().EndGame();
        }   
    }
}
