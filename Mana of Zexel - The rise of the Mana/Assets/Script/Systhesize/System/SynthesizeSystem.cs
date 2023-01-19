using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SynthesizeSystem : MonoBehaviour
{
    public GameObject[] Slide;
    public GameObject showr2;
    public GameObject ManaSynPanel;
    public GameObject SynDetailPanel;
    public GameObject RBHideSlide2, RBHideSlide3;
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
    public Text num23;
    public Text num24;
    public Text num25;
    public Text num26;
    public Text num27;
    public Text num28;
    public Text num29;
    public Text num30, num31, num32,num33, num34, num35, num36, num37, num38, num39, num40;
    public Text num41, num42, num43, num44, num45, num46, num47, num48, num49, num50, num51, num52;
    public Text num53, num54, num55, num56, num57, num58, num59, num60, num61;
    public Text num62, num63, num64, num65, num66, num67, num68, num69, num70, num71, num72, num73;
    public Text num74, num75, num76, num77, num78, num79, num80, num81, num82, num83, num84, num85;

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
    public int SlideIndex = 0, SynBugStop = 0;

    // Start is called before the first frame update
    void Start()
    {
        ManaSynSlider.maxValue = 100;
        ManaFireSynSlider.maxValue = 100;
        ManaIceSynSlider.maxValue = 100;

        if (CutscenesController.cus12 == 0)
        {
            RBHideSlide2.SetActive(false);
        }
        if (CutscenesController.cus20 == 0)
        {
            RBHideSlide3.SetActive(false);
        }

        SlideIndex = 0;
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
        num23.text = "2/" + ContainerController.ScorpionVenom;
        num24.text = "2/" + ContainerController.ElixirPotion;
        num25.text = "" + ContainerController.VenomKiller;
        num26.text = "1/" + ContainerController.String;
        num27.text = "1/" + ContainerController.ManaGem;
        num28.text = "1/" + ContainerController.GuardianFeather;
        num29.text = "" + ContainerController.ManaNecklace;
        num30.text = "4/" + ContainerController.Iron;
        num31.text = "2/" + ContainerController.Wood;
        num32.text = "4/" + ContainerController.ManaGem;
        num33.text = "" + ContainerController.ManaGenerator;
        num34.text = "1/" + ContainerController.Iron;
        num35.text = "2/" + ContainerController.ManaOre;
        num36.text = "" + ContainerController.Baxiata;
        num37.text = "2/" + ContainerController.ManaCrystal;
        num38.text = "1/" + ContainerController.InfernoSand;
        num39.text = "2/" + ContainerController.Baxiata;
        num40.text = "" + ContainerController.BaxiataGem;
        num41.text = "2/" + ContainerController.FireOre;
        num42.text = "2/" + ContainerController.IceOre;
        num43.text = "1/" + ContainerController.Baxiata;
        num44.text = "" + ContainerController.Photonria;
        num45.text = "4/" + ContainerController.GoldenFeather;
        num46.text = "4/" + ContainerController.IceLeather;
        num47.text = "2/" + ContainerController.ManaCloth;
        //num48.text = "" + ContainerController.Photonria;
        num49.text = "2/" + ContainerController.RedManaCrystal;
        num50.text = "2/" + ContainerController.BlueManaCrystal;
        num51.text = "2/" + ContainerController.Photonria;
        num52.text = "" + ContainerController.PhotonriaGem;
        num53.text = "2/" + ContainerController.ManaLiquid;
        num54.text = "2/" + ContainerController.PureWater;
        num55.text = "" + ContainerController.ManaLiquidCatalyst;
        num56.text = "2/" + ContainerController.RedManaSlimeBall;
        num57.text = "2/" + ContainerController.PureWater;
        num58.text = "" + ContainerController.RedLiquidCatalyst;
        num59.text = "2/" + ContainerController.BlueManaSlimeBall;
        num60.text = "2/" + ContainerController.PureWater;
        num61.text = "" + ContainerController.BlueLiquidCatalyst;
        num62.text = "" + ContainerController.ManaCoreFireZexel;
        num63.text = "2/" + ContainerController.RedManaCrystal;
        num64.text = "2/" + ContainerController.RedLiquidCatalyst;
        num65.text = "" + ContainerController.ManaCoreFireVayne;
        num66.text = "" + ContainerController.ManaCoreIceZexel;
        num67.text = "2/" + ContainerController.BlueManaCrystal;
        num68.text = "2/" + ContainerController.BlueLiquidCatalyst;
        num69.text = "" + ContainerController.ManaCoreIceVayne;
        num70.text = "2/" + ContainerController.Obsidian;
        num71.text = "3/" + ContainerController.GoldenFeather;
        num72.text = "2/" + ContainerController.Rock;
        num73.text = "" + ContainerController.PureObsidian;
        num74.text = "4/" + ContainerController.Iron;
        num75.text = "2/" + ContainerController.Wood;
        num76.text = "4/" + ContainerController.RedManaCrystal;
        num77.text = "" + ContainerController.FireManaGenerator;
        num78.text = "4/" + ContainerController.Iron;
        num79.text = "2/" + ContainerController.Wood;
        num80.text = "4/" + ContainerController.BlueManaCrystal;
        num81.text = "" + ContainerController.IceManaGenerator;
        num82.text = "4/" + ContainerController.NatureGrass;
        num83.text = "4/" + ContainerController.GoldenFeather;
        num84.text = "2/" + ContainerController.Wheat;
        num85.text = "" + ContainerController.PowderOfLife;

        ManaSynSlider.value = ManaSynthesize;
        ManaFireSynSlider.value = ManaFireSynthesize;
        ManaIceSynSlider.value = ManaIceSynthesize;

        ManaSynText.text = ManaSynthesize.ToString();
        ManaFireSynText.text = ManaFireSynthesize.ToString();
        ManaIceSynText.text = ManaIceSynthesize.ToString();
    }
    
    public void BackButton()
    {
        SlideIndex = 0;
        for (int i = 0; i < Slide.Length; i++)
        {
            Slide[i].SetActive(false);
        }

        ManaSynPanel.SetActive(false);
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

    public void ScorpionVenomDetail()
    {
        SynDetailPanelText.text = "Scorpion venom\n\n\nThe tail of the extremely poisonous scorpion can be found by defeating the inferno scorpion";
        SynDetailPanel.SetActive(true);
    }
    public void GuardianFeatherDetail()
    {
        SynDetailPanelText.text = "Guardian feather\n\n\nA gift left by the mana guardian";
        SynDetailPanel.SetActive(true);
    }

    public void ManaOreDetail()
    {
        SynDetailPanelText.text = "Mana ore\n\n\nA mineral that can be found in mana gate";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCrystalDetail()
    {
        SynDetailPanelText.text = "Mana crystal\n\n\nA crystal containing mana can be found in the mana temple";
        SynDetailPanel.SetActive(true);
    }

    public void InfernoSandDetail()
    {
        SynDetailPanelText.text = "Inferno sand\n\n\nSpecial sand with high heat found in inferno desert";
        SynDetailPanel.SetActive(true);
    }

    public void FireOreDetail()
    {
        SynDetailPanelText.text = "Fire ore\n\n\nThe ore containing fire elemental mana can be found in inferno volcano";
        SynDetailPanel.SetActive(true);
    }

    public void IceOreDetail()
    {
        SynDetailPanelText.text = "Ice ore\n\n\nThe ore containing fire elemental mana can be found in inferno ice";
        SynDetailPanel.SetActive(true);
    }

    public void GoldenFeatherDetail()
    {
        SynDetailPanelText.text = "Golden feather\n\n\nFeather type that can be obtained by defeating fire fang in inferno volcano";
        SynDetailPanel.SetActive(true);
    }

    public void IceLeatherDetail()
    {
        SynDetailPanelText.text = "Ice leather\n\n\nLeather type that can be obtained by defeating ice fang in inferno ice";
        SynDetailPanel.SetActive(true);
    }

    public void RedManaCrystalDetail()
    {
        SynDetailPanelText.text = "Red mana crystal\n\n\nA crystal containing fire elemental mana can be found deep inside the volcanic cave at inferno volcano";
        SynDetailPanel.SetActive(true);
    }

    public void BlueManaCrystalDetail()
    {
        SynDetailPanelText.text = "Blue mana crystal\n\n\nA crystal containing ice elemental mana can be found deep inside the ice cave at inferno ice";
        SynDetailPanel.SetActive(true);
    }

    public void ManaLiquidDetail()
    {
        SynDetailPanelText.text = "Mana liquid\n\n\nA liquid obtained by defeating slimes at the mana gate";
        SynDetailPanel.SetActive(true);
    }

    public void RedManaSlimeBallDetail()
    {
        SynDetailPanelText.text = "Red mana slime ball\n\n\nA slime obtained by defeating red slimes deep inside a volcanic cave in inferno volcano";
        SynDetailPanel.SetActive(true);
    }

    public void BlueManaSlimeBallDetail()
    {
        SynDetailPanelText.text = "Blue mana slime ball\n\n\nA slime obtained by defeating red slimes deep inside a ice cave in inferno ice";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCoreFireZexelDetail()
    {
        SynDetailPanelText.text = "Mana core fire Zexel\n\n\nFlame mana energy core created by Zexel";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCoreIceZexelDetail()
    {
        SynDetailPanelText.text = "Mana core ice Zexel\n\n\nIce mana energy core created by Zexel";
        SynDetailPanel.SetActive(true);
    }

    public void ObsidianDetail()
    {
        SynDetailPanelText.text = "Obsidian\n\n\nA natural form of volcanic glass created in the form of erupting igneous rock";
        SynDetailPanel.SetActive(true);
    }

    public void RockDetail()
    {
        SynDetailPanelText.text = "Rock\n\n\nIs a mineral commonly found in cliffs";
        SynDetailPanel.SetActive(true);
    }

    public void NatureGrassDetail()
    {
        SynDetailPanelText.text = "Nature grass\n\n\nA natural herb that can make special medicines can be found in alta inferno";
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

    public void ManaClothDetail()
    {
        SynDetailPanelText.text = "Mana cloth\n\n\nA culinary specialty made from Vayne's alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void ManaShieldDetail()
    {
        SynDetailPanelText.text = "Mana shield\n\n\nA shield made of mana";
        SynDetailPanel.SetActive(true);
    }

    public void VenomKillerDetail()
    {
        SynDetailPanelText.text = "Venom killer\n\n\nSpecial medicine for the poison of scorpions";
        SynDetailPanel.SetActive(true);
    }

    public void ManaNecklaceDetail()
    {
        SynDetailPanelText.text = "Mana necklace\n\n\nThe mana necklace helps the user to fix the flow of mana and is a piece of jewelry";
        SynDetailPanel.SetActive(true);
    }

    public void ManaGeneratorDetail()
    {
        SynDetailPanelText.text = "Mana generator\n\n\nA mana transmitter and receiver makes mana recovery easier";
        SynDetailPanel.SetActive(true);
    }

    public void BaxiataDetail()
    {
        SynDetailPanelText.text = "Baxiata\n\n\nMetal ingots that are stronger than iron are made from minerals containing mana";
        SynDetailPanel.SetActive(true);
    }

    public void BaxiataGemDetail()
    {
        SynDetailPanelText.text = "Baxiata gem\n\n\nA precious gem extracted from a crystal containing mana";
        SynDetailPanel.SetActive(true);
    }

    public void PhotonriaDetail()
    {
        SynDetailPanelText.text = "Photonria\n\n\nA metal ingot synthesized from ores containing the element mana";
        SynDetailPanel.SetActive(true);
    }

    public void PhotonriaGemDetail()
    {
        SynDetailPanelText.text = "Photonria gem\n\n\nA precious gem extracted from a crystal containing the element mana";
        SynDetailPanel.SetActive(true);
    }

    public void ManaLiquidCatalystDetail()
    {
        SynDetailPanelText.text = "Mana liquid catalyst\n\n\nA catalyst extracted from slimes";
        SynDetailPanel.SetActive(true);
    }

    public void RedLiquidCatalystDetail()
    {
        SynDetailPanelText.text = "Red liquid catalyst\n\n\nA catalyst extracted from red slime";
        SynDetailPanel.SetActive(true);
    }

    public void BlueLiquidCatalystDetail()
    {
        SynDetailPanelText.text = "Blue liquid catalyst\n\n\nA catalyst extracted from blue slime";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCoreFireVayneDetail()
    {
        SynDetailPanelText.text = "Mana core fire Vayne\n\n\nFlame mana energy core created by Vayne";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCoreIceVayneDetail()
    {
        SynDetailPanelText.text = "Mana core ice Vayne\n\n\nIce mana energy core created by Vayne";
        SynDetailPanel.SetActive(true);
    }

    public void PureObsidianDetail()
    {
        SynDetailPanelText.text = "Blue liquid catalyst\n\n\nA form of pure glass in the form of stone";
        SynDetailPanel.SetActive(true);
    }

    public void FireManaGeneratorDetail()
    {
        SynDetailPanelText.text = "Fire mana generator\n\n\nA kind of mana transmitter and receiver containing fire element";
        SynDetailPanel.SetActive(true);
    }

    public void IceManaGeneratorDetail()
    {
        SynDetailPanelText.text = "Ice mana generator\n\n\nA kind of mana transmitter and receiver containing ice element";
        SynDetailPanel.SetActive(true);
    }

    public void PowderOfLifeDetail()
    {
        SynDetailPanelText.text = "Powder of life\n\n\nA powder that can give life if it is further prepared";
        SynDetailPanel.SetActive(true);
    }

    public void CloseSynDetailPanel()
    {
        SynDetailPanel.SetActive(false);
    }

    public void SynthesizeButton1()
    {
        if (ContainerController.DriedLeaves > 0 && ContainerController.PureWater > 0 && ContainerController.HealPotion < 4)
        {
            ContainerController.DriedLeaves -= 1;
            ContainerController.PureWater -= 1;
            ContainerController.HealPotion += 1;

            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.HealPotion == 4)
        {
            showr2.SetActive(true);
            showr1.text = "Item limit reached!";
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
        if (ContainerController.MorningDrop > 0 && ContainerController.PureWater > 0 && ContainerController.ManaPotion < 4)
        {
            ContainerController.MorningDrop -= 1;
            ContainerController.PureWater -= 1;
            ContainerController.ManaPotion += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaPotion == 4)
        {
            showr2.SetActive(true);
            showr1.text = "Item limit reached!";
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
        if (ContainerController.HealPotion > 0 && ContainerController.ManaPotion > 0 && ContainerController.ElixirPotion < 4)
        {
            ContainerController.HealPotion -= 1;
            ContainerController.ManaPotion -= 1;
            ContainerController.ElixirPotion += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ElixirPotion == 4)
        {
            showr2.SetActive(true);
            showr1.text = "Item limit reached!";
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
        if (ContainerController.Iron > 0 && ContainerController.ManaGem > 0 && CutscenesController.cus25 == 0 && CutscenesController.cus24 == 1 && SynBugStop == 0)
        {
            SynBugStop = 1;
            ContainerController.Iron -= 1;
            ContainerController.ManaGem -= 1;
            ContainerController.Bom += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Iron > 0 && ContainerController.ManaGem > 0 && ContainerController.Bom < 4)
        {
            ContainerController.Iron -= 1;
            ContainerController.ManaGem -= 1;
            ContainerController.Bom += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Bom == 4)
        {
            showr2.SetActive(true);
            showr1.text = "Item limit reached!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton5()
    {
        if (ContainerController.Wheat > 0 && ContainerController.PureWater > 0 && CutscenesController.cus48 == 0 && CutscenesController.cus47 == 1 && SynBugStop == 0)
        {
            SynBugStop = 1;
            ContainerController.Wheat -= 1;
            ContainerController.PureWater -= 1;
            ContainerController.Porridge += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Wheat > 0 && ContainerController.PureWater > 0)
        {
            ContainerController.Wheat -= 1;
            ContainerController.PureWater -= 1;
            ContainerController.Porridge += 1;
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

    public void SynthesizeButton6()
    {
        if (ContainerController.String > 0 && ContainerController.ManaGem > 0)
        {
            ContainerController.String -= 1;
            ContainerController.ManaGem -= 1;
            ContainerController.ManaCloth += 1;
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

    public void SynthesizeButton7()
    {
        if (ContainerController.Iron > 0 && ContainerController.Wood > 0 && ContainerController.ManaCloth > 0)
        {
            ContainerController.Iron -= 1;
            ContainerController.Wood -= 1;
            ContainerController.ManaCloth -= 1;
            ContainerController.ManaShield += 1;
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

    public void SynthesizeButton8()
    {
        if (ContainerController.ScorpionVenom >= 2 && ContainerController.ElixirPotion >= 2)
        {
            ContainerController.ScorpionVenom -= 2;
            ContainerController.ElixirPotion -= 2;
            ContainerController.VenomKiller += 1;
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

    public void SynthesizeButton9()
    {
        if (ContainerController.String > 0 && ContainerController.ManaGem > 0 && ContainerController.GuardianFeather > 0 && CutscenesController.cus54 == 0 && CutscenesController.cus53 == 1 && SynBugStop == 0)
        {
            SynBugStop = 1;
            ManaSynthesize -= 20;
            ContainerController.String -= 1;
            ContainerController.ManaGem -= 1;
            ContainerController.GuardianFeather -= 1;
            ContainerController.ManaNecklace += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.String > 0 && ContainerController.ManaGem > 0 && ContainerController.GuardianFeather > 0 && CutscenesController.cus54 == 0 && CutscenesController.cus53 == 0)
        {
            showr2.SetActive(true);
            showr1.text = "You can't systhesize this item yet!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton10()
    {
        if (ContainerController.Iron >= 4 && ContainerController.Wood >= 2 && ContainerController.ManaGem >= 4 && ManaSynthesize >= 80)
        {
            ManaSynthesize -= 80;
            ContainerController.Iron -= 4;
            ContainerController.Wood -= 2;
            ContainerController.ManaGem -= 4;
            ContainerController.ManaGenerator += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Iron >= 4 && ContainerController.Wood >= 2 && ContainerController.ManaGem >= 4 && ManaSynthesize < 80)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton11()
    {
        if (ContainerController.Iron > 0 && ContainerController.ManaOre >= 2)
        {
            ContainerController.Iron -= 1;
            ContainerController.ManaOre -= 2;
            ContainerController.Baxiata += 1;
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

    public void SynthesizeButton12()
    {
        if (ContainerController.ManaCrystal >= 2 && ContainerController.InfernoSand > 0 && ContainerController.Baxiata >= 2 && ManaSynthesize >= 20)
        {
            ManaSynthesize -= 20;
            ContainerController.ManaCrystal -= 2;
            ContainerController.InfernoSand -= 1;
            ContainerController.Baxiata -= 2;
            ContainerController.BaxiataGem += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaCrystal >= 2 && ContainerController.InfernoSand > 0 && ContainerController.Baxiata >= 2 && ManaSynthesize < 20)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton13()
    {
        if (ContainerController.FireOre >= 2 && ContainerController.IceOre >= 2 && ContainerController.Baxiata >= 1)
        {
            ContainerController.FireOre -= 2;
            ContainerController.IceOre -= 2;
            ContainerController.Baxiata -= 1;
            ContainerController.Photonria += 1;
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

    public void SynthesizeButton14()
    {
        if (ContainerController.GoldenFeather >= 4 && ContainerController.IceLeather >= 4 && ContainerController.ManaCloth >= 2)
        {
            ContainerController.GoldenFeather -= 4;
            ContainerController.IceLeather -= 4;
            ContainerController.ManaCloth -= 2;
            //ContainerController.Photonria += 1;
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

    public void SynthesizeButton15()
    {
        if (ContainerController.RedManaCrystal >= 2 && ContainerController.BlueManaCrystal >= 2 && ContainerController.Photonria >= 2 && ManaSynthesize >= 40)
        {
            ManaSynthesize -= 40;
            ContainerController.RedManaCrystal -= 2;
            ContainerController.BlueManaCrystal -= 2;
            ContainerController.Photonria -= 2;
            ContainerController.PhotonriaGem += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.RedManaCrystal >= 2 && ContainerController.BlueManaCrystal >= 2 && ContainerController.Photonria >= 2 && ManaSynthesize < 40)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton16()
    {
        if (ContainerController.ManaLiquid >= 2 && ContainerController.PureWater >= 2 && ManaSynthesize >= 20)
        {
            ManaSynthesize -= 20;
            ContainerController.ManaLiquid -= 2;
            ContainerController.PureWater -= 2;
            ContainerController.ManaLiquidCatalyst += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaLiquid >= 2 && ContainerController.PureWater >= 2 && ManaSynthesize < 20)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton17()
    {
        if (ContainerController.RedManaSlimeBall >= 2 && ContainerController.PureWater >= 2 && ManaSynthesize >= 20)
        {
            ManaSynthesize -= 20;
            ContainerController.RedManaSlimeBall -= 2;
            ContainerController.PureWater -= 2;
            ContainerController.RedLiquidCatalyst += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.RedManaSlimeBall >= 2 && ContainerController.PureWater >= 2 && ManaSynthesize < 20)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton18()
    {
        if (ContainerController.BlueManaSlimeBall >= 2 && ContainerController.PureWater >= 2 && ManaSynthesize >= 20)
        {
            ManaSynthesize -= 20;
            ContainerController.BlueManaSlimeBall -= 2;
            ContainerController.PureWater -= 2;
            ContainerController.BlueLiquidCatalyst += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.BlueManaSlimeBall >= 2 && ContainerController.PureWater >= 2 && ManaSynthesize < 20)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton19()
    {
        if (ContainerController.ManaCoreFireZexel > 0 && ContainerController.RedManaCrystal >= 2 && ContainerController.RedLiquidCatalyst >= 2 && ManaFireSynthesize >= 20 && SynBugStop == 0)
        {
            SynBugStop = 1;
            ManaFireSynthesize -= 20;
            ContainerController.RedManaCrystal -= 2;
            ContainerController.RedLiquidCatalyst -= 2;
            ContainerController.ManaCoreFireVayne += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaCoreFireZexel > 0 && ContainerController.RedManaCrystal >= 2 && ContainerController.RedLiquidCatalyst >= 2 && ManaFireSynthesize < 20)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton20()
    {
        if (ContainerController.ManaCoreIceZexel > 0 && ContainerController.BlueManaCrystal >= 2 && ContainerController.BlueLiquidCatalyst >= 2 && ManaIceSynthesize >= 20)
        {
            ManaIceSynthesize -= 20;
            ContainerController.BlueManaCrystal -= 2;
            ContainerController.BlueLiquidCatalyst -= 2;
            ContainerController.ManaCoreIceVayne += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaCoreIceZexel > 0 && ContainerController.BlueManaCrystal >= 2 && ContainerController.BlueLiquidCatalyst >= 2 && ManaIceSynthesize < 20)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton21()
    {
        if (ContainerController.Obsidian >= 2 && ContainerController.GoldenFeather >= 3 && ContainerController.Rock >= 2)
        {
            ContainerController.Obsidian -= 2;
            ContainerController.GoldenFeather -= 2;
            ContainerController.Rock -= 1;
            ContainerController.PureObsidian += 1;
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

    public void SynthesizeButton22()
    {
        if (ContainerController.Iron >= 4 && ContainerController.Wood >= 2 && ContainerController.RedManaCrystal >= 4 && ManaSynthesize >= 80)
        {
            ManaFireSynthesize -= 80;
            ContainerController.Iron -= 4;
            ContainerController.Wood -= 2;
            ContainerController.RedManaCrystal -= 4;
            ContainerController.FireManaGenerator += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaCoreIceZexel > 0 && ContainerController.BlueManaCrystal >= 2 && ContainerController.BlueLiquidCatalyst >= 2 && ManaSynthesize < 80)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton23()
    {
        if (ContainerController.Iron >= 4 && ContainerController.Wood >= 2 && ContainerController.BlueManaCrystal >= 4 && ManaSynthesize >= 80)
        {
            ManaIceSynthesize -= 80;
            ContainerController.Iron -= 4;
            ContainerController.Wood -= 2;
            ContainerController.BlueManaCrystal -= 4;
            ContainerController.IceManaGenerator += 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Iron >= 4 && ContainerController.Wood >= 2 && ContainerController.BlueManaCrystal >= 4 && ManaSynthesize < 80)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton24()
    {
        if (ContainerController.NatureGrass >= 4 && ContainerController.GoldenFeather >= 4 && ContainerController.Wheat >= 2)
        {
            ContainerController.NatureGrass -= 4;
            ContainerController.GoldenFeather -= 4;
            ContainerController.Wheat -= 2;
            ContainerController.PowderOfLife += 1;
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

    public void RightButton()
    {
        SlideIndex += 1;
        ShowSlide(SlideIndex);
    }
    public void LeftButton()
    {
        SlideIndex -= 1;
        ShowSlide(SlideIndex);
    }

    void ShowSlide(int index)
    {
        for (int i = 0; i < Slide.Length; i++)
        {
            if (i == index)
            {
                Slide[i].SetActive(true);
            }
            else
            {
                Slide[i].SetActive(false);
            }
        }
    }

    void delay1()
    {
        showr2.SetActive(false);
        if (CutscenesController.cus25 == 0 && CutscenesController.cus24 == 1)
        {
            ContainerController.Bom -= 1;
            SceneManager.LoadScene("Cutscenes");
        }
        if (CutscenesController.cus40 == 0 && CutscenesController.cus39 == 1)
        {
            ContainerController.VenomKiller -= 1;
            SceneManager.LoadScene("Cutscenes");
        }
        if (CutscenesController.cus48 == 0 && CutscenesController.cus47 == 1)
        {
            ContainerController.Porridge -= 1;
            SceneManager.LoadScene("Cutscenes");
        }
        if (CutscenesController.cus54 == 0 && CutscenesController.cus53 == 1)
        {
            ContainerController.ManaNecklace -= 1;
            SceneManager.LoadScene("Cutscenes");
        }
        if (CutscenesController.cus75 == 0 && CutscenesController.cus74 == 1)
        {
            SceneManager.LoadScene("Cutscenes");
        }
    }
}
