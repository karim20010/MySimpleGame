using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using System.Collections;
using Random = UnityEngine.Random;

public class Collision : MonoBehaviour
{
    public Text text;
    public Rigidbody Option1;
    public bool k = false;
    public bool g = false;
    public BoxCollider option;
    public Rigidbody Option2;
    public BoxCollider option3;
    public Player n;
    public Transform P;
    GameObject[] lines;
    List<float> oldposition = new List<float>();
    bool isfalse = true;
    public int counter = 0;
    float score = 0;
    bool s = false;
    bool d = false;
    Rigidbody coin;
    CapsuleCollider c;
    int counter1 = 0;
    public Transform coins;
    float sum = 0;
    public Rigidbody m;
    bool f = false;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.collider.tag == "option2")
        {
            g = true;
            Option2.useGravity = true;
            option3.isTrigger = true;

        }
        if (collision.collider.tag == "option1")
        {
            k = true;
            Option1.useGravity = true;
            option.isTrigger = true;
        }
        if (collision.collider.tag == "wall13")
        {
            n.enabled = false;
            FindObjectOfType<gameover>().EndGame();

        }
        if(collision.collider.tag == "cube")
        {
            n.enabled = false;
            FindObjectOfType<gameover>().EndGame();
        }
        if (collision.collider.tag == "sphere")
        {
            n.enabled = false;
            FindObjectOfType<gameover>().EndGame();
        }
        if(collision.collider.tag == "firstblock")
        {
            n.enabled = false;
            FindObjectOfType<gameover>().EndGame();
        }
        if (collision.collider.tag == "firstblock")
        {
            n.enabled = false;
        }
        if (collision.collider.tag == "Second block")
        {
            n.enabled = false;
        }
        if (collision.collider.tag == "block1")
        {
            s = true;
        }
        if (d == false)
        {
            lines = GameObject.FindGameObjectsWithTag("block1");
            foreach (GameObject l in lines)
            {
                oldposition.Add(l.transform.position.z);
            }
            oldposition.Capacity = oldposition.Capacity - 1;
            d = true;
        }
        if (collision.collider.tag == "coin")
        {
            float t = 46 / 25;
            score = score + 20;
            sum = score;
            counter1 = counter1 + 1;
            collision.collider.isTrigger = true;
            collision.rigidbody.useGravity = true;
            int num = Random.Range(1, 3);
            if (counter1 % 7 == 0)
            {
                GameObject chest1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                if (num == 1)
                {
                    if (collision.collider.transform.position.x < 0 )
                    {
                        chest1.transform.localPosition = new Vector3(collision.collider.transform.position.x - 2, collision.collider.transform.position.y, collision.collider.transform.position.z + 1);
                        chest1.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                        chest1.GetComponent<MeshRenderer>().material.color = Color.red;
                        GameObject chest2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        chest2.transform.localPosition = new Vector3(collision.collider.transform.position.x - 2, collision.collider.transform.position.y, collision.collider.transform.position.z - 1);
                        chest2.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                        chest2.GetComponent<MeshRenderer>().material.color = Color.red;
                        chest1.AddComponent<Rigidbody>();
                        chest2.AddComponent<Rigidbody>();
                        chest1.tag = "magical cube";
                        chest2.tag = "magical cube1";
                    }
                    else if (collision.collider.transform.position.x > 0)
                    {
                        chest1.transform.localPosition = new Vector3(collision.collider.transform.position.x + 2, collision.collider.transform.position.y, collision.collider.transform.position.z + 1);
                        chest1.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                        chest1.GetComponent<MeshRenderer>().material.color = Color.red;
                        GameObject chest2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        chest2.transform.localPosition = new Vector3(collision.collider.transform.position.x + 2, collision.collider.transform.position.y, collision.collider.transform.position.z - 1);
                        chest2.transform.localScale = new Vector3(0.6f,0.6f, 0.6f);
                        chest2.GetComponent<MeshRenderer>().material.color = Color.red;
                        chest1.AddComponent<Rigidbody>();
                        chest2.AddComponent<Rigidbody>();
                        chest1.tag = "magical cube";
                        chest2.tag = "magical cube1";
                    }
                }
            

            else
            {
                if (collision.collider.transform.position.x < 0 )
                    {
                    chest1.transform.localPosition = new Vector3(collision.collider.transform.position.x - 2, collision.collider.transform.position.y, collision.collider.transform.position.z -1);
                    chest1.transform.localScale = new Vector3(0.6f, 0.6f,0.6f);
                    chest1.GetComponent<MeshRenderer>().material.color = Color.red;
                    GameObject chest2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    chest2.transform.localPosition = new Vector3(collision.collider.transform.position.x - 2, collision.collider.transform.position.y, collision.collider.transform.position.z + 1);
                    chest2.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                    chest2.GetComponent<MeshRenderer>().material.color = Color.red;
                    chest1.AddComponent<Rigidbody>();
                    chest2.AddComponent<Rigidbody>();
                    chest1.tag = "magical cube";
                    chest2.tag = "magical cube1";
                }
                else if (collision.collider.transform.position.x > 0 )
                {
                    chest1.transform.localPosition = new Vector3(collision.collider.transform.position.x + 2, collision.collider.transform.position.y, collision.collider.transform.position.z -1);
                    chest1.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                    chest1.GetComponent<MeshRenderer>().material.color = Color.red;
                    GameObject chest2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    chest2.transform.localPosition = new Vector3(collision.collider.transform.position.x + 2, collision.collider.transform.position.y, collision.collider.transform.position.z + 1);
                    chest2.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                    chest2.GetComponent<MeshRenderer>().material.color = Color.red;
                    chest1.AddComponent<Rigidbody>();
                    chest2.AddComponent<Rigidbody>();
                    chest1.tag = "magical cube";
                    chest2.tag = "magical cube1";
                }
            }
            }

        }
        if (collision.collider.tag == "magical cube")
        {
            Debug.Log("ohhhhhhh");
            score = score + 50;
            sum = score;
            GameObject H = GameObject.FindGameObjectWithTag("magical cube");
            H.GetComponent<BoxCollider>().isTrigger = true;
            GameObject E = GameObject.FindGameObjectWithTag("magical cube1");
            E.GetComponent<BoxCollider>().isTrigger = true;

        }
        if (collision.collider.tag == "magical cube1")
        {
            Debug.Log("oh no i lost all my coins");
            score = 0;
            sum = score;
            GameObject H = GameObject.FindGameObjectWithTag("magical cube");
            H.GetComponent<BoxCollider>().isTrigger = true;
            GameObject E = GameObject.FindGameObjectWithTag("magical cube1");
            E.GetComponent<BoxCollider>().isTrigger = true;
        }
    }
    private void Update()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
        text.text = score.ToString("0");
        if(g == true)
        {
            if (m.position.z > 97)
            {
                if(f == false)
                {
                    sum = sum + 200;
                    score = sum;
                    f = true;
                }
            }
        }
        if (isfalse == false)
            {
                score = 0;
                isfalse = true;
            }
            if (s == true)
            {
                lines = GameObject.FindGameObjectsWithTag("block1");
                int j = 0;
                if (lines.Length > 0 || oldposition.Capacity == 0)
                {
                    foreach (GameObject l in lines)
                    {
                        if (l.transform.position.z != oldposition[j])
                        {
                            float difference = Math.Abs(oldposition[j] - l.transform.position.z);
                            if (difference > 0.1)
                            {
                                counter = counter + 1;
                                l.tag = "block2";
                                oldposition.RemoveAt(j);
                            }
                            else
                            {
                                j = j + 1;
                            }
                        }
                        else
                        {
                            j = j + 1;
                        }

                    }
                    if (counter == 7)
                    {
                        Debug.Log("you hit them all, Well Done");
                        score = counter * 20 + sum;
                        text.text = score.ToString("0");
                    }
                    else if (counter >= 0)
                    {
                        if (counter != 0)
                        {
                            Debug.Log("you hit some of them , Well Done");
                            score = counter * 20 + sum;
                            text.text = score.ToString("0");
                        }
                        else
                        {
                            Debug.Log("no luck today");
                        }
                    }

                }
            }
        }
}

