using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    private LeaderBoardEntry _entryP1;
    private LeaderBoard _leaderboard;

    private TextMesh _p1CurrentScoreDisplay;

    private int _p1CurrentScore = 1;
    private string _p1Name;
   
    // public int p2currentScore;

    private void Awake()
    {
        //_leaderboard = GetComponent<LeaderBoard>();
        _leaderboard = new LeaderBoard();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            AddToP1CurrentScore();
        }
    }
    public void AddToP1CurrentScore() //adds to p1 score, and compares if it outranks the saved top score, and resets it if found true.
    {
        _p1CurrentScore++;
        _entryP1.Score = _p1CurrentScore;
        _entryP1.Name = "Shaked";
      //  _entryP1.Name = 
            //input here a prompt allowing winning player to place his name if he is the high score holder.

        _leaderboard.AddEntryP1(_entryP1);     
    }
    private void UpdatePlayer1Score()
    {

    }
    
}
