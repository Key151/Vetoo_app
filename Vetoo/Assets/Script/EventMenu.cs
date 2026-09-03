using UnityEngine;

public class EventMenu : MonoBehaviour
{
    private string BGMKey = "BGM01";
    private void Start() // Starta tudo do Menu
    {
        AudioManager.Instance.PlayBGM(BGMKey); //Começa a tocar a musica de fundo do menu
    }
}
