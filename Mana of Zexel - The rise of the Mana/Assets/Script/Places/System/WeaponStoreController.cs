using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponStoreController : MonoBehaviour
{
    public GameObject WeaponStorePanel;
    public bool IsActived = false;
    public Text InShock1, InShock2, InShock3, InShock4, InShock5, InShock6, InShock7, InShock8, InShock9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActived == true && Input.GetKeyDown(KeyCode.Space))
        {
            WeaponStorePanel.SetActive(true);
        }
        else if (IsActived == false)
        {
            WeaponStorePanel.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        IsActived = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        IsActived = false;
    }

    public void BuyVayneStaff1()
    {
        if (1 - Global.VayneStaff1 > 0 && Global.Zen >= 500)
        {
            Global.VayneStaff1 += 1;
            InShock1.text = "In shock: " + (1 - Global.VayneStaff1).ToString();
        }
    }

    public void BuyVayneStaff2()
    {
        if(1 - Global.VayneStaff2 > 0 && Global.Zen >= 2000)
        {
            Global.VayneStaff2 += 1;
            InShock2.text = "In shock: " + (1 - Global.VayneStaff2).ToString();
        }
    }

    public void BuyVayneStaff3()
    {
        if (1 - Global.VayneStaff3 > 0 && Global.Zen >= 4000)
        {
            Global.VayneStaff3 += 1;
            InShock3.text = "In shock: " + (1 - Global.VayneStaff3).ToString();
        }
    }

    public void BuyAchelmistArmor1()
    {
        if (2 - Global.AlchemistArmor1 > 0 && Global.Zen >= 500)
        {
            Global.AlchemistArmor1 += 1;
            InShock4.text = "In shock: " + (2 - Global.AlchemistArmor1).ToString();
        }
    }

    public void BuyAchelmistArmor2()
    {
        if (2 - Global.AlchemistArmor2 > 0 && Global.Zen >= 2000)
        {
            Global.AlchemistArmor2 += 1;
            InShock5.text = "In shock: " + (2 - Global.AlchemistArmor2).ToString();
        }
    }

    public void BuyAchelmistArmor3()
    {
        if (2 - Global.AlchemistArmor3 > 0 && Global.Zen >= 4000)
        {
            Global.AlchemistArmor3 += 1;
            InShock6.text = "In shock: " + (2 - Global.AlchemistArmor3).ToString();
        }
    }

    public void CloseWeaponStorePanel()
    {
        WeaponStorePanel.SetActive(false);
    }
}
