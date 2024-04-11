using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using static System.Net.Mime.MediaTypeNames;

public class GameManager : MonoBehaviour
{

    // This script will handle the game's state

    public static GameManager Instance { get; private set; }

    [SerializeField]
    private PlayerController player;
    [SerializeField]
    private PlayerHealthController playerHealthController;
    [SerializeField]
    private GameObject playerWonText;
    [SerializeField]
    private GameObject playerLostText;
    [SerializeField]
    private int playerWinPoints = 10;

    private bool playerWon = false;
    private bool playerDead = false;
    public Text playerHealth;
    public Text playerScoreText;

    private int playerPoints = 0;

    private void Awake()
    {
       if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(Instance);
    }

    // Start is called before the first frame update
    private void Start()
    {
        playerWon = false;
        playerDead = false;
        playerPoints = 0;
        UpdateUI();
    }

    // Update is called once per frame
    private void Update()
    {
        playerPoints = playerHealthController.GetScore();

        if (playerHealthController.GetHealth() <= 0)
        {
            playerDead = true;
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        if (playerPoints >= playerWinPoints)
        {
            playerWon = true;
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        playerScoreText.text = playerHealthController.GetScore().ToString();

        playerScoreText.GetComponent<Text>().text = $"{playerPoints}/{playerWinPoints}";
        playerHealth.text = playerHealthController.GetHealth().ToString();

        //UnityEngine.Debug.Log(playerPoints + "and " + playerWinPoints);

        if (playerWon)
        {
            Time.timeScale = 0;
            playerWonText.SetActive(true);
        }
        else
        {
            playerWonText.SetActive(false);
        }

        if (playerDead)
        {
            Time.timeScale = 0;
            playerLostText.SetActive(true);
        }
        else {
            playerLostText.SetActive(false) ;
        }
    }

    public void SetPlayerPoints(int points)
    {
        playerPoints += points;
    }

    public void SetPlayerWon(bool won)
    {
        playerWon = won;
    }

    public bool GetPlayerDead()
    {
        return playerDead;
    }

    public bool GetPlayerWon()
    {
        return playerWon;
    }
}
