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

    //Equip
    public static int VayneStaff1, VayneStaff2, VayneStaff3, AlchemistArmor1, AlchemistArmor2, AlchemistArmor3, VayneWeaponStatus, VayneArmorStatus;
    public static int AliaShoes1, AliaShoes2, AliaShoes3, WarriorArmor1, WarriorArmor2, WarriorArmor3, AliaWeaponStatus, AliaArmorStatus;
    public static int MariaCrystal1, MariaCrystal2, MariaCrystal3, MariaWeaponStatus, MariaArmorStatus;

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
}
