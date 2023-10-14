using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyInfo : MonoBehaviour
{
    public void InfoDisplay(GameObject[] a, Text[] t)
    {
        for (int i = 0; i < 12; i++)
        {
            if (Global.EnemyListInfo[i] == 1)
            {
                a[i].SetActive(true);

                if (i == 0)
                {
                    t[i].text = "Thief";
                }
                else if (i == 1)
                {
                    t[i].text = "Goblin";
                }
                else if (i == 2)
                {
                    t[i].text = "Golemn";
                }
                else if (i == 3)
                {
                    t[i].text = "Inferno scorpion";
                }
                else if (i == 4)
                {
                    t[i].text = "Mana slime";
                }
                else if (i == 5)
                {
                    t[i].text = "Fire fang";
                }
                else if (i == 6)
                {
                    t[i].text = "Red mana slime";
                }
                else if (i == 7)
                {
                    t[i].text = "Ice fang";
                }
                else if (i == 8)
                {
                    t[i].text = "Blue mana slime";
                }
                else if (i == 9)
                {
                    t[i].text = "Mana eagle";
                }
                else if (i == 10)
                {
                    t[i].text = "Ghost";
                }
                else if (i == 11)
                {
                    t[i].text = "Iron golemn";
                }
            }
            else
            {
                t[i].text = "???";
            }
        }
    }
    public void InfoShow(int index, GameObject txt)
    {
        txt.SetActive(true);
        
        if (index == 0)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE1 + "\n\nDamage: " + Global.DamageE1 + "\n\nBase speed: 1\n\nSkill : 0\n\nPlace : Wishing hill\n\nItem drop: No\n\nEnemy EXP: " + Global.ExpE1;
        }
        else if (index == 1)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE2 + "\n\nDamage: " + Global.DamageE2 + "\n\nBase speed: 1\n\nSkill : 0\n\nPlace : Zexel town\n\nItem drop: No\n\nEnemy EXP: " + Global.ExpE2;
        }
        else if (index == 2)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE3 + "\n\nDamage: " + Global.DamageE3 + "\n\nBase speed: 2\n\nSkill : 0\n\nPlace : Wishing forest\n\nItem drop: Mana gem\n\nEnemy EXP: " + Global.ExpE3;
        }
        else if (index == 3)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE4 + "\n\nDamage: " + Global.DamageE4 + "\n\nBase speed: 2\n\nSkill : 0\n\nPlace : Inferno desert\n\nItem drop: Scorpion venom\n\nEnemy EXP: " + Global.ExpE4;
        }
        else if (index == 4)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE5 + "\n\nDamage: " + Global.DamageE5 + "\n\nBase speed: 1\n\nSkill : 0\n\nPlace : Mana place\n\nItem drop: Mana liquid\n\nEnemy EXP: " + Global.ExpE5;
        }
        else if (index == 5)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE6 + "\n\nDamage: " + Global.DamageE6 + "\n\nBase speed: 2\n\nSkill : 0\n\nPlace : Inferno volcano\n\nItem drop: Golden feather\n\nEnemy EXP: " + Global.ExpE6;
        }
        else if (index == 6)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE7 + "\n\nDamage: " + Global.DamageE7 + "\n\nBase speed: 1\n\nSkill : 0\n\nPlace : Inferno volcano\n\nItem drop: Red mana slime ball\n\nEnemy EXP: " + Global.ExpE7;
        }
        else if (index == 7)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE8 + "\n\nDamage: " + Global.DamageE8 + "\n\nBase speed: 3\n\nSkill : 0\n\nPlace : Inferno ice\n\nItem drop: Ice leather\n\nEnemy EXP: " + Global.ExpE8;
        }
        else if (index == 8)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE9 + "\n\nDamage: " + Global.DamageE9 + "\n\nBase speed: 1\n\nSkill : 0\n\nPlace : Inferno ice\n\nItem drop: Blue mana slime ball\n\nEnemy EXP: " + Global.ExpE9;
        }
        else if (index == 9)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE10 + "\n\nDamage: " + Global.DamageE10 + "\n\nBase speed: 2\n\nSkill : 0\n\nPlace : Mana cliff\n\nItem drop: Eagle feather\n\nEnemy EXP: " + Global.ExpE10;
        }
        else if (index == 10)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPE11 + "\n\nDamage: " + Global.DamageE11 + "\n\nBase speed: 2\n\nSkill : 0\n\nPlace : Zexel temple\n\nItem drop: No\n\nEnemy EXP: " + Global.ExpE11;
        }
        else if (index == 11)
        {
            txt.GetComponent<Text>().text = "HP: " + Global.HPBE4 + "\n\nDamage: " + Global.DamageBE4 + "\n\nBase speed: 3\n\nSkill : 1\n\nPlace : Wishing forest\n\nItem drop: Iron, Mana gem\n\nEnemy EXP: " + Global.ExpBE4;
        }
    }
    public void ResetInfo(GameObject txt)
    {
        txt.GetComponent<Text>().text = "HP: ???\n\nDamage: ???\n\nBase speed: ???\n\nSkill : ???\n\nPlace : ???\n\nItem drop: ???\n\nEnemy EXP: ??? ";
        txt.SetActive(false);
    }
}
