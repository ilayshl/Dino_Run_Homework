using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int playerOneInput, playerTwoInput = 1;
    private Coroutine activeCoroutine;
    private const float STARTING_COUNTDOWN = 3;

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
                activeCoroutine = StartCoroutine(InputCountdown(STARTING_COUNTDOWN));
                break;
            case GameState.WaitingForInput:
                ResetInputs();
                activeCoroutine = StartCoroutine(CheckForInput(3));
                break;
            case GameState.RoundPlays:
                CalculateRound();
                break;
            case GameState.RoundWinP1:
                P1Wins();
                ChangeGameState();
                break;
            case GameState.RunEnd:
                P2Wins();
                ChangeGameState();
                break;
        }
    }

    private IEnumerator InputCountdown(float seconds, float multiplier = 1)
    {
        while (seconds > 0)
        {
            Debug.Log(seconds);
            yield return new WaitForSeconds(1 / multiplier);
            seconds--;
        }
        Debug.Log("Finished countdown!");
        ChangeGameState(GameState.WaitingForInput);
    }

    private IEnumerator CheckForInput(float seconds, float multiplier = 1)
    {
        float timePassed = 0;
        Debug.Log("Waiting for input...");
        while (timePassed < seconds)
        {
            CheckForInputP1();
            CheckForInputP2();
            timePassed += Time.deltaTime;
            yield return null;
        }
        Debug.Log("Stopped checking for input.");
        ChangeGameState(GameState.RoundPlays);
    }

    private void CheckForInputP1()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerOneInput = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerOneInput = 1;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerOneInput = 2;
        }
    }

    private void CheckForInputP2()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            playerTwoInput = 0;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            playerTwoInput = 1;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            playerTwoInput = 2;
        }
    }

    private void CalculateRound()
    {
        Debug.Log("Calculating round.");
        Debug.Log($"P1: {playerOneInput} | P2: {playerTwoInput}");
        if (playerOneInput == playerTwoInput)
        {
            Debug.Log("P1 lost!");
            ChangeGameState(GameState.RunEnd);
        }
        else
        {
            Debug.Log("P1 keeps running!");
            ChangeGameState();
        }
    }

    private void ResetInputs()
    {
        playerOneInput = 1;
        playerTwoInput = 1;
        Debug.Log("Reset inputs to Middle.");
    }

    private void P1Wins()
    {
        Debug.Log("P1 Wins!");
    }

    private void P2Wins()
    {
        Debug.Log("P2 Wins!");
    }
}
