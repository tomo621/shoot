using UnityEngine;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverUI;

    private bool isGameOver = false;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    void Start()
    {
        // ゲーム開始時にゲームオーバー画面を非表示
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(false);
        }
    }

    public void AddScore(int amount)
    {
        if (isGameOver) return;

        score += amount;
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true); 
        }
    }

    void Update()
    {
        // ゲームオーバー中にRキーを押したらリトライ
        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}