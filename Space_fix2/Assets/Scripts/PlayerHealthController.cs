using System.Diagnostics;
using UnityEngine;


public class PlayerHealthController : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public static int currentScore;
    //Collision2D col;
   // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //UnityEngine.Debug.Log("score: " + currentScore);

        if (currentHealth <= 0)           
        {
            //UnityEngine.Debug.Log("YOU DIED");
        }
    }

    void OnTriggerEnter2D()
    {
        currentHealth--;
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    public int AddScore()
    {
        currentScore++;
        return currentScore;
    }

    public int GetScore()
    {
        return currentScore;
    }


}
