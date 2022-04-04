using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieScreen : MonoBehaviour
{
  public void Restart()
  {
      SceneManager.LoadScene(SceneNames.MenuSceneName);
  }
}
