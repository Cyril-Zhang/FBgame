using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyOptions : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider difficultyOptions;
    void Start()
    {
        difficultyOptions.value = DataCollecter.getLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TaskOnClick()
    {
        if(difficultyOptions.value == 0)
        {
            DataCollecter.setLevel(0);
            DataCollecter.setSpeed(160);
        }else if(difficultyOptions.value == 1)
        {
            DataCollecter.setLevel(1);
            DataCollecter.setSpeed(190);
        }
        else
        {
            DataCollecter.setLevel(2);
            DataCollecter.setSpeed(210);
        }
    }
}
