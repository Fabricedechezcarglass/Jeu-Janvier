using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporteur : MonoBehaviour
{
    public Transform respawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider Asteroide)
    {
        Asteroide.transform.position = respawn.transform.position;
        

    }
}
