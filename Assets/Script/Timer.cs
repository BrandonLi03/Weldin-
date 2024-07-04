using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
public TMP_Text timeText;
public TMP_Text resultText;
public GameObject WinPage;
private float currentTime;
private bool timerActive = false; // To track the timer state
public static Timer instance;
void Awake()
{
    // Singleton pattern to ensure only one instance of Timer exists
    if (instance == null)
    {
        instance = this;
        DontDestroyOnLoad(gameObject); // Make this object persistent
    }
    else
    {
        Destroy(gameObject); // Destroy duplicate instances
    }
}

void Start()
{
    StartTimer();
}

void Update()
{
    if (timerActive)
    {
        currentTime += Time.deltaTime;
        DisplayTime(currentTime, timeText);
    }

    if (GameManager.instance.scoreGlobal == 50)
    {
        timerActive = false;
        WinPage.SetActive(true);
        DisplayTime(currentTime, resultText);
        GameManager.instance.scoreGlobal = 0;

    }
}

public void StartTimer()
{
    currentTime = 0f;  // Reset current time
    timerActive = true;
}

void DisplayTime(float timeToDisplay, TMP_Text textComponent)
{
    float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    textComponent.text = string.Format("{0:00}:{1:00}", minutes, seconds);
}
}