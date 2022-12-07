using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    //Player status
    public static int LevelP1, MaxEXPP1, CurEXPP1, MaxHPP1, MaxMPP1, DamageP1, SpeedP1, CurHPP1, CurMPP1;
    public static int LevelP2, MaxEXPP2, CurEXPP2, MaxHPP2, MaxMPP2, DamageP2, SpeedP2, CurHPP2, CurMPP2;
    public static int LevelP3, MaxEXPP3, CurEXPP3, MaxHPP3, MaxMPP3, DamageP3, SpeedP3, CurHPP3, CurMPP3;
    public static int Zen;

    //Bonus
    public static int PlusPointP1, PlusPointP2, PlusPointP3;
    public static int PlusPointAttackLvP1, PlusPointHPLvP1, PlusPointMPLvP1, PlusPointSpeedLvP1, PlusPointAttackInfoP1, PlusPointHPInfoP1, PlusPointMPInfoP1, PlusPointSpeedInfoP1;
    public static int PlusPointAttackLvP2, PlusPointHPLvP2, PlusPointMPLvP2, PlusPointSpeedLvP2, PlusPointAttackInfoP2, PlusPointHPInfoP2, PlusPointMPInfoP2, PlusPointSpeedInfoP2;
    public static int PlusPointAttackLvP3, PlusPointHPLvP3, PlusPointMPLvP3, PlusPointSpeedLvP3, PlusPointAttackInfoP3, PlusPointHPInfoP3, PlusPointMPInfoP3, PlusPointSpeedInfoP3;

    //Enemy status
    public static int HPE1, DamageE1, SpeedE1;
    public static int HPE2, DamageE2, SpeedE2;
    public static int HPE3, DamageE3, SpeedE3;
    public static int HPE4, DamageE4, SpeedE4;
    public static int HPE5, DamageE5, SpeedE5;
    public static int HPE6, DamageE6, SpeedE6;
    public static int HPE7, DamageE7, SpeedE7;
    public static int HPE8, DamageE8, SpeedE8;
    public static int HPE9, DamageE9, SpeedE9;
    public static int HPE10, DamageE10, SpeedE10;
    public static int HPE11, DamageE11, SpeedE11;

    public static int HPBE1, DamageBE1, SpeedBE1;
    public static int HPBE2, DamageBE2, SpeedBE2;
    public static int HPBE3, DamageBE3, SpeedBE3;
    public static int HPBE4, DamageBE4, SpeedBE4;
    public static int HPBE5, DamageBE5, SpeedBE5;

    //Equip
    public static int VayneStaff1, VayneStaff2, VayneStaff3, AlchemistArmor1, AlchemistArmor2, AlchemistArmor3, VayneWeaponStatus, VayneArmorStatus;
    public static int AliaShoes1, AliaShoes2, AliaShoes3, WarriorArmor1, WarriorArmor2, WarriorArmor3, AliaWeaponStatus, AliaArmorStatus;
    public static int MariaCrystal1, MariaCrystal2, MariaCrystal3, MariaWeaponStatus, MariaArmorStatus;

    // Start is called before the first frame update
    void Start()
    {
        //Mob
        HPE1 = 100;
        DamageE1 = 10;
        SpeedE1 = 10;

        HPE2 = 200;
        DamageE2 = 20;
        SpeedE2 = 10;

        HPE3 = 300;
        DamageE3 = 40;
        SpeedE3 = 20;

        HPE4 = 600;
        DamageE4 = 60;
        SpeedE4 = 20;

        HPE5 = 1000;
        DamageE5 = 80;
        SpeedE5 = 10;

        HPE6 = 1500;
        DamageE6 = 160;
        SpeedE6 = 20;

        HPE7 = 2000;
        DamageE7 = 180;
        SpeedE7 = 10;

        HPE8 = 2200;
        DamageE8 = 100;
        SpeedE8 = 30;

        HPE9 = 2600;
        DamageE9 = 160;
        SpeedE9 = 10;

        HPE10 = 3600;
        DamageE10 = 220;
        SpeedE10 = 20;

        HPE11 = 4000;
        DamageE11 = 260;
        SpeedE11 = 20;

        //Boss
        HPBE1 = 2000;
        DamageBE1 = 120;
        SpeedBE1 = 20;

        HPBE2 = 6000;
        DamageBE2 = 200;
        SpeedBE2 = 30;

        HPBE3 = 10000;
        DamageBE3 = 260;
        SpeedBE3 = 10;

        HPBE4 = 8000;
        DamageBE4 = 180;
        SpeedBE4 = 30;

        HPBE5 = 50000;
        DamageBE5 = 500;
        SpeedBE5 = 20;
    }
}
