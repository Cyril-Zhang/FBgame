using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (DataCollecter.getNeed_bgm()) { 
            AudioManager.instance.Play("Background");
        }
        else
        {
            AudioManager.instance.Stop("Background");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
