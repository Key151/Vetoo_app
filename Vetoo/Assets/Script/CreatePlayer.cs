using UnityEngine;

public class CreatePlayer: MonoBehaviour
{
    public PlayerData player1;
    public PlayerData player2;

    public void NamePlayer(string player1Input, string player2Input)
    {
        player1.PlayerName = player1Input;
        player2.PlayerName = player2Input;
    }

    void Awake()
    {
        player1 = new PlayerData();
        player2 = new PlayerData();
        player1.PlayerName = "Elton";
        player2.PlayerName = "Wilson";
    }

}
