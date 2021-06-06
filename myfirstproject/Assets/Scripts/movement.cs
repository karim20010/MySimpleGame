using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody move;
    int counter = 0;
    float max =49.44f;
    float min = 37.963f;
    bool f = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    { 
        

        if (move.transform.position.z >= max)
        {
            move.transform.position += new Vector3(0, 0, -10 * Time.deltaTime);
            counter = 1;
        }
        if (move.transform.position.z <= min)
        {
            
            move.transform.position += new Vector3(0, 0, 10 * Time.deltaTime);
            counter = 0;
        }
        if (move.transform.position.z < max && move.transform.position.z > min)
        {
            
            if (counter == 1)
            {
                move.transform.position += new Vector3(0, 0, -10 * Time.deltaTime);
            }
            else if (counter == 0)
            {
                move.transform.position += new Vector3(0, 0, 10 * Time.deltaTime);
            }
        }
    }
}

