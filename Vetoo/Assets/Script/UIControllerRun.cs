using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class UIControllerRun : MonoBehaviour
{
    [Header("Telas")]
    [SerializeField] private GameObject telaStart;
    [SerializeField] private GameObject telaRun;
    [SerializeField] private GameObject telaSetup;
    [SerializeField] private GameObject telaGameOver;

    [Header("Objects")]
    [SerializeField] private GameObject buttonOK;
    [SerializeField] private GameObject buttonReturn;
    [SerializeField] private GameObject time;
    [SerializeField] private GameObject quests;
    [SerializeField] private GameObject hudPlayer;

    private Dictionary<TurnPlayer, Color> playerColors = new Dictionary<TurnPlayer, Color>
    {
        { TurnPlayer.player1, new Color32(254, 122, 0, 255) }, // Laranja
        { TurnPlayer.player2, new Color32(152, 254, 0, 255) }  // Verde
    };

    public void Start()
    {
        ToSetup();
    }

    private void HudControl(bool condition)
    {
        if (hudPlayer is not null) hudPlayer.SetActive(condition);
        if (telaRun is not null) time.SetActive(condition);
        if (quests is not null) quests.SetActive(condition);
    }

    public void ToSetup()
    {
        if (telaStart is not null) telaSetup.SetActive(true);
        if (telaStart is not null) telaStart.SetActive(false);
        if (telaRun is not null) telaRun.SetActive(false);
        if (telaGameOver is not null) telaGameOver.SetActive(false);
        HudControl(false);
    }

    public void ToPlay()
    {
        if (telaStart is not null) telaStart.SetActive(false);
        if (telaRun is not null) telaRun.SetActive(true);
        HudControl(true);
    }

    public void BackToStart()
    {
        if (telaSetup is not null) telaSetup.SetActive(false);
        if (telaStart is not null) telaStart.SetActive(true);
        if (telaRun is not null) telaRun.SetActive(false);
        if (hudPlayer is not null) hudPlayer.SetActive(true);
        if (telaRun is not null) time.SetActive(false);
        if (quests is not null) quests.SetActive(false);
    }

    public void ToPause()
    {
        if (buttonOK is not null) buttonOK.SetActive(false);
        if (buttonReturn is not null) buttonReturn.SetActive(true);
    }

    public void ToReturn()
    {
        if (buttonOK is not null) buttonOK.SetActive(true);
        if (buttonReturn is not null) buttonReturn.SetActive(false);
    }

    public void ToGameOver()
    {
        if (telaGameOver is not null) telaGameOver.SetActive(true);
        if (telaRun is not null) telaRun.SetActive(false);
        HudControl(false);
    }
    public void ChangeHud(TurnPlayer player)
    {
        if (hudPlayer is not null) hudPlayer.GetComponent<Image>().color = playerColors[player];
    }
}