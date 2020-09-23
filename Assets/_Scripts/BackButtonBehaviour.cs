using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnBackButtonPressed()
    {
        UnityEngine.Debug.Log("Go Back Pressed");
        SceneManager.LoadScene("Start");

    }

}

