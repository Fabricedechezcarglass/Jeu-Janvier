using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject panel;

    public Gamemanager gameManager;

    public void OnTriggerEnter(Collider other)
    {
        gameManager.showPanel(panel);
    }
}