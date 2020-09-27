using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        foreach(Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        //init background sound
        Sound m= Array.Find(sounds,sounds=>sounds.name=="Background");
        m.source.Play();
    }

    public void Play(string name){
        Sound s = Array.Find(sounds,sounds=>sounds.name == name);
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.Stop();
    }
    public bool isPlaying(string name)
    {
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        return s.source.isPlaying;
    }
    public void setLoop(string name, bool tf)
    {
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.loop = tf;
    }

    public float getVolume(string name)
    {
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        return s.source.volume;
    }
    public void setVolume(string name, float volume)
    {
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.volume = volume;
    }
}
