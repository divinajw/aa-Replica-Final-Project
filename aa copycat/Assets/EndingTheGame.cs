using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingTheGame : MonoBehaviour
{
    private bool gameEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;


    public void EndGame()
    {
        if (gameEnded)
            return;

        else
        {
            rotator.enabled = false;
            spawner.enabled = false;
            animator.SetTrigger("EndGame");
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
