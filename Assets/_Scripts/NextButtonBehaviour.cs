using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonBehaviour : MonoBehaviour
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
   public void OnNextButtonPressed()
    {
        UnityEngine.Debug.Log("Next Button Pressed");
        SceneManager.LoadScene("End");
    }

}



