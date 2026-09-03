using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    [Header("Sliders")]

    [SerializeField] private Slider bgmSlider;
    [SerializeField] private Slider seSlider;

    private void Start()
    {
        bgmSlider.value = AudioManager.Instance.GetVolumeBGM();
        //seSlider.value = AudioManager.Instance.GetVolumeSE();
    }

    public void OnVolumeBGM()
    {
        AudioManager.Instance.SetVolumeBGM(bgmSlider.value);
    }

    public void OnVolumeSE() 
    {
        AudioManager.Instance.SetVolumeSE(seSlider.value);
    }
}
