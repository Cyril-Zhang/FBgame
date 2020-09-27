using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    private static float start_time;
    private static float end_time;
    void Start()
    {
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        end_time = Time.time;
    }
    public static float getTime()
    {
        return end_time - start_time;
    }
}
