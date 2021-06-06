using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementalongx : MonoBehaviour
{
    public Rigidbody xaxis;
    int counter3 = 0;
    float max = -6.5f;
    float min = -26f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
        void Update()
        {


            if (xaxis.transform.position.x>= max)
            {
                xaxis.transform.position += new Vector3(-10 * Time.deltaTime, 0, 0);
                counter3 = 1;
            }
            if (xaxis.transform.position.x <= min)
            {

                xaxis.transform.position += new Vector3(10 * Time.deltaTime, 0, 0);
                counter3 = 0;
            }
            if (xaxis.transform.position.x < max && xaxis.transform.position.x > min)
            {

                if (counter3 == 1)
                {
                    xaxis.transform.position += new Vector3(-10 * Time.deltaTime, 0, 0);
                }
                else if (counter3 == 0)
                {
                    xaxis.transform.position += new Vector3(10 * Time.deltaTime, 0, 0);
                }
            }
        }
    }
