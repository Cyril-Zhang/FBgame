using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSettingScript : MonoBehaviour
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
        Application.LoadLevel(2);
    }
}
