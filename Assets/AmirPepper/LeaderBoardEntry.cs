using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[System.Serializable]
public class LeaderBoardEntry : MonoBehaviour
{
    public string Name;

    public int Score;

    public LeaderBoardEntry(string name, int score)
    {
        name = Name;
        score = Score;
        
    }
}
