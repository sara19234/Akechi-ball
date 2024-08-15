using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Makoto : MonoBehaviour
{
    public float timer;
    public static int score;
    public Text scoreText;
    int coinTotal;
    public static Makoto gm;
    public GameObject player;

    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        gm = this;
        coinTotal = GameObject.FindGameObjectsWithTag("Pancake").Length;
        score = 0;
        timer = 0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (score < coinTotal)
        {
            timer += Time.deltaTime;
            timerText.text = "Time:" + Mathf.Round(timer);
        }

        if (Input.GetKeyDown(KeyCode.R) || player.transform.position.y < -10f)
        {
            SceneManager.LoadScene(0);
        }


    }

    public void UpdateScore()
    {
        scoreText.text = "Pancakes:" + score + "/" + coinTotal;
    }
}
