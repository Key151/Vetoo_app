using UnityEngine;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class WordLoadData : MonoBehaviour
{
    public static WordLoadData Instance;
    public WordList WordList { get; private set; }
    private int currentIndex = 0;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        Load();
        if (WordList != null) Shuffle();
    }

    private void Load()
    {
        Instance = this;

        TextAsset jsonFile = Resources.Load<TextAsset>("tabelaJsonMinifier");

        if (jsonFile == null) //Caso nao carregado
        {
            Debug.Log("Nao carregado");
            return;
        }

        WordList = JsonUtility.FromJson<WordList>(jsonFile.text);

        Debug.Log(WordList);
        Debug.Log(WordList.cartas);
        Debug.Log(WordList.cartas.Length);

        Debug.Log($"Cartas carregadas: {WordList.cartas.Length}");
    }

    private void Shuffle()
    {
        for (int i = 0; i < WordList.cartas.Length; i++)
        {
            int randomIndex = Random.Range(i, WordList.cartas.Length);
            (WordList.cartas[i], WordList.cartas[randomIndex]) = (WordList.cartas[randomIndex], WordList.cartas[i]);
        }
    }

    public WordData LoadNextCard()
    {
        Debug.Log($"Instance: {Instance}");
        Debug.Log(WordList.cartas);
        if (currentIndex >= WordList.cartas.Length) currentIndex = 0;
        return WordList.cartas[currentIndex++];
    }
}
