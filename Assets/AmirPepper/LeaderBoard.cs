using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LeaderBoard
{
    private List<LeaderBoardEntry> _p1LeaderboardEntry;
    private List<LeaderBoardEntry> _p2LeaderboardEntry;

    public LeaderBoard()
    {
        _p1LeaderboardEntry = new List<LeaderBoardEntry>();    
    }

    public void AddEntryP1(LeaderBoardEntry entry)
    {
        if (ExistsInP1LeaderBoard(entry))
        {
            int savedHighScore = PlayerPrefs.GetInt("SavedHighScore", 0);
           // Debug.Log(savedHighScore);
            if (entry.Score > savedHighScore)
            {
                PlayerPrefs.SetInt("SavedHighScore", entry.Score);
                    //add method to write text for the high score name
            }
            return;
        }
        else
        {
            _p1LeaderboardEntry.Add(entry);
           // PlayerPrefs.SetString("SavedHighScore", entry.name);
            PlayerPrefs.SetInt("SavedHighScore", entry.Score);

        }
    }

    private bool ExistsInP1LeaderBoard(LeaderBoardEntry entry)
    {
        foreach(var item in _p1LeaderboardEntry)
        {
            if(item.Name == entry.Name)
            {
                return true;
            }
        }
        return false;
    }
        public void AddEntryP2(LeaderBoardEntry entry)
    {
        if (ExistsInP2LeaderBoard(entry))
        {
            //update p1 topScore
        }
        else { return; }
    }

    private bool ExistsInP2LeaderBoard(LeaderBoardEntry entry)
    {
        foreach(var item in _p1LeaderboardEntry)
        {
            if(item.Name == entry.Name)
            {
                return true;
            }
        }
        return false;
    }


}
