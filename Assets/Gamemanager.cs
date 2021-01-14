using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public List<GameObject> Level = new List<GameObject>();
    public int currentLevel = 1;

    public void showPanel(GameObject Panel)
    {
           Panel.SetActive(true);
    }
         
    public void hidePanel(GameObject Panel)
    {
        Panel.SetActive(false);

    }
    public void GoToLevel()
    {
        Level[currentLevel].SetActive(false);

        Level[currentLevel+1].SetActive(true);

        currentLevel++;

       
    }
    
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);

    }


    
    
    

}



    
