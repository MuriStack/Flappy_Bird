using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score; // variável para armazenar pontuação

    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] GameObject gameOverPanel;

    [SerializeField] TextMeshProUGUI panelScoreText;

    [SerializeField] TextMeshProUGUI hScoreText;

    [SerializeField] Transform bird;

    public bool isDeath;

    void Start()
    {
        if (PlayerPrefs.HasKey("HScore")) 
        {
            hScoreText.text = PlayerPrefs.GetInt("HScore").ToString();
        }
    }


    void Update()
    {
        
    }
    public void SetScore(int amount) // função para contabilizar pontuação
    {
        if (isDeath) return;

        score += amount;
        scoreText.text = score.ToString();
    }

    public void ShowGameOver() 
    {
        isDeath = true;

        PipesMove[] pipesMoves = FindObjectsByType<PipesMove>(FindObjectsSortMode.None);

        foreach (PipesMove pipe in pipesMoves) 
        {
            pipe.enabled = false;
        }

        MoveObjects[] objects = FindObjectsByType<MoveObjects>(FindObjectsSortMode.None);

        foreach (MoveObjects obj in objects)
        {
            obj.enabled = false;
        }

        Spawner spawner = FindFirstObjectByType<Spawner>();

        if (spawner != null) 
        { 
            Destroy(spawner.gameObject); 
        }


        bird.rotation = Quaternion.Euler(0, 0, -90);

        gameOverPanel.SetActive(true);
        scoreText.gameObject.SetActive(false);

        panelScoreText.text = score.ToString();

        if (PlayerPrefs.GetInt("HScore") < score) 
        {
            PlayerPrefs.SetInt("HScore", score);
        }

        hScoreText.text = PlayerPrefs.GetInt("HScore").ToString();
    }

    public void RestartGame() 
    {
        SceneManager.LoadScene("Menu");
    }

}
