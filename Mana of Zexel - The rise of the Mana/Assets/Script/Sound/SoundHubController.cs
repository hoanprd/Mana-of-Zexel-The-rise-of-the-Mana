using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHubController : MonoBehaviour
{
    public AudioSource[] FXSound;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < FXSound.Length; i++)
        {
            FXSound[i].volume = PlayerPrefs.GetFloat("SFX");
        }
    }
}
