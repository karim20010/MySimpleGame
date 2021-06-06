using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{
    public Rigidbody sphere;
    float min = 63f;
    float max = 101.48f;
    int counter2 = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sphere.transform.position.z >= max)
        {
            sphere.transform.position += new Vector3(0, 0, -10 * Time.deltaTime);
            counter2 = 1;
        }
        if (sphere.transform.position.z<= min)
        {
            sphere.transform.position += new Vector3(0, 0, 10 * Time.deltaTime);
            counter2 = 0;
        }
        if (sphere.transform.position.z < max && sphere.transform.position.z > min)
        {
            if (counter2 == 1)
            {
                sphere.transform.position += new Vector3(0, 0, -15 * Time.deltaTime);
            }
            else if (counter2 == 0)
            {
                sphere.transform.position += new Vector3(0, 0, 15 * Time.deltaTime);
            }
        }
    }
}
