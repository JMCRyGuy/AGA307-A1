using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Diffculty 
{ 
    easy,
    medium,
    hard
}





public class GameManager : Singleton<GameManager>
{
    public int score;
    public int enemiesRemaining;
    public Diffculty curDiffculty;

    void Start()
    {
        ChangeDifficulty(curDiffculty);
    }


    void Update()
    {
        enemiesRemaining = EnemyManger.instance.enemies.Count;
        UIManager.instance.remaningText.text = "Remaining: " + enemiesRemaining;
    }

    public void AddScore(int addpoints)
    {
        score += addpoints;
        UIManager.instance.scoreText.text = "Score: " + score;
        UIManager.instance.ScoreEffect();
    }


    public void ChangeDifficulty(Diffculty set)
    {
        curDiffculty = set;
        UIManager.instance.difficultyText.text = "Difficulty: " + curDiffculty;
    }
}
