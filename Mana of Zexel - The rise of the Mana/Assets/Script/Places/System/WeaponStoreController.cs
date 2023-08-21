using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponStoreController : MonoBehaviour
{
    public GameObject WeaponStorePanel, BuyAskPanel, show2;
    public Text MessageText, show1;
    public AudioSource BuyFX, ClickFX;
    public int BuyIndex;
    public bool IsActived = false, stop = false;
    public static int Bought1, Bought2, Bought3, Bought4, Bought5, Bought6, Bought7, Bought8, Bought9, Bought10, Bought11, Bought12, Bought13, Bought14, Bought15;
    public static int AlchemistArmor1HadBought, AlchemistArmor2HadBought, AlchemistArmor3HadBought;
    public Text InShock1, InShock2, InShock3, InShock4, InShock5, InShock6, InShock7, InShock8, InShock9, InShock10, InShock11, InShock12, InShock13, InShock14, InShock15, AskConfirmText;
    public GameObject[] WeaponShow;

    // Start is called before the first frame update
    void Start()
    {
        if (Bought1 == 1)
        {
            //InShock1.text = "In shock: " + (1 - Global.VayneStaff1).ToString();
            InShock1.text = "In shock: 0";
        }
        if (Bought2 == 1)
        {
            InShock2.text = "In shock: 0";
        }
        if (Bought3 == 1)
        {
            InShock3.text = "In shock: 0";
        }
        if (Bought4 == 1)
        {
            InShock4.text = "In shock: " + (2 - AlchemistArmor1HadBought).ToString();
        }
        if (Bought5 == 1)
        {
            InShock5.text = "In shock: 0";
        }
        if (Bought6 == 1)
        {
            InShock6.text = "In shock: 0";
        }
        if (Bought7 == 1)
        {
            InShock7.text = "In shock: 0";
        }
        if (Bought8 == 1)
        {
            InShock8.text = "In shock: 0";
        }
        if (Bought9 == 1)
        {
            InShock9.text = "In shock: " + (2 - AlchemistArmor2HadBought).ToString();
        }
        if (Bought10 == 1)
        {
            InShock10.text = "In shock: 0";
        }
        if (Bought11 == 1)
        {
            InShock11.text = "In shock: 0";
        }
        if (Bought12 == 1)
        {
            InShock12.text = "In shock: 0";
        }
        if (Bought13 == 1)
        {
            InShock13.text = "In shock: 0";
        }
        if (Bought14 == 1)
        {
            InShock14.text = "In shock: " + (2 - AlchemistArmor3HadBought).ToString();
        }
        if (Bought15 == 1)
        {
            InShock15.text = "In shock: 0";
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
            HubController.BusyHub = true;
            WeaponStorePanel.SetActive(true);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        IsActived = true;
        show2.SetActive(true);
        show1.text = "Press Space to buy";
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        IsActived = false;
        show2.SetActive(false);
        show1.text = "";
    }

    public void BuyVayneStaff1()
    {
        if (Bought1 == 0)
        {
            ClickFX.Play();
            BuyIndex = 1;
            AskConfirmText.text = "Do you want buy this Amateurs Staff?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyVayneStaff2()
    {
        if(Bought6 == 0)
        {
            ClickFX.Play();
            BuyIndex = 2;
            AskConfirmText.text = "Do you want buy this Intermediate Staff?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyVayneStaff3()
    {
        if (Bought11 == 0)
        {
            ClickFX.Play();
            BuyIndex = 3;
            AskConfirmText.text = "Do you want buy this Master Staff?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyAliaShoes1()
    {
        if (Bought2 == 0)
        {
            ClickFX.Play();
            BuyIndex = 4;
            AskConfirmText.text = "Do you want buy this Amateurs Shoes?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyAliaShoes2()
    {
        if (Bought7 == 0)
        {
            ClickFX.Play();
            BuyIndex = 5;
            AskConfirmText.text = "Do you want buy this Intermediate Shoes?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyAliaShoes3()
    {
        if (Bought12 == 0)
        {
            ClickFX.Play();
            BuyIndex = 6;
            AskConfirmText.text = "Do you want buy this Master Shoes?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyMariaCrystal1()
    {
        if (Bought3 == 0)
        {
            ClickFX.Play();
            BuyIndex = 7;
            AskConfirmText.text = "Do you want buy this Amateurs Crystal?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyMariaCrystal2()
    {
        if (Bought8 == 0)
        {
            ClickFX.Play();
            BuyIndex = 8;
            AskConfirmText.text = "Do you want buy this Intermediate Crystal?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyMariaCrystal3()
    {
        if (Bought13 == 0)
        {
            ClickFX.Play();
            BuyIndex = 9;
            AskConfirmText.text = "Do you want buy this Master Crystal?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyAchelmistArmor1()
    {
        if (2 - AlchemistArmor1HadBought > 0)
        {
            ClickFX.Play();
            BuyIndex = 10;
            AskConfirmText.text = "Do you want buy this Amateurs Achelmist Armor?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyAchelmistArmor2()
    {
        if (2 - AlchemistArmor2HadBought > 0)
        {
            ClickFX.Play();
            BuyIndex = 11;
            AskConfirmText.text = "Do you want buy this Intermediate Achelmist Armor?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyAchelmistArmor3()
    {
        if (2 - AlchemistArmor3HadBought > 0)
        {
            ClickFX.Play();
            BuyIndex = 12;
            AskConfirmText.text = "Do you want buy this Master Achelmist Armor?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyWarriorArmor1()
    {
        if (Bought5 == 0)
        {
            ClickFX.Play();
            BuyIndex = 13;
            AskConfirmText.text = "Do you want buy this Amateurs Warrior Armor?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyWarriorArmor2()
    {
        if (Bought10 == 0)
        {
            ClickFX.Play();
            BuyIndex = 14;
            AskConfirmText.text = "Do you want buy this Intermediate Warrior Armor?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void BuyWarriorArmor3()
    {
        if (Bought15 == 0)
        {
            ClickFX.Play();
            BuyIndex = 15;
            AskConfirmText.text = "Do you want buy this Master Warrior Armor?";
            BuyAskPanel.SetActive(true);
        }
    }

    public void ConfirmBuyItem()
    {
        if (BuyIndex == 1)
        {
            if (Global.Zen >= 500)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.VayneStaff1 += 1;
                Global.Zen -= 500;
                Bought1 = 1;
                InShock1.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 2)
        {
            if (Global.Zen >= 1000)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.VayneStaff2 += 1;
                Global.Zen -= 1000;
                Bought6 = 1;
                InShock6.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 3)
        {
            if (Global.Zen >= 1500)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.VayneStaff3 += 1;
                Global.Zen -= 1500;
                Bought11 = 1;
                InShock11.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 4)
        {
            if (Global.Zen >= 500)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.AliaShoes1 += 1;
                Global.Zen -= 500;
                Bought2 = 1;
                InShock2.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 5)
        {
            if (Global.Zen >= 1000)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.AliaShoes2 += 1;
                Global.Zen -= 1000;
                Bought7 = 1;
                InShock7.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 6)
        {
            if (Global.Zen >= 1500)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.AliaShoes3 += 1;
                Global.Zen -= 1500;
                Bought12 = 1;
                InShock12.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 7)
        {
            if (Global.Zen >= 500)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.MariaCrystal1 += 1;
                Global.Zen -= 500;
                Bought3 = 1;
                InShock3.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 8)
        {
            if (Global.Zen >= 1000)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.MariaCrystal2 += 1;
                Global.Zen -= 1000;
                Bought8 = 1;
                InShock8.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 9)
        {
            if (Global.Zen >= 1500)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.MariaCrystal3 += 1;
                Global.Zen -= 1500;
                Bought13 = 1;
                InShock13.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 10)
        {
            if (Global.Zen >= 500)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.AlchemistArmor1 += 1;
                Global.Zen -= 500;
                Bought4 = 1;
                AlchemistArmor1HadBought += 1;
                InShock4.text = "In shock: " + (2 - AlchemistArmor1HadBought).ToString();
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 11)
        {
            if (Global.Zen >= 1000)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.AlchemistArmor2 += 1;
                Global.Zen -= 1000;
                Bought9 = 1;
                AlchemistArmor2HadBought += 1;
                InShock9.text = "In shock: " + (2 - AlchemistArmor2HadBought).ToString();
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 12)
        {
            if (Global.Zen >= 1500)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.AlchemistArmor3 += 1;
                Global.Zen -= 1500;
                Bought14 = 1;
                AlchemistArmor3HadBought += 1;
                InShock14.text = "In shock: " + (2 - AlchemistArmor3HadBought).ToString();
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 13)
        {
            if (Global.Zen >= 500)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.WarriorArmor1 += 1;
                Global.Zen -= 500;
                Bought5 = 1;
                InShock5.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 14)
        {
            if (Global.Zen >= 1000)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.WarriorArmor2 += 1;
                Global.Zen -= 1000;
                Bought10 = 1;
                InShock10.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
        else if (BuyIndex == 15)
        {
            if (Global.Zen >= 1500)
            {
                BuyFX.Play();
                BuyAskPanel.SetActive(false);
                Global.WarriorArmor3 += 1;
                Global.Zen -= 1500;
                Bought15 = 1;
                InShock15.text = "In shock: 0";
                MessageText.text = "Good luck with the new weapon!!!";
                StartCoroutine(DelayBuy());
            }
            else
            {
                ClickFX.Play();
                MessageText.text = "You don't have enough Zen";
                BuyAskPanel.SetActive(false);
                StartCoroutine(DelayBuy());
            }
        }
    }

    public void CancerBuyItem()
    {
        ClickFX.Play();
        BuyAskPanel.SetActive(false);
    }

    public void CloseWeaponStorePanel()
    {
        ClickFX.Play();
        WeaponStorePanel.SetActive(false);
        HubController.BusyHub = false;
    }

    IEnumerator DelayBuy()
    {
        yield return new WaitForSeconds(2f);
        MessageText.text = "Enjoy my weapon!!!";
        stop = false;
    }
}
