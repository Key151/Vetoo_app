using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] private Timer timerComponent;
    [SerializeField] private NameUI nameUI;
    [SerializeField] private RoundController roundController;
    [SerializeField] private WordsController wordsController;
    [SerializeField] private UIControllerRun UIController;
    public void PlayGame()
    {
        SceneManager.LoadScene("Run");
    }

    public void Exit()
    {
        Debug.Log("APP fechou");
        Application.Quit();
    }

    public void  OnBackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnStartGame()
    {
        if (nameUI is not null)
        {
            nameUI.SetPlayerName();
            UIController.BackToStart();
        }
    }

    public void OnBack()
    {
        if (timerComponent is not null)
        {
            timerComponent.Finish();
        }
    }
    public void OnPlayRun()
    {
        timerComponent.PlayGame();
        UIController.ToPlay();
    }

    public void OnPlayTimer()
    {
        timerComponent.PlayTimer();
        UIController.ToReturn();
    }

    public void OnPauseClick()
    {
        if (timerComponent is not null)
        {
            timerComponent.Pause();
            UIController.ToPause();
        }
    }

    //public void OnActionClink()
    //{
    //    if (timerComponent is not null)
    //    {
    //        timerComponent.ClickFinish();
    //    }
    //}

    public void OnNextWord()
    {
        if (wordsController != null && timerComponent.State != enumState.Pause)
        {
            wordsController.NextCard();
        }
    }

    public void OnAcceptWord()
    {
        if ((wordsController != null) && (nameUI != null) && (timerComponent.State == enumState.Run))
        {
            nameUI.GetPoint();
            wordsController.NextCard();
        }
    }
}
