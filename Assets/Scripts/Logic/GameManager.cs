using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float difficultyMult { get; private set;} = 0;
    private Coroutine increaseDifficultyTimer;

    public void StartGame()
    {
        increaseDifficultyTimer = StartCoroutine(IncreaseDifficulyTimer());
    }

    public void StopGame()
    {
        if(increaseDifficultyTimer != null)
        {
        StopCoroutine(increaseDifficultyTimer);
        }
        else
        {
            Debug.LogWarning("No Difficulty Timer coroutine active!");
        }
    }

    private IEnumerator IncreaseDifficulyTimer()
    {
        while(true)
        {
            difficultyMult += Time.deltaTime;
            yield return null;
        }
    }

}
