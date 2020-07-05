using UnityEngine;
using UnityEngine.Audio;

public class AudioOption : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20);
    }
    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
    }
    public void SetSoundEffectVolume(float volume)
    {
        audioMixer.SetFloat("SFXVolume", Mathf.Log10(volume) * 20);
    }
    public void SetAmbiantVolume(float volume)
    {
        audioMixer.SetFloat("AmbiantVolume", Mathf.Log10(volume) * 20);
    }
}
