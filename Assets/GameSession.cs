using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour {

    int pointsPerBlockDestroy = 5;
    [SerializeField] int currentScore = 0;
    [SerializeField] Text scoreText;
    [SerializeField] bool isAutoPlayEnabled;

    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;


    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update() {

        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroy;
        scoreText.text = currentScore.ToString();
    }

    public void ReloadPoints()
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled()
    {
        return isActiveAndEnabled;
    }
}
