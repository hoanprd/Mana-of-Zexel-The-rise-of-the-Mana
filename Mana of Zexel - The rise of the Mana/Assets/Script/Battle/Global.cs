using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    //Player status
    public static int LevelP1, MaxEXPP1, CurEXPP1, MaxHPP1, MaxMPP1, DamageP1, SpeedP1, CurHPP1, CurMPP1;
    public static int LevelP2, MaxEXPP2, CurEXPP2, MaxHPP2, MaxMPP2, DamageP2, SpeedP2, CurHPP2, CurMPP2;
    public static int Zen;

    //Bonus
    public static int PlusPointP1, PlusPointP2, PlusPointP3;
    public static int PlusPointAttackLvP1, PlusPointHPLvP1, PlusPointMPLvP1, PlusPointSpeedLvP1, PlusPointAttackInfoP1, PlusPointHPInfoP1, PlusPointMPInfoP1, PlusPointSpeedInfoP1;

    //Enemy status
    public static int HPE1, DamageE1, SpeedE1;
    public static int HPE2, DamageE2, SpeedE2;
    public static int HPE3, DamageE3, SpeedE3;

    //Equip
    public static int VayneStaff1, VayneStaff2, VayneStaff3, AlchemistArmor1, AlchemistArmor2, AlchemistArmor3, VayneWeaponStatus, VayneArmorStatus;

    // Start is called before the first frame update
    void Start()
    {
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
