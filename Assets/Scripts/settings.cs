using UnityEditor.Audio;
using UnityEngine;
using UnityEngine.Audio;


public class settings : MonoBehaviour
{
    public AudioMixer mainMixer;
    public void SetVolume(float volume)
    {
        mainMixer.SetFloat("volume", volume);
    }
}
