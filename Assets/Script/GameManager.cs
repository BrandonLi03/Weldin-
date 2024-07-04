using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scoreGlobal; // untuk hitung scorenya
    public static GameManager instance;
    void Start () // di awal UI WinPage di matiin
    {
        scoreGlobal = 0;
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}