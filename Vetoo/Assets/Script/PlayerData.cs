using UnityEngine;

public class PlayerData
{
    //private int playerID;
    private string playerName;
    private float playerTime = 0f;
    private int playerHit = 0;

    //public int PlayerID
    //{
    //    get { return playerID; }
    //    set { playerID = value; }
    //}

    public string PlayerName
    {
        get { return  playerName; }
        set { playerName = value; }
    }

    public float PlayerTime
    {
        get { return playerTime; }
        set { playerTime = value; }
    }

    public int PlayerHit
    {
        get { return playerHit; }
    }

    public void AddHit()
    {
        ++playerHit;
    }
}
