using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Scriptable Objects/Audio")]
public class ScriptableObjectAudio : ScriptableObject
{
    [System.Serializable]
    public class AudioClipData
    {
        public string name;
        public AudioClip clip;
    }

    public AudioClipData[] audioClips; //Criacao da lista de audioClips, que sera serializada no inspector

    private Dictionary<string, AudioClip> audioClipDictionary; //criacao do dicio, ja que nao tem interface direto por serializable

    public void setupAudio()
    {
        if (audioClipDictionary != null) return;
        audioClipDictionary = new Dictionary<string, AudioClip>();

        foreach (var audioClipData in audioClips)
        {
            audioClipDictionary.TryAdd(audioClipData.name, audioClipData.clip); // Tenta add no dicio, caso for igual n coloca 
        }
    }

    public AudioClip GetClip(string key)
    {
        setupAudio();
        return audioClipDictionary.TryGetValue(key, out AudioClip clip) ? clip : null; // Tenta pegar o valor correspondente do key
    }
}