using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    public void TaskOnClick()
    {
        DataCollecter.Reset();
        AudioManager.instance.Play("Button Click");
        Application.LoadLevel(3);
    }
}
