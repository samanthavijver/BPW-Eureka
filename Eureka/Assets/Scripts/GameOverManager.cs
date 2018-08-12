using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;       // Reference to the player's health.
    public GameObject FadeToBlack;          // Reference to the Fade to black Prefab that exits the game
    public Animator GameOverCanvas;

    Animator exit;                          // Reference to the animator component.
    Animator anim;

    public int time;
    Text text;
    public float timer;


    void Awake()
    {
        // Set up the reference.
        anim = GameOverCanvas.GetComponent<Animator>();
        exit = FadeToBlack.GetComponent<Animator>();
        timer = time;
        text = GetComponent<Text>();
    }


    void Update()
    {
        timer -= Time.deltaTime;
        text.text = "Time: " + timer.ToString("f");

        // If the player has run out of health...
        if (playerHealth.currentHealth <= 0)
        {
            GameOver();
        }

        if (timer <= 0.0f)
        {
            GameOver();
        }


    }

    public void GameOver()
    {
        Time.timeScale = 0;
        // ... tell the animator the game is over.
        anim.SetTrigger("GameOver");


        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exit.SetTrigger("Fade");
        }
    }

}