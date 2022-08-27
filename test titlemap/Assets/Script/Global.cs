using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    BSThief bst;
    MenuController mc;
    public int LevelP1, MaxEXPP1, CurEXPP1, MaxHPP1, MaxMPP1, DamageP1, SpeedP1, CurHPP1, CurMPP1;
    public int LevelP2, MaxEXPP2, CurEXPP2, MaxHPP2, MaxMPP2, DamageP2, SpeedP2, CurHPP2, CurMPP2;
    public int Zen;
    public int HPE1, DamageE1, SpeedE1;
    public int HPE2, DamageE2, SpeedE2;
    public int HPE3, DamageE3, SpeedE3;
    // Start is called before the first frame update
    void Start()
    {
        MaxHPP1 = PlayerPrefs.GetInt("SMaxHPP1");
        MaxMPP1 = PlayerPrefs.GetInt("SMaxMPP1");
        DamageP1 = PlayerPrefs.GetInt("SDamageP1");
        SpeedP1 = PlayerPrefs.GetInt("SSpeedP1");
        LevelP1 = PlayerPrefs.GetInt("SLevelP1");
        MaxEXPP1 = PlayerPrefs.GetInt("SMaxEXPP1");
        CurEXPP1 = PlayerPrefs.GetInt("SCurEXPP1");
        Zen = PlayerPrefs.GetInt("SZen");

        MaxHPP2 = PlayerPrefs.GetInt("SMaxHPP2");
        MaxMPP2 = PlayerPrefs.GetInt("SMaxMPP2");
        DamageP2 = PlayerPrefs.GetInt("SDamageP2");
        SpeedP2 = PlayerPrefs.GetInt("SSpeedP2");
        LevelP2 = PlayerPrefs.GetInt("SLevelP2");
        MaxEXPP2 = PlayerPrefs.GetInt("SMaxEXPP2");
        CurEXPP2 = PlayerPrefs.GetInt("SCurEXPP2");

        if (PlayerPrefs.GetInt("DTakeD") == 0)
        {
            CurHPP1 = MaxHPP1;
            CurMPP1 = MaxMPP1;
            CurHPP2 = MaxHPP2;
            CurMPP2 = MaxMPP2;
        }
        else if(PlayerPrefs.GetInt("DTakeD") == 1)
        {
            CurHPP1 = PlayerPrefs.GetInt("AfterHPP1");
            CurMPP1 = PlayerPrefs.GetInt("AfterMPP1");
            CurEXPP1 = PlayerPrefs.GetInt("AfterCurEXPP1");
            MaxEXPP1 = PlayerPrefs.GetInt("AfterMaxEXPP1");
            Zen = PlayerPrefs.GetInt("AfterZen");
            LevelP1 = PlayerPrefs.GetInt("AfterLevelP1");
            MaxHPP1 = PlayerPrefs.GetInt("AfterMaxHPP1");
            MaxMPP1 = PlayerPrefs.GetInt("AfterMaxMPP1");
            DamageP1 = PlayerPrefs.GetInt("AfterDamageP1");
            SpeedP1 = PlayerPrefs.GetInt("AfterSpeedP1");

            CurHPP2 = PlayerPrefs.GetInt("AfterHPP2");
            CurMPP2 = PlayerPrefs.GetInt("AfterMPP2");
            CurEXPP2 = PlayerPrefs.GetInt("AfterCurEXPP2");
            MaxEXPP2 = PlayerPrefs.GetInt("AfterMaxEXPP2");
            LevelP2 = PlayerPrefs.GetInt("AfterLevelP2");
            MaxHPP2 = PlayerPrefs.GetInt("AfterMaxHPP2");
            MaxMPP2 = PlayerPrefs.GetInt("AfterMaxMPP2");
            DamageP2 = PlayerPrefs.GetInt("AfterDamageP2");
            SpeedP2 = PlayerPrefs.GetInt("AfterSpeedP2");
        }
        
        HPE1 = 100;
        DamageE1 = 10;
        SpeedE1 = 10;

        HPE2 = 200;
        DamageE2 = 20;
        SpeedE2 = 10;

        HPE3 = 300;
        DamageE3 = 40;
        SpeedE3 = 20;
    }
    void Update()
    {
        
    }
}
