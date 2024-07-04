using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Spalsh : MonoBehaviour {           
  public string targetScene = "UI";          
  public float splashDuration = 2.0f;           
  void Start()     {                  
    StartCoroutine(LoadHomeSceneAfterDelay(splashDuration));     }          
     IEnumerator LoadHomeSceneAfterDelay(float delay)     {                 
       yield return new WaitForSeconds(delay);                  
       SceneManager.LoadScene(targetScene);     } }
