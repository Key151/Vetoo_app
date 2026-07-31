using UnityEngine;

public class AudioSetting : MonoBehaviour
{
    [SerializeField] private AudioSource bmgSource;

    public void setBMGVolume(float volume)
    {
        bmgSource.volume = volume;
    }
}
