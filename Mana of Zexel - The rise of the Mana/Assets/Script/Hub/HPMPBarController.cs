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
        else
            HPESlider.value = Global.HPE1;
    }
}
