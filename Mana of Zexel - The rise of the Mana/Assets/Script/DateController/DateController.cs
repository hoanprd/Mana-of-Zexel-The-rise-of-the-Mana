using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateController : MonoBehaviour
{
    public Animator Sun, Moon;
    public Text UpHour, PHour, DownHour, DayNight;
    public GameObject WHDay, WHNight, MDDay, MDNight, MCDay, MCNight;

    public int TimeDisplay;
    public static float GlobalTime;
    public static int GlobalUpHour, GlobalPHour, GlobalDownHour, GlobalDayNight;
    public static bool StartGlobalTime, DayOn, NightOn;

    // Start is called before the first frame update
    void Start()
    {
        if (StartGlobalTime == true)
        {
            GlobalDayNight = 0;
            GlobalTime = 0f;
            GlobalUpHour = 5;
            GlobalPHour = 6;
            GlobalDownHour = 7;
            StartGlobalTime = false;
        }

        if (GlobalDayNight == 0)
        {
            DayNight.text = "AM";
        }
        else if (GlobalDayNight == 1)
            DayNight.text = "PM";

        UpHour.text = GlobalUpHour + "";
        PHour.text = GlobalPHour + "";
        DownHour.text = GlobalDownHour + "";

        CheckDayNightChange();
    }

    // Update is called once per frame
    void Update()
    {
        CheckDayNightChange();

        if (GlobalTime < TimeDisplay)
            GlobalTime += Time.deltaTime;
        else if (GlobalTime >= TimeDisplay)
        {
            GlobalTime = 0f;

            if (GlobalUpHour < 12)
            {
                GlobalUpHour += 1;
                UpHour.text = GlobalUpHour + "";
            }
            else
            {
                GlobalUpHour = 1;
                UpHour.text = GlobalUpHour + "";
            }

            if (GlobalPHour < 12)
            {
                GlobalPHour += 1;
                PHour.text = GlobalPHour + "";
            }
            else
            {
                GlobalPHour = 1;
                PHour.text = GlobalPHour + "";

                if (GlobalDayNight == 0)
                {
                    GlobalDayNight = 1;
                    DayNight.text = "PM";
                }
                else if (GlobalDayNight == 1)
                {
                    GlobalDayNight = 0;
                    DayNight.text = "AM";
                }

                //CheckDayNightChange();
            }

            if (GlobalDownHour < 12)
            {
                GlobalDownHour += 1;
                DownHour.text = GlobalDownHour + "";
            }
            else
            {
                GlobalDownHour = 1;
                DownHour.text = GlobalDownHour + "";
            }
        }
    }

    void CheckDayNightChange()
    {
        if (((GlobalDayNight == 0 && GlobalPHour >= 6) || (GlobalDayNight == 1 && GlobalPHour < 6)) && Player.MapIndex == 0)
        {
            WHDay.SetActive(true);
            WHNight.SetActive(false);
        }
        else if (((GlobalDayNight == 1 && GlobalPHour >= 6) || (GlobalDayNight == 0 && GlobalPHour < 6)) && Player.MapIndex == 0)
        {
            WHDay.SetActive(false);
            WHNight.SetActive(true);
        }

        if (((GlobalDayNight == 0 && GlobalPHour >= 6) || (GlobalDayNight == 1 && GlobalPHour < 6)) && Player.MapIndex == 6)
        {
            MDDay.SetActive(true);
            MDNight.SetActive(false);
        }
        else if (((GlobalDayNight == 1 && GlobalPHour >= 6) || (GlobalDayNight == 0 && GlobalPHour < 6)) && Player.MapIndex == 6)
        {
            MDDay.SetActive(false);
            MDNight.SetActive(true);
        }

        if (((GlobalDayNight == 0 && GlobalPHour >= 6) || (GlobalDayNight == 1 && GlobalPHour < 6)) && Player.MapIndex == 12)
        {
            MCDay.SetActive(true);
            MCNight.SetActive(false);
        }
        else if (((GlobalDayNight == 1 && GlobalPHour >= 6) || (GlobalDayNight == 0 && GlobalPHour < 6)) && Player.MapIndex == 12)
        {
            MCDay.SetActive(false);
            MCNight.SetActive(true);
        }

        if (((GlobalDayNight == 0 && GlobalPHour >= 6) || (GlobalDayNight == 1 && GlobalPHour < 6)))
        {
            DayOn = true;
            NightOn = false;
            URPMapController.UpdateURP = true;
            URPPlacesController.UpdateURP = true;
            Sun.SetTrigger("sunon");
            Moon.SetTrigger("moonoff");
        }
        else if (((GlobalDayNight == 1 && GlobalPHour >= 6) || (GlobalDayNight == 0 && GlobalPHour < 6)))
        {
            DayOn = false;
            NightOn = true;
            URPMapController.UpdateURP = true;
            URPPlacesController.UpdateURP = true;
            Sun.SetTrigger("sunoff");
            Moon.SetTrigger("moonon");
        }
    }
}
