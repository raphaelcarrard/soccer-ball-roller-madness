using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    public GameObject player;
    public enum gameStates {Playing, Death, GameOver, BeatLevel};
    public gameStates gameState = gameStates.Playing;
    public int score = 0;
    public bool canBeatLevel = false;
    public int beatLevelScore = 0;
    public GameObject mainCanvas;
    public GameObject coinsSpawner, enemySpawner;
    public Text mainScoreDisplay;
    public GameObject gameOverCanvas;
    public Text gameOverScoreDisplay;
    public GameObject beatLevelCanvas;
    public AudioSource backgroundMusic;
    public AudioClip gameOverSFX;
    public AudioClip beatLevelSFX;
    private Health playerHealth;
    public bool isPaused;

    void Start()
    {
        if (instance == null)
        {
            instance = gameObject.GetComponent<GameManager>();
        }
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        playerHealth = player.GetComponent<Health>();
        Collect(0);
        gameOverCanvas.SetActive(false);
        if (canBeatLevel)
        {
            beatLevelCanvas.SetActive(false);
        }
    }

    
    void Update()
    {
        switch (gameState) {
            case gameStates.Playing:
                if (Input.GetKeyDown(KeyCode.P))
                {
                    if (!isPaused)
                    {
                        isPaused = true;
                        Time.timeScale = 0f;
                    }
                    else
                    {
                        isPaused = false;
                        Time.timeScale = 1f;
                    }
                }
                if (playerHealth.isAlive == false)
                {
                    gameState = gameStates.Death;
                    gameOverScoreDisplay.text = mainScoreDisplay.text;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
		            coinsSpawner.SetActive(false);
		            enemySpawner.SetActive(false);
                }
                else if (canBeatLevel && score >= beatLevelScore)
                {
                    gameState = gameStates.BeatLevel;
                    player.SetActive(false);
                    mainCanvas.SetActive(false);
                    beatLevelCanvas.SetActive(true);
		            coinsSpawner.SetActive(false);
		            enemySpawner.SetActive(false);
                    Debug.Log("You Win!");
                }
                if (score > PlayerPrefs.GetInt("HighScore"))
                {
                    PlayerPrefs.SetInt("HighScore", score);
                }
                break;
            case gameStates.Death:
                backgroundMusic.volume -= 0.01f;
                if (backgroundMusic.volume <= 0.0f)
                {
                    AudioSource.PlayClipAtPoint(gameOverSFX, gameObject.transform.position);
                    gameState = gameStates.GameOver;
                }
                break;
            case gameStates.BeatLevel:
                backgroundMusic.volume -= 0.01f;
                if (backgroundMusic.volume <= 0.0f)
                {
                    AudioSource.PlayClipAtPoint(beatLevelSFX, gameObject.transform.position);
                    gameState = gameStates.GameOver;
                }
                break;
            case gameStates.GameOver:
                break;
        }
    }

    public void Collect(int amount)
    {
        score += amount;
        if (canBeatLevel)
        {
            mainScoreDisplay.text = score.ToString() + " of " + beatLevelScore.ToString();
        }
        else
        {
            mainScoreDisplay.text = score.ToString();
        }
    }
}
