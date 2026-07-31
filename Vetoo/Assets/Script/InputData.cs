using UnityEngine;
using TMPro;

public class InputData : MonoBehaviour
{
    [Header("Rodadas Minimo")]
    [SerializeField] private int roundMin;

    [Header("Setup")]
    [SerializeField] private TMP_InputField player1Input;
    [SerializeField] private TMP_InputField player2Input;
    [SerializeField] private TMP_InputField roundConut;

    public string TakePlayer1Name()
    {
        if (string.IsNullOrEmpty(player1Input.text))
        {
            return "Time A";
        }
        else
        {
            return player1Input.text;
        }
    }

    public string TakePlayer2Name()
    {
        if (string.IsNullOrEmpty(player2Input.text))
        {
            return "Time B";
        }
        else
        {
            return player2Input.text;
        }
    }

    public int TakeRoundCount()
    {
        if (string.IsNullOrEmpty(roundConut.text))
        {
            return roundMin;
        }
        else
        {
            return 2 * int.Parse(roundConut.text);
        }
    }
}
