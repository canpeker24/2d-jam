using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinController : MonoBehaviour
{

    public string winAreaTag = "WinArea";


    public string winSceneName = "YouWonScene";


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(winAreaTag))
        {

            WinGame();
        }
    }


    private void WinGame()
    {

        SceneManager.LoadScene(4);
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

