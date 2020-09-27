using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCollecter : MonoBehaviour
{
    public static DataCollecter instance;
    // Start is called before the first frame update
    private static bool need_bgm;
    private static float bgm_volume;
    private static float flap_volume;
    private static float current_bgm_volume;
    private static float current_flap_volume;
    private static float Speed;
    private static int level;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            need_bgm = true;
            DontDestroyOnLoad(this.gameObject);
            bgm_volume = AudioManager.instance.getVolume("Background");
            flap_volume = AudioManager.instance.getVolume("Bird Flap");
            current_bgm_volume = 5;
            current_flap_volume = 5;
            level = 1;
            Speed = 200;

        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static void setNeed_bgm(bool tf)
    {
        DataCollecter.need_bgm = tf;
    }
    public static bool getNeed_bgm()
    {
        return DataCollecter.need_bgm;
    }
    public static float getBgm_volume()
    {
        return DataCollecter.bgm_volume;
    }
    public static float getFlap_volume()
    {
        return DataCollecter.flap_volume;
    }
    public static float getCurrent_bgm_volume()
    {
        return current_bgm_volume;
    }
    public static float getCurrent_flap_volume()
    {
        return current_flap_volume;
    }
    public static void setCurrent_bgm_volume(float volume)
    {
        current_bgm_volume = volume;
    }
    public static void setCurrent_flap_volume(float volume)
    {
        current_flap_volume = volume;
    }
    public static void setSpeed(float speed)
    {
       Speed = speed;
    }
    public static float getSpeed()
    {
        return Speed;
    }
    public static void setLevel(int l)
    {
        level = l;
    }
    public static int getLevel()
    {
        return level;
    }
}
