using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    bool gamehasend = false;
    public float f = 1f;
    public GameObject completeLevelUI;
    public void EndGame()
    {
        if (gamehasend == false)
        {
            gamehasend = true;
            Debug.Log("Game over");
            Invoke("Restart", f);
        }
    }
    void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    public void Completelevel()
    {
        completeLevelUI.SetActive(true);
    }
    }
