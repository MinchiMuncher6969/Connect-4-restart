using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIscript : MonoBehaviour
{
    public static float musicVol = 1.0f;
    public static float sfxVol = 1.0f;


    // method to set the background volume global variable
    public void music_OnValueChanged(float value)
    {
        musicVol = value;
    }

    // method to set the sound effect volume global variable
    public void sfx_OnValueChanged(float value)
    {
        sfxVol = value;
    }

    // this method is called when a button is pressed
    // this method is also called when a slider is dragged using the 'begin drag' and 'end drag' event triggers that are applied to the slider gameobjects
    public void button_click()
    {
        MenuSelect.playSfx = true;
    }

    // this method is called when the UI options button is clicked
    public void ChangeScene_start()
    {
        MenuSelect.menu = "start";
        MenuSelect.playSfx = true;
    }

    // this method is called when the UI back button is clicked
    public void ChangeScene_Button_1()
    {
        MenuSelect.menu = "Button_1";
        MenuSelect.playSfx = true;
    }

    public void ChangeScene_Button_2()
    {
        MenuSelect.menu = "Button_2";
        MenuSelect.playSfx = true;
    }

    public void ChangeScene_Button_3()
    {
        MenuSelect.menu = "Button_3";
        MenuSelect.playSfx = true;
    }
    public void ChangeScene_Button_4()
    {
        MenuSelect.menu = "Button_4";
        MenuSelect.playSfx = true;
    }
    public void ChangeScene_Button_5()
    {
        MenuSelect.menu = "Button_5";
        MenuSelect.playSfx = true;
    }
}

