using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonBehaviour : MonoBehaviour
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
   public void OnStartButtonPressed()
    {
        UnityEngine.Debug.Log("Start Button Pressed");
        SceneManager.LoadScene("Play");
    }

}



