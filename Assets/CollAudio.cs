using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollAudio : MonoBehaviour
{
    public AudioSource Boxing;
    public AudioSource Sitgreen;
    public AudioSource Sitpink;
    public AudioSource Voicing;
    public AudioSource Standblue;
    private bool on = false;

    void SetAudio(Collider plyr)
    {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.O) && !on)
        {
            Voicing.GetComponent<AudioSource>();
            Boxing.GetComponent<AudioSource>();
            Sitgreen.GetComponent<AudioSource>();
            Sitpink.GetComponent<AudioSource>();
            Standblue.GetComponent<AudioSource>();

            Voicing.Play();
            Boxing.Play();
            Sitgreen.Play();
            Sitpink.Play();
            Standblue.Play();
            Debug.Log("TrueCollison");
            on = true;
        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.O) && on)
            {
            Voicing.Stop();
            Boxing.Stop();
            Sitgreen.Stop();
            Sitpink.Stop();
            Standblue.Stop();
            Debug.Log("FalseCollison");
            on = false;
        }
 
    }
}