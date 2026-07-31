using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems; // Necessário para detectar o mouse passando por cima
using UnityEngine.UI;

public class InterfaceFluida : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Configuracaoes do Botao")]
    [SerializeField] private RectTransform botao;
    private Vector3 escalaOriginalBotao;

    [Header("Ação Customizada do Botão")]
    [SerializeField] private UnityEvent acaoBtn; // Isso cria uma caixinha no Inspetor igual ao OnClick nativo da Unity!

    void Start()
    {
        escalaOriginalBotao = botao.localScale;  // Salva a escala inicial do botão para não perder a referência

    }

    // 2. EFEITO FLUIDO AO CLICAR NO BOTÃO (Associe ao evento OnClick do Botão)
    public void AoClicarNoBotao()
    {
        botao.localScale = escalaOriginalBotao;// Reseta a escala para evitar bugs de cliques repetidos muito rápidos

        /* 
           O DOPunchScale cria a distorção de fluido:
           - punch: A direção e intensidade do esticamento (X deforma para os lados, Y para cima)
           - duration: Tempo do efeito
           - vibrato: Quantas vezes ele vai chacoalhar antes de parar (quanto maior, mais elástico)
           - elasticity: O quão longe ele vai além do limite
        */
        botao.DOPunchScale(new Vector3(0.2f, -0.3f, 0f), 0.5f, 7, 1f)
            .OnComplete(() =>
            {
                if (acaoBtn != null)
                {
                    acaoBtn.Invoke();
                }
                botao.localScale = escalaOriginalBotao;
            });
        Debug.Log("Apertou!");
    }

    // 3. EFEITO AO PASSAR O MOUSE POR CIMA (Hover)
    public void OnPointerEnter(PointerEventData eventData)
    {
        botao.DOScale(escalaOriginalBotao * 1.15f, 0.4f).SetEase(Ease.OutElastic); // Quando o mouse entra, o botão cresce ligeiramente simulando flutuação fluida
    }

    // 4. EFEITO AO TIRAR O MOUSE DE CIMA
    public void OnPointerExit(PointerEventData eventData)
    {
        botao.DOScale(escalaOriginalBotao, 0.3f).SetEase(Ease.OutQuad); // Quando o mouse sai, ele volta ao tamanho normal de forma suave
    }
}
