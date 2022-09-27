using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPP1BarController : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider.maxValue = Global.MaxHPP1;
    }

    void Update()
    {
        slider.value = Global.CurHPP1;
    }
}
