using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public int lives = 3;
    public TextMeshProUGUI scoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        HealthText.text = $"Lives: {lives}";
        scoreText.text = $"Score: {score}";
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 5)
        {

        }
    }

    public void TakeDamage()
    {
        lives--;
        HealthText.text = $"Lives: {lives}";

        if (lives == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        SceneManager.LoadScene("game");
    }
    public void CollectCoin()
    {
        score ++;
        scoreText.text = $"Score: {score}";
    }
    public void CollectKey()
    {
        SceneManager.LoadScene("Win");
    }

    //public void CollectPowerup()
    
}
