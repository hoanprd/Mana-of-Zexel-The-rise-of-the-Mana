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

    void Start()
    {
        HPP1Slider.maxValue = Global.MaxHPP1;
        MPP1Slider.maxValue = Global.MaxMPP1;
        HPP2Slider.maxValue = Global.MaxHPP2;
        MPP2Slider.maxValue = Global.MaxMPP2;
        HPP3Slider.maxValue = Global.MaxHPP3;
        MPP3Slider.maxValue = Global.MaxMPP3;
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
        HPESlider.value = Global.HPE1;
    }
}
