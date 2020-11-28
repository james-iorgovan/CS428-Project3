using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOnOff : MonoBehaviour {

    public GameObject LightSwitch;
    private bool on = false;

    void OnTriggerStay(Collider plyr) {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.O) && !on)
        {
            LightSwitch.SetActive(true);
            on = true;
        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.O) && on)
            {
            LightSwitch.SetActive(false);
            on = false;
        }
    }
}