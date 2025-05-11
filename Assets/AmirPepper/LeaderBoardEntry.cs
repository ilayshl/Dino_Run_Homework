using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[System.Serializable]
public class LeaderBoardEntry 
{
    public string Name;

    public int Score;

    public LeaderBoardEntry(string name, int score)
    {
        name = this.Name;
        score = this.Score;
        
    }
}
