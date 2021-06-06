using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public Rigidbody traps;
    int counter1 = 0;
    float max = 1f ;
    float min = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (traps.transform.position.y >= max)
        {
            traps.transform.position += new Vector3(0, -15 * Time.deltaTime, 0);
            counter1 = 1;
        }
        if (traps.transform.position.y<= min)
        {
            traps.transform.position += new Vector3(0, 15 * Time.deltaTime, 0);
            counter1 = 0;
        }
        if (traps.transform.position.y< max && traps.transform.position.y > min)
        {
            if (counter1 == 1)
            {
                traps.transform.position += new Vector3(0, -15 * Time.deltaTime, 0);
            }
            else if (counter1 == 0)
            {
                traps.transform.position += new Vector3(0, 15 * Time.deltaTime, 0);
            }
        }
    }
}
