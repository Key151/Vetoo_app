using UnityEngine;

public class RoundController : MonoBehaviour
{
    [SerializeField] private InputData inputData;
    [SerializeField] private UIControllerRun uIControllerRun;
    [SerializeField] private NameUI nameUI; 

    private int roundCurrent = 0;
    private bool inGame = true;

    public void Update()
    {
        if (roundCurrent < inputData.TakeRoundCount() && inGame) return;
        GameOver();
    }

    public void AddRound()
    {
        ++roundCurrent;
    }
    public void GameOver()
    {
        uIControllerRun.ToGameOver();
        nameUI.CheckWinner();
        inGame = false;
    }
}
