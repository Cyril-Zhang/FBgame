using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music_control: MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle toggle;
    public Slider slider_bgm;
    public Slider slider_flap;
    public void Start()
    {
        toggle.isOn = DataCollecter.getNeed_bgm();
        slider_bgm.value = DataCollecter.getCurrent_bgm_volume();
        slider_flap.value = DataCollecter.getCurrent_flap_volume();
    }
    public void Update()
    {
        //TaskOnClick();
    }
    public void TaskOnClick()
    {
        if (this.toggle.isOn)
        {
            if (AudioManager.instance.isPlaying("Background") == false)
            {
                AudioManager.instance.Play("Background");
                AudioManager.instance.setLoop("Background", true);
                DataCollecter.setNeed_bgm(true);
                toggle.isOn = true;
            }
        }
        else
        {
            AudioManager.instance.Stop("Background");
            AudioManager.instance.setLoop("Background", false);
            DataCollecter.setNeed_bgm(false);
        }
    }
    public void TaskOnSlider_bgm()
    {
        float new_volume = this.slider_bgm.value / 5 * DataCollecter.getBgm_volume();
        AudioManager.instance.setVolume("Background", new_volume);
        DataCollecter.setCurrent_bgm_volume(this.slider_bgm.value);
    }
    public void TaskOnSlider_flap()
    {
        float new_volume = this.slider_flap.value / 5 * DataCollecter.getFlap_volume();
        AudioManager.instance.setVolume("Bird Flap", new_volume);
        DataCollecter.setCurrent_flap_volume(this.slider_flap.value);
    }
}
