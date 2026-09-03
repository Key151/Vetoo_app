using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    [Header("Sliders")]

    [SerializeField] private UnityEngine.UI.Slider bgmSlider;
    [SerializeField] private UnityEngine.UI.Slider seSlider;

    public void OnVolumeBGM()
    {
        AudioManager.Instance.SetVolumeBGM(bgmSlider.value);
    }

    public void OnVolumeSE() 
    {
        AudioManager.Instance.SetVolumeSE(seSlider.value);
    }
}
