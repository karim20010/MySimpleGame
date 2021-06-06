using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gameover Gamemanager;
    private void OnTriggerEnter(Collider other)
    {
        Gamemanager.Completelevel();
    }
}
