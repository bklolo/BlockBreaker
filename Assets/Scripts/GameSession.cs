using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    // config paramaters
    [Range(0.1f, 10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 64;
    [SerializeField] bool isAutoPlayEnabled;

    //state vars
    [SerializeField] int currentScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    private void Start()
    {
        
    }
    void Update()
    {
        Time.timeScale = gameSpeed;
        scoreText.text = currentScore.ToString();
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}