using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField] private Text scoreText2;
    
    [SerializeField]
    private string scoreFormat = "Score: {0}";
    [SerializeField]
    private string scoreFormat2 = "Player2 Score: {0}";


    private Scorekeeper scorekeeper;
    

    void Start()
    {
        scorekeeper = FindObjectOfType<Scorekeeper>();
       
    }


    void Update()
    {
        int score = scorekeeper.Score;
        int score2 = scorekeeper.Score2;
        scoreText.text = string.Format(scoreFormat, score);
        scoreText2.text = string.Format(scoreFormat2, score2);
    }
}
