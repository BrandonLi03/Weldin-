using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneHandle : MonoBehaviour
{
  public void ChangeSceneto(string SceneName){
        SceneManager.LoadScene(SceneName);
    }
}
