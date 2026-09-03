using UnityEngine;

public class EventRun : MonoBehaviour
{
    private string BGMKey = "BGM02";
    private void Start() // Starta tudo do Menu
    {
        AudioManager.Instance.PlayBGM(BGMKey); //Começa a tocar a musica de fundo do menu
    }
}
