using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private int tempo;

    [Header("Componentes")]
    [SerializeField] private TMP_Text textoTempo;
    [SerializeField] private Animator animatorTexto;
    [SerializeField] private GameObject timer;
    [SerializeField] private FinishTimer finishTimer;

    private enumState state = enumState.Start;
    public enumState State
    {
        get { return state; }
    }
    private int tempoAnterior = 5;
    private float tempoFloat = 0f;

    void Update()
    {
        if (state != enumState.Run) return;

        tempoFloat += Time.deltaTime;
        int tempoReal = tempo - Mathf.FloorToInt(tempoFloat);
        textoTempo.text = (tempoReal).ToString();

        if (tempoReal != tempoAnterior){
            animatorTexto.SetTrigger("Mudar");
            tempoAnterior = tempoReal;
        }

        if (tempoReal <= 0f) Finish();
    }

    public void PlayGame()
    {
        state = enumState.Run;
    }

    public void PlayTimer()
    {
        animatorTexto.speed = 1f;
        state = enumState.Run;
    }   

    public void Pause()
    {
        animatorTexto.speed = 0f;
        state = enumState.Pause;
    }

    public void Finish()
    {
        Debug.Log($"Tempo que passou {tempoFloat:F2}");
        tempoFloat = 0f;
        tempoAnterior = 5;
        state = enumState.Start;
        finishTimer.End();
    }
}