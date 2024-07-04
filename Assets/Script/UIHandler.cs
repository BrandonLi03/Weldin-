using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public GameObject FromPage;
    public GameObject ToPage;
    
    public void ChangeTo()
    {
        FromPage.SetActive(false); // Corrected method name
        ToPage.SetActive(true); // Corrected method name
    }

    public void BackTo(){
        ToPage.SetActive(false);
        FromPage.SetActive(true);
    }
}
