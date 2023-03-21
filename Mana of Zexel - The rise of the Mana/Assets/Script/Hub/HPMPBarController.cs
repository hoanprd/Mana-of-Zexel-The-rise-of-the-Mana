using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPMPBarController : MonoBehaviour
{
    public Slider HPP1Slider;
    public Slider MPP1Slider;
    public Slider HPP2Slider;
    public Slider MPP2Slider;
    public Slider HPP3Slider;
    public Slider MPP3Slider;
    public Slider HPESlider;
    public static int EIndex;
    public int once = 0;

    void Start()
    {
        HPP1Slider.maxValue = Global.MaxHPP1;
        MPP1Slider.maxValue = Global.MaxMPP1;
        HPP2Slider.maxValue = Global.MaxHPP2;
        MPP2Slider.maxValue = Global.MaxMPP2;
        HPP3Slider.maxValue = Global.MaxHPP3;
        MPP3Slider.maxValue = Global.MaxMPP3;

        if (EIndex == 1)
            HPESlider.maxValue = Global.HPE1;
        else if (EIndex == 2)
            HPESlider.maxValue = Global.HPE2;
        else if (EIndex == 3)
            HPESlider.maxValue = Global.HPE3;
        else if (EIndex == 4)
            HPESlider.maxValue = Global.HPE4;
        else if (EIndex == 5)
            HPESlider.maxValue = Global.HPE5;
        else if (EIndex == 6)
            HPESlider.maxValue = Global.HPE6;
        else if (EIndex == 7)
            HPESlider.maxValue = Global.HPE7;
        else if (EIndex == 8)
            HPESlider.maxValue = Global.HPE8;
        else if (EIndex == 9)
            HPESlider.maxValue = Global.HPE9;
        else if (EIndex == 10)
            HPESlider.maxValue = Global.HPE10;
        else if (EIndex == 11)
            HPESlider.maxValue = Global.HPE11;
        else if (EIndex == 21)
            HPESlider.maxValue = Global.HPBE1;
        else if (EIndex == 22)
            HPESlider.maxValue = Global.HPBE2;
        else if (EIndex == 23)
            HPESlider.maxValue = Global.HPBE3;
        else if (EIndex == 24)
            HPESlider.maxValue = Global.HPBE4;
        else if (EIndex == 25)
            HPESlider.maxValue = Global.HPBE5;
        else
            HPESlider.maxValue = Global.HPE1;
    }

    void Update()
    {
        HPP1Slider.value = Global.CurHPP1;
        MPP1Slider.value = Global.CurMPP1;
        HPP2Slider.value = Global.CurHPP2;
        MPP2Slider.value = Global.CurMPP2;
        HPP3Slider.value = Global.CurHPP3;
        MPP3Slider.value = Global.CurMPP3;

        if (EIndex == 1)
            HPESlider.value = Global.HPE1;
        else if (EIndex == 2)
            HPESlider.value = Global.HPE2;
        else if (EIndex == 3)
            HPESlider.value = Global.HPE3;
        else if (EIndex == 4)
            HPESlider.value = Global.HPE4;
        else if (EIndex == 5)
            HPESlider.value = Global.HPE5;
        else if (EIndex == 6)
            HPESlider.value = Global.HPE6;
        else if (EIndex == 7)
            HPESlider.value = Global.HPE7;
        else if (EIndex == 8)
            HPESlider.value = Global.HPE8;
        else if (EIndex == 9)
            HPESlider.value = Global.HPE9;
        else if (EIndex == 10)
            HPESlider.value = Global.HPE10;
        else if (EIndex == 11)
            HPESlider.value = Global.HPE11;
        else if (EIndex == 21)
            HPESlider.value = Global.HPBE1;
        else if (EIndex == 22)
            HPESlider.value = Global.HPBE2;
        else if (EIndex == 23)
            HPESlider.value = Global.HPBE3;
        else if (EIndex == 24)
            HPESlider.value = Global.HPBE4;
        else if (EIndex == 25)
            HPESlider.value = Global.HPBE5;
        else
            HPESlider.value = Global.HPE1;

        //Debug.Log(EIndex);
    }
}
