using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameUI : MonoBehaviour
{
    [SerializeField] private CreatePlayer playerData;
    [SerializeField] private InputData inputData;

    [Header("UI")]
    [SerializeField] private TMP_Text textoNomeUI;
    [SerializeField] private TMP_Text textoPoint;
    [SerializeField] private TMP_Text textWinnerName;
    [SerializeField] private Timer timeCheck;

    private List<TurnPlayer> TurnActual = new List<TurnPlayer>
    {
        TurnPlayer.player1,
        TurnPlayer.player2
    };

    public void SetPlayerName()
    {
        playerData.player1.PlayerName = inputData.TakePlayer1Name();
        playerData.player2.PlayerName = inputData.TakePlayer2Name();
        AtualizarDados(playerData.player1);
    }

    public void AtualizarDados(PlayerData player)
    {
        textoNomeUI.text = player.PlayerName;
        textoPoint.text = player.PlayerHit.ToString();
    }

    public TurnPlayer ChangeTurnName()
    {
        //Troca de turno do jogador
        TurnPlayer primeiro = TurnActual[0];
        TurnActual.RemoveAt(0);
        TurnActual.Add(primeiro);

        Debug.Log($"Time Atual ver 2: {TurnActual[0]}");

        //Atualiza o nome do jogador na UI
        switch (TurnActual[0])
        {
            case TurnPlayer.player1:
                AtualizarDados(playerData.player1);
                break;

            case TurnPlayer.player2:
                AtualizarDados(playerData.player2);
                break;
        }
        return TurnActual[0];
    }
    public void GetPoint()
    {
        switch (TurnActual[0])
        {
            case TurnPlayer.player1:
                playerData.player1.AddHit();
                textoPoint.text = playerData.player1.PlayerHit.ToString();
                break;

            case TurnPlayer.player2:
                playerData.player2.AddHit();
                textoPoint.text = playerData.player2.PlayerHit.ToString();
                break;
        }
    }

    public void CheckWinner()
    {
        if (playerData.player1.PlayerHit > playerData.player2.PlayerHit)
        {
            textWinnerName.text = playerData.player1.PlayerName;
        }

        else if (playerData.player2.PlayerHit > playerData.player1.PlayerHit)
        {
            textWinnerName.text = playerData.player2.PlayerName;
        }

        else
        {
            textWinnerName.text = "-";
        }
    }
}
