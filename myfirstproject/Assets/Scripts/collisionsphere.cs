using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionsphere : MonoBehaviour
{
    public Player g;
    public Rigidbody v;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.tag == "cube")
        {
            g.enabled = false;
            FindObjectOfType<gameover>().EndGame();
        }
        if(collision.collider.tag == "sphere")
        {
            g.enabled = false;
            FindObjectOfType<gameover>().EndGame();
        }  
    }
}
