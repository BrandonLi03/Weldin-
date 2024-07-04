using UnityEngine;
using TMPro;

public class Record : MonoBehaviour
{
    public TMP_Text BestRecord;
    public float Records; 
    public float compare = 0;
    public static Record instance;
    void Update()
    {
        if(compare < Records){
            compare = Records;
            DisplayTime(compare, BestRecord);
        }
        
    }
    void DisplayTime(float timeToDisplay, TMP_Text textComponent)
{
    float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    textComponent.text = string.Format("{0:00}:{1:00}", minutes, seconds);
}
}
