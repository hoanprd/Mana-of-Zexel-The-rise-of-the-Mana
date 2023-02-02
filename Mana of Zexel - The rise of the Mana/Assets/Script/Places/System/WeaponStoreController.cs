using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponStoreController : MonoBehaviour
{
    public GameObject WeaponStorePanel;
    public Text MessageText;
    public bool IsActived = false, stop = false;
    public static int Bought1, Bought2, Bought3, Bought4, Bought5, Bought6, Bought7, Bought8, Bought9, Bought10, Bought11, Bought12, Bought13, Bought14, Bought15;
    public Text InShock1, InShock2, InShock3, InShock4, InShock5, InShock6, InShock7, InShock8, InShock9, InShock10, InShock11, InShock12, InShock13, InShock14, InShock15;
    public GameObject[] WeaponShow;

    // Start is called before the first frame update
    void Start()
    {
        if (Bought1 == 1)
        {
            InShock1.text = "In shock: " + (1 - Global.VayneStaff1).ToString();
        }
        if (Bought2 == 1)
        {
            InShock2.text = "In shock: " + (1 - Global.AliaShoes1).ToString();
        }
        if (Bought3 == 1)
        {
            InShock3.text = "In shock: " + (1 - Global.MariaCrystal1).ToString();
        }
        if (Bought4 == 1)
        {
            InShock4.text = "In shock: " + (2 - Global.AlchemistArmor1).ToString();
        }
        if (Bought5 == 1)
        {
            InShock5.text = "In shock: " + (1 - Global.WarriorArmor1).ToString();
        }
        if (Bought6 == 1)
        {
            InShock6.text = "In shock: " + (1 - Global.VayneStaff2).ToString();
        }
        if (Bought7 == 1)
        {
            InShock7.text = "In shock: " + (1 - Global.AliaShoes2).ToString();
        }
        if (Bought8 == 1)
        {
            InShock8.text = "In shock: " + (1 - Global.MariaCrystal2).ToString();
        }
        if (Bought9 == 1)
        {
            InShock9.text = "In shock: " + (2 - Global.AlchemistArmor2).ToString();
        }
        if (Bought10 == 1)
        {
            InShock10.text = "In shock: " + (1 - Global.WarriorArmor2).ToString();
        }
        if (Bought11 == 1)
        {
            InShock11.text = "In shock: " + (1 - Global.VayneStaff3).ToString();
        }
        if (Bought12 == 1)
        {
            InShock12.text = "In shock: " + (1 - Global.AliaShoes3).ToString();
        }
        if (Bought13 == 1)
        {
            InShock13.text = "In shock: " + (1 - Global.MariaCrystal3).ToString();
        }
        if (Bought14 == 1)
        {
            InShock14.text = "In shock: " + (2 - Global.AlchemistArmor3).ToString();
        }
        if (Bought15 == 1)
        {
            InShock15.text = "In shock: " + (1 - Global.WarriorArmor3).ToString();
        }

        for (int i = 0; i < WeaponShow.Length; i++)
        {
            if (i >= 0 && CutscenesController.cus30 == 0 && CutscenesController.cus58 == 0 && CutscenesController.cus105 == 0)
            {
                Destroy(WeaponShow[i]);
            }
            else if (i > 4 && CutscenesController.cus30 == 1 && CutscenesController.cus58 == 0 && CutscenesController.cus105 == 0)
            {
                Destroy(WeaponShow[i]);
            }
            else if (i > 9 && CutscenesController.cus30 == 1 && CutscenesController.cus58 == 1 && CutscenesController.cus105 == 0)
            {
                Destroy(WeaponShow[i]);
            }
        }
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
            Global.Zen -= 500;
            Bought1 = 1;
            InShock1.text = "In shock: " + (1 - Global.VayneStaff1).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyVayneStaff2()
    {
        if(1 - Global.VayneStaff2 > 0 && Global.Zen >= 2000)
        {
            Global.VayneStaff2 += 1;
            Global.Zen -= 2000;
            Bought6 = 1;
            InShock6.text = "In shock: " + (1 - Global.VayneStaff2).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyVayneStaff3()
    {
        if (1 - Global.VayneStaff3 > 0 && Global.Zen >= 4000)
        {
            Global.VayneStaff3 += 1;
            Global.Zen -= 4000;
            Bought11 = 1;
            InShock11.text = "In shock: " + (1 - Global.VayneStaff3).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyAliaShoes1()
    {
        if (1 - Global.AliaShoes1 > 0 && Global.Zen >= 500)
        {
            Global.AliaShoes1 += 1;
            Global.Zen -= 500;
            Bought2 = 1;
            InShock2.text = "In shock: " + (1 - Global.AliaShoes1).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyAliaShoes2()
    {
        if (1 - Global.AliaShoes2 > 0 && Global.Zen >= 2000)
        {
            Global.AliaShoes2 += 1;
            Global.Zen -= 2000;
            Bought7 = 1;
            InShock7.text = "In shock: " + (1 - Global.AliaShoes2).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyAliaShoes3()
    {
        if (1 - Global.AliaShoes3 > 0 && Global.Zen >= 4000)
        {
            Global.AliaShoes3 += 1;
            Global.Zen -= 4000;
            Bought12 = 1;
            InShock12.text = "In shock: " + (1 - Global.AliaShoes3).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyMariaCrystal1()
    {
        if (1 - Global.MariaCrystal1 > 0 && Global.Zen >= 500)
        {
            Global.MariaCrystal1 += 1;
            Global.Zen -= 500;
            Bought3 = 1;
            InShock3.text = "In shock: " + (1 - Global.MariaCrystal1).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyMariaCrystal2()
    {
        if (1 - Global.MariaCrystal2 > 0 && Global.Zen >= 2000)
        {
            Global.MariaCrystal2 += 1;
            Global.Zen -= 2000;
            Bought8 = 1;
            InShock8.text = "In shock: " + (1 - Global.MariaCrystal2).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyMariaCrystal3()
    {
        if (1 - Global.MariaCrystal3 > 0 && Global.Zen >= 4000)
        {
            Global.MariaCrystal3 += 1;
            Global.Zen -= 4000;
            Bought13 = 1;
            InShock13.text = "In shock: " + (1 - Global.MariaCrystal3).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyAchelmistArmor1()
    {
        if (2 - Global.AlchemistArmor1 > 0 && Global.Zen >= 500)
        {
            Global.AlchemistArmor1 += 1;
            Global.Zen -= 500;
            Bought4 = 1;
            InShock4.text = "In shock: " + (2 - Global.AlchemistArmor1).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyAchelmistArmor2()
    {
        if (2 - Global.AlchemistArmor2 > 0 && Global.Zen >= 2000)
        {
            Global.AlchemistArmor2 += 1;
            Global.Zen -= 2000;
            Bought9 = 1;
            InShock9.text = "In shock: " + (2 - Global.AlchemistArmor2).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyAchelmistArmor3()
    {
        if (2 - Global.AlchemistArmor3 > 0 && Global.Zen >= 4000)
        {
            Global.AlchemistArmor3 += 1;
            Global.Zen -= 4000;
            Bought14 = 1;
            InShock14.text = "In shock: " + (2 - Global.AlchemistArmor3).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyWarriorArmor1()
    {
        if (1 - Global.WarriorArmor1 > 0 && Global.Zen >= 500)
        {
            Global.WarriorArmor1 += 1;
            Global.Zen -= 500;
            Bought5 = 1;
            InShock5.text = "In shock: " + (1 - Global.WarriorArmor1).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyWarriorArmor2()
    {
        if (1 - Global.WarriorArmor2 > 0 && Global.Zen >= 2000)
        {
            Global.WarriorArmor2 += 1;
            Global.Zen -= 2000;
            Bought10 = 1;
            InShock10.text = "In shock: " + (1 - Global.WarriorArmor2).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyWarriorArmor3()
    {
        if (1 - Global.WarriorArmor3 > 0 && Global.Zen >= 4000)
        {
            Global.WarriorArmor3 += 1;
            Global.Zen -= 4000;
            Bought15 = 1;
            InShock15.text = "In shock: " + (1 - Global.WarriorArmor3).ToString();
            MessageText.text = "Good luck with the new weapon!!!";
            StartCoroutine(DelayBuy());
        }
    }

    public void CloseWeaponStorePanel()
    {
        WeaponStorePanel.SetActive(false);
    }

    IEnumerator DelayBuy()
    {
        yield return new WaitForSeconds(1f);
        MessageText.text = "Enjoy my weapon!!!";
        stop = false;
    }
}
