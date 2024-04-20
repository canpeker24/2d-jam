using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float timeLimit = 60f; 
    private bool gameOver = false; 
    private float timer = 0f; 

    void Update()
    {
        
        if (!gameOver)
        {
            timer += Time.deltaTime;
            if (timer >= timeLimit)
            {
                EndGame();
            }
        }
    }

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            EndGame();
        }
    }

    
    void EndGame()
    {
        gameOver = true;
        
        SceneManager.LoadScene(3);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene(0);
    }


}

