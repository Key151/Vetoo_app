using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] private AudioSource bgmSource;
    [SerializeField] private AudioSource seSource;

    [Header("Library")]
    [SerializeField] private ScriptableObjectAudio bgmLibrary;
    [SerializeField] private ScriptableObjectAudio seLibrary;
    public static AudioManager Instance { get; private set; }

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            bgmSource.volume = 1.0f;
            seSource.volume = 1.0f;
            PlayBGM("BGM01");
            DontDestroyOnLoad(gameObject);
        }

        else Destroy(gameObject);
    }

    //------------------BGM------------------
    public void PlayBGM(string key)
    {
        var clip = bgmLibrary.GetClip(key);
        if (clip != null)
        {
            bgmSource.clip = clip;
            bgmSource.loop = true;
            bgmSource.Play();
        }
        else
        {
            Debug.LogWarning($"BGM '{key}' nao encontrado!");
        }
    }

    public void StopBGM()
    {
        bgmSource.Stop();
    }

    public void SetVolumeBGM(float volume)
    {
        bgmSource.volume = volume;
    }

    //------------------SE------------------
    
    public void PlaySE(string key)
    {
        var clip = seLibrary.GetClip(key);
        if (clip != null)
        {
            seSource.PlayOneShot(clip);
        }
        else
        {
            Debug.LogWarning($"SE '{key}' nao encontrado!");
        }
    }
    public void StopSE()
    {
        seSource.Stop();
    }

    public void SetVolumeSE(float volume)
    {
        seSource.volume = volume;
    }
}
