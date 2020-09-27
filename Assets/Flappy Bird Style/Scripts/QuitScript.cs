using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitScript : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TaskOnClick()
    {
        AudioManager.instance.Play("Button Click");
        Application.Quit();
    }
}