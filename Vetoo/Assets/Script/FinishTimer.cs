using UnityEngine;

public class FinishTimer : MonoBehaviour
{
    [SerializeField] private UIControllerRun UIControllerRun;
    [SerializeField] private RoundController roundController;
    [SerializeField] private NameUI nameUI;
    [SerializeField] private WordsController wordsController;

    public void End()
    {
        wordsController.NextCard();
        roundController.AddRound();
        UIControllerRun.ChangeHud(nameUI.ChangeTurnName());
        UIControllerRun.BackToStart();
    }
}