using UnityEngine;
using TMPro;

public class WordsController : MonoBehaviour
{
    private WordData currentCard;
    [SerializeField] private TMP_Text pk;
    [SerializeField] private TMP_Text p1;
    [SerializeField] private TMP_Text p2;
    [SerializeField] private TMP_Text p3;
    [SerializeField] private TMP_Text p4;
    [SerializeField] private TMP_Text p5;

    void Start()
    {
        NextCard();
    }

    public void NextCard()
    {
        currentCard = WordLoadData.Instance.LoadNextCard();

        pk.text = currentCard.PK;
        p1.text = currentCard.P1;
        p2.text = currentCard.P2;
        p3.text = currentCard.P3;
        p4.text = currentCard.P4;
        p5.text = currentCard.P5;
    }
}
