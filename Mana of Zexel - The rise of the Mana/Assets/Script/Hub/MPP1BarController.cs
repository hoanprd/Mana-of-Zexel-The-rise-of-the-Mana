using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MPP1BarController : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider.maxValue = Global.MaxMPP1;
    }

    void Update()
    {
        slider.value = Global.CurMPP1;
    }
}
