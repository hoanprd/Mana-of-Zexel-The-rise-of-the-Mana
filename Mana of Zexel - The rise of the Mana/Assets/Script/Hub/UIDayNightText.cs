using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDayNightText : MonoBehaviour
{
    public Text[] UIText;

    public static bool ChangeUITextColorDay, ChangeUITextColorNight;

    // Start is called before the first frame update
    void Start()
    {
        if (DateController.DayOn == true && GraphicSettingController.HightlightShadow != 0)
        {
            ChangeUITextColorDay = true;
            ChangeUITextColorNight = false;
        }
        else if (DateController.NightOn == true && GraphicSettingController.HightlightShadow != 0)
        {
            ChangeUITextColorDay = false;
            ChangeUITextColorNight = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangeUITextColorDay == true && GraphicSettingController.HightlightShadow != 0)
        {
            ChangeUITextColorDay = false;
            for (int i = 0; i < UIText.Length; i++)
            {
                UIText[i].color = Color.black;
            }
        }
        else if (ChangeUITextColorNight == true && GraphicSettingController.HightlightShadow != 0)
        {
            ChangeUITextColorNight = false;
            for (int i = 0; i < UIText.Length; i++)
            {
                UIText[i].color = Color.white;
            }
        }
    }
}
