using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    void Start()
    {
        print(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TaskOnClick()
    {
        Application.LoadLevel(1);
    }
}
