using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menumanager : MonoBehaviour
{
   public void LoadScene(string scenename)
   {
       SceneManager.LoadScene(scenename);
   }
}
