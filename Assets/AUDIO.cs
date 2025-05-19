using UnityEngine;

public class AUDIO : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource audioSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip background;

    private void Start()
    {
        audioSource.clip = background;
        audioSource.Play();
    }
}
