using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    private static Scorekeeper instance;

    public static Scorekeeper Instance
    {
        get { return instance; }
    }

    [SerializeField]
    private int pointsPerCoin = 10;
    [SerializeField]
    private int pointsPerCoin2 = 10;
  

    private int score = 0;
    private int score2 = 0;

    public int Score 
    {
        get { return score; }
    }
    public int Score2 
    {
        get { return score2; }
    }


    public void Start()
    {
        instance = this;
    }

    public void AddPointsForCoin()
    {
        score += pointsPerCoin; 
    }
    public void AddPointsForCoin2()
    {
        score2 += pointsPerCoin2;
    }
    
}
