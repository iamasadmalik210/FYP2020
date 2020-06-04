using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created by Platur

public class Flashlight : MonoBehaviour
{

    //Our Lightsource
    public Light flashlightSource;
    //Our state
    private bool state;

    // Use this for initialization
    void Start()
    {
        //We get the Light of the Gameobject where the script are
        flashlightSource = this.GetComponent<Light>();

        //We change our state to the state of the Light Compnonent
        state = flashlightSource.enabled=false;

    }

    // Update is called once per frame
    void Update()
    {

        //If we Press Keycode F we change the state
        if (Input.GetKeyUp(KeyCode.F))
        {
            //How is our state?
            if (state == true)
            {
                //Its on so we disable the Light
                flashlightSource.enabled = false;
                state = false;
            }
            else
            {
                //Its off so we enable the Light
                flashlightSource.enabled = true;
                state = true;
            }
        }
    }
}