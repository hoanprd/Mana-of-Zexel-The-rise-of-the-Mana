using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SynthesizeSystem : MonoBehaviour
{
    public GameObject spanel1;
    public GameObject spanel2;
    public GameObject showr2;
    public GameObject ManaSynPanel;
    public GameObject SynDetailPanel;
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
    public Text num12;
    public Text num13;
    public Text num14;
    public Text num15;
    public Text num16;
    public Text num17;
    public Text num18;
    public Text num19;
    public Text num20;
    public Text num21;
    public Text num22;
    public Text showr1;
    public Slider ManaSynSlider;
    public Text ManaSynText;
    public Slider ManaFireSynSlider;
    public Text ManaFireSynText;
    public Slider ManaIceSynSlider;
    public Text ManaIceSynText;
    public Text SynDetailPanelText;
    public static int ManaSynthesize;
    public static int ManaFireSynthesize;
    public static int ManaIceSynthesize;

    // Start is called before the first frame update
    void Start()
    {
        ManaSynSlider.maxValue = 100;
        ManaFireSynSlider.maxValue = 100;
        ManaIceSynSlider.maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        num1.text = "1/" + ContainerController.DriedLeaves;
        num2.text = "1/" + ContainerController.PureWater;
        num3.text = "1/" + ContainerController.MorningDrop + "";
        num4.text = "1/" + ContainerController.PureWater + "";
        num5.text = ContainerController.HealPotion + "";
        num6.text = ContainerController.ManaPotion + "";
        num7.text = "1/" + ContainerController.HealPotion + "";
        num8.text = "1/" + ContainerController.ManaPotion + "";
        num9.text = ContainerController.ElixirPotion + "";
        num10.text = "2/" + ContainerController.Iron + "";
        num11.text = "2/" + ContainerController.ManaGem + "";
        num12.text = ContainerController.Bom + "";
        num13.text = "3/" + ContainerController.Wheat + "";
        num14.text = "2/" + ContainerController.PureWater + "";
        num15.text = ContainerController.Porridge + "";
        num16.text = "4/" + ContainerController.String + "";
        num17.text = "2/" + ContainerController.ManaGem + "";
        num18.text = ContainerController.ManaCloth + "";
        num19.text = "2/" + ContainerController.Iron;
        num20.text = "3/" + ContainerController.Wood;
        num21.text = "2/" + ContainerController.ManaCloth;
        num22.text = ContainerController.ManaShield + "";

        ManaSynSlider.value = ManaSynthesize;
        ManaFireSynSlider.value = ManaFireSynthesize;
        ManaIceSynSlider.value = ManaIceSynthesize;

        ManaSynText.text = ManaSynthesize.ToString();
        ManaFireSynText.text = ManaFireSynthesize.ToString();
        ManaIceSynText.text = ManaIceSynthesize.ToString();
    }
    
    public void BackButton()
    {
        spanel1.SetActive(false);
        spanel2.SetActive(false);
    }

    public void OpenManaSynPanel()
    {
        ManaSynPanel.SetActive(true);
    }

    public void CloseManaSynPanel()
    {
        ManaSynPanel.SetActive(false);
    }

    public void DriedLeavesDetail()
    {
        SynDetailPanelText.text = "Dried leave\n\n\nThis kind of leave can be find at Wishing hill";
        SynDetailPanel.SetActive(true);
    }

    public void MorningDropDetail()
    {
        SynDetailPanelText.text = "Morning drop\n\n\nMorning dew is usually gorgeous in Zexel town";
        SynDetailPanel.SetActive(true);
    }

    public void PureWaterDetail()
    {
        SynDetailPanelText.text = "Pure water\n\n\nWater sources that are indispensable for alchemy are found in areas with fountains";
        SynDetailPanel.SetActive(true);
    }

    public void IronDetail()
    {
        SynDetailPanelText.text = "Iron\n\n\nA cleaned mineral can only be found in the wishing forest";
        SynDetailPanel.SetActive(true);
    }

    public void ManaGemDetail()
    {
        SynDetailPanelText.text = "Mana gem\n\n\nA kind of mana obtained by defeating golems in the wishing forest";
        SynDetailPanel.SetActive(true);
    }

    public void WheatDetail()
    {
        SynDetailPanelText.text = "Wheat\n\n\nRice is an indispensable source of raw materials in villages especially Zexel town";
        SynDetailPanel.SetActive(true);
    }

    public void StringDetail()
    {
        SynDetailPanelText.text = "String\n\n\nA silk that can only be found in the wishing forest, zexel gate";
        SynDetailPanel.SetActive(true);
    }

    public void WoodDetail()
    {
        SynDetailPanelText.text = "Wood\n\n\nWood is often found in forests like wishing forest";
        SynDetailPanel.SetActive(true);
    }

    public void HealPotionDetail()
    {
        SynDetailPanelText.text = "Heal potion\n\n\nIt's the liquid solution to restore vitality created by alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void ManaPotionDetail()
    {
        SynDetailPanelText.text = "Mana potion\n\n\nIt's a liquid that restores mana created by alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void ElixirPotionDetail()
    {
        SynDetailPanelText.text = "Elixir potion\n\n\nThe type of liquid that can restore health and mana";
        SynDetailPanel.SetActive(true);
    }

    public void BomDetail()
    {
        SynDetailPanelText.text = "Bom\n\n\nA lethal weapon made from alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void PorridgeDetail()
    {
        SynDetailPanelText.text = "Porridge\n\n\nA culinary specialty made from Vayne's alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCurtainDetail()
    {
        SynDetailPanelText.text = "Mana curtain\n\n\nA culinary specialty made from Vayne's alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void ManaShieldDetail()
    {
        SynDetailPanelText.text = "Mana shield\n\n\nA shield made of mana";
        SynDetailPanel.SetActive(true);
    }

    public void CloseSynDetailPanel()
    {
        SynDetailPanel.SetActive(false);
    }

    public void SynthesizeButton1()
    {
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
