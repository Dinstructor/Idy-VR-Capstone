using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{

    public AudioSource switchClick;
    public GameObject lightSwitch;


    private void Start()
    {
        switchClick = GetComponent<AudioSource>();
    }
 
    public void PlaySwitchOnClick()
    {
        switchClick.Play();
    }
}
