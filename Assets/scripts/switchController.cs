using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class switchController : MonoBehaviour
{
    // Start is called before the first frame update
   public void changeScene(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }
   public void quitApp()
   {
       //SceneManager.LoadScene(sceneName);
       Application.Quit();
   }
}
