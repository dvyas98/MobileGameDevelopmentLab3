using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Start Button Pressed Event
   public void OnRestartButtonPressed()
    {
        UnityEngine.Debug.Log("Restart Button Pressed");
        SceneManager.LoadScene("Start");
    }

}



