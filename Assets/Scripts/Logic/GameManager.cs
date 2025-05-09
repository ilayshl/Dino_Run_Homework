using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool waitingForInput = false;

    public static GameManager Instance;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
    }

    void Start()
    {
        ChangeGameState();
    }

    private void ChangeGameState(GameState newState = GameState.InputCountdown)
    {
        switch (newState)
        {
            case GameState.InputCountdown:

                break;
            case GameState.WaitingForInput:

                break;
            case GameState.RoundPlays:

                break;
            case GameState.RoundWinP1:

                break;
            case GameState.RunEnd:

                break;
        }
    }

    private IEnumerator InputCountdown(int seconds, float multiplier)
    {
        waitingForInput = true;
        while (seconds > 0)
        {
            Debug.Log(seconds);
            yield return new WaitForSeconds(1 / multiplier);
            seconds--;
        }
        waitingForInput = false;
        Debug.Log("Finished countdown!");
    }

    private IEnumerator CheckForInput()
    {
        while (waitingForInput)
        {
            CheckForInputP1();
            CheckForInputP2();
            yield return null;
        }
    }

    private void CheckForInputP1()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Q
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //W
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //E
        }
    }

    private void CheckForInputP2()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //I
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            //O
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            //P
        }
    }
}
