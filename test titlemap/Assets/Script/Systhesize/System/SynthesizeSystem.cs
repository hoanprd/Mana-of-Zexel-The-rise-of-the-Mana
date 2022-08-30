using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SynthesizeSystem : MonoBehaviour
{
    public GameObject spanel1;
    public GameObject spanel2;
    public GameObject showr2;
    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;
    public Text num5;
    public Text num6;
    public Text num7;
    public Text num8;
    public Text num9;
    public Text num10;
    public Text num11;
    public Text num16;
    public Text showr1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*num1.text = PlayerPrefs.GetInt("SDL") + "";
        num2.text = PlayerPrefs.GetInt("SPW") + "";
        num3.text = PlayerPrefs.GetInt("SMD") + "";
        num4.text = PlayerPrefs.GetInt("SPW") + "";
        num5.text = PlayerPrefs.GetInt("SHP") + "";
        num6.text = PlayerPrefs.GetInt("SMP") + "";
        num7.text = PlayerPrefs.GetInt("SHP") + "";
        num8.text = PlayerPrefs.GetInt("SMP") + "";
        num9.text = PlayerPrefs.GetInt("SEP") + "";
        num10.text = PlayerPrefs.GetInt("SI") + "";
        num11.text = PlayerPrefs.GetInt("SMG") + "";
        num16.text = PlayerPrefs.GetInt("SB") + "";*/

        num1.text = ContainerController.DriedLeaves + "";
        num2.text = ContainerController.PureWater + "";
        num3.text = ContainerController.MorningDrop + "";
        num4.text = ContainerController.PureWater + "";
        num5.text = ContainerController.HealPotion + "";
        num6.text = ContainerController.ManaPotion + "";
        num7.text = ContainerController.HealPotion + "";
        num8.text = ContainerController.ManaPotion + "";
        num9.text = ContainerController.ElixirPotion + "";
        num10.text = ContainerController.Iron + "";
        num11.text = ContainerController.ManaGem + "";
        num16.text = ContainerController.Bom + "";
    }
    public void BackButton()
    {
        spanel1.SetActive(false);
        spanel2.SetActive(false);
    }
    public void SynthesizeButton1()
    {
        /*if(PlayerPrefs.GetInt("SDL") > 0 && PlayerPrefs.GetInt("SPW") > 0)
        {
            //PlayerPrefs.SetInt("SDL", PlayerPrefs.GetInt("SDL") - 1);
            //PlayerPrefs.SetInt("SPW", PlayerPrefs.GetInt("SPW") - 1);
            //PlayerPrefs.SetInt("SHP", PlayerPrefs.GetInt("SHP") + 1);
            ContainerController.DriedLeaves -= 1;
            ContainerController.PureWater -= 1;
            ContainerController.HealPotion += 1;
            
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }*/
        if (ContainerController.DriedLeaves > 0 && ContainerController.PureWater > 0)
        {
            ContainerController.DriedLeaves -= 1;
            ContainerController.PureWater -= 1;
            ContainerController.HealPotion += 1;

            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }
    /*public void SynthesizeButton2()
    {
        if (PlayerPrefs.GetInt("SMD") > 0 && PlayerPrefs.GetInt("SPW") > 0)
        {
            //PlayerPrefs.SetInt("SMD", PlayerPrefs.GetInt("SMD") - 1);
            //PlayerPrefs.SetInt("SPW", PlayerPrefs.GetInt("SPW") - 1);
            //PlayerPrefs.SetInt("SMP", PlayerPrefs.GetInt("SMP") + 1);
            ContainerController.MorningDrop -= 1;
            ContainerController.PureWater -= 1;
            ContainerController.ManaPotion += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }*/

    public void SynthesizeButton2()
    {
        if (ContainerController.MorningDrop > 0 && ContainerController.PureWater > 0)
        {
            ContainerController.MorningDrop -= 1;
            ContainerController.PureWater -= 1;
            ContainerController.ManaPotion += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    /*public void SynthesizeButton3()
    {
        if (PlayerPrefs.GetInt("SHP") > 0 && PlayerPrefs.GetInt("SMP") > 0)
        {
            //PlayerPrefs.SetInt("SHP", PlayerPrefs.GetInt("SHP") - 1);
            //PlayerPrefs.SetInt("SMP", PlayerPrefs.GetInt("SMP") - 1);
            //PlayerPrefs.SetInt("SEP", PlayerPrefs.GetInt("SEP") + 1);
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }*/

    public void SynthesizeButton3()
    {
        if (ContainerController.HealPotion > 0 && ContainerController.ManaPotion > 0)
        {
            ContainerController.HealPotion -= 1;
            ContainerController.ManaPotion -= 1;
            ContainerController.ElixirPotion += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    /*public void SynthesizeButton4()
    {
        if (PlayerPrefs.GetInt("SI") > 0 && PlayerPrefs.GetInt("SMG") > 0)
        {
            //PlayerPrefs.SetInt("SI", PlayerPrefs.GetInt("SI") - 1);
            //PlayerPrefs.SetInt("SMG", PlayerPrefs.GetInt("SMG") - 1);
            //PlayerPrefs.SetInt("SB", PlayerPrefs.GetInt("SB") + 1);
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }*/

    public void SynthesizeButton4()
    {
        if (ContainerController.Iron > 0 && ContainerController.ManaGem > 0)
        {
            ContainerController.Iron -= 1;
            ContainerController.ManaGem -= 1;
            ContainerController.Bom += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void RightButton1()
    {
        spanel1.SetActive(false);
        spanel2.SetActive(true);
    }
    public void LeftButton2()
    {
        spanel2.SetActive(false);
        spanel1.SetActive(true);
    }
    void delay1()
    {
        showr2.SetActive(false);
    }
}
