using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    void Awake()
    {
            if(Instance != null && Instance != this)
            {
                Destroy(Instance);
            }
    }

    void Start()
    {
        ChangeGameState();
    }

    private void ChangeGameState(GameState newState = GameState.RoundPlays)
    {
        switch(newState)
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
}
