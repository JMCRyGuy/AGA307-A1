using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public Text scoreText, remaningText, difficultyText;
    public AudioSource scoreSound;
    public Animator animRef;


    public void ScoreEffect()
    {
        scoreSound.Play();
        animRef.SetTrigger("ScoreIncrease");

    }



}
