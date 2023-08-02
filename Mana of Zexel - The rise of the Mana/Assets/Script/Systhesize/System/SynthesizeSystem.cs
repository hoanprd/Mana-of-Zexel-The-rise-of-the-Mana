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
    public GameObject RBHideSlide1, RBHideSlide2, RBHideSlide3, RBHideSlide4, RBHideSlide5, RBHideSlide6, RBHideSlide7, RBHideSlide8;
    public GameObject[] Hide1, Hide2, Hide3, Hide4, Hide5;

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
    public Text num86, num87, num88, num89, num90, num91, num92, num93, num94, num95, num96, num97;
    public Text num98, num99, num100, num101, num102, num103, num104, num105;
    public Text num106, num107, num108, num109, num110, num111, num112, num113;

    public Text showr1;
    public Slider ManaSynSlider;
    public Text ManaSynText;
    public Slider ManaFireSynSlider;
    public Text ManaFireSynText;
    public Slider ManaIceSynSlider;
    public Text ManaIceSynText;
    public Text SynDetailPanelText;
    public AudioSource ClickFX, SynthesizeFX;

    public static int SynBugStop, ManaSynthesize, ManaFireSynthesize, ManaIceSynthesize;
    public int SlideIndex = 0;
    //public static bool BomCut, VenomKillerCut, PorridgeCut, ManaNecklaceCut, ManaFireCoreVayneCut, OmnipotentBoundaryCut;

    // Start is called before the first frame update
    void Start()
    {
        ManaSynSlider.maxValue = 100;
        ManaFireSynSlider.maxValue = 100;
        ManaIceSynSlider.maxValue = 100;

        /*BomCut = false;
        VenomKillerCut = false;
        PorridgeCut = false;
        ManaNecklaceCut = false;
        ManaFireCoreVayneCut = false;*/

        if (CutscenesController.cus12 == 0)
        {
            RBHideSlide1.SetActive(false);
        }
        if (CutscenesController.cus21 == 0)
        {
            RBHideSlide2.SetActive(false);
        }
        if (CutscenesController.cus56 == 0)
        {
            RBHideSlide3.SetActive(false);
        }
        if (CutscenesController.cus59 == 0)
        {
            RBHideSlide4.SetActive(false);
        }
        if (CutscenesController.cus72 == 0)
        {
            RBHideSlide5.SetActive(false);
        }
        if (CutscenesController.cus74 == 0)
        {
            RBHideSlide6.SetActive(false);
        }
        if (CutscenesController.cus88 == 0)
        {
            RBHideSlide7.SetActive(false);
        }
        if (CutscenesController.cus109 == 0)
        {
            RBHideSlide8.SetActive(false);
        }

        if (CutscenesController.cus18 == 0)
        {
            for (int i = 0; i < Hide1.Length; i++)
            {
                Hide1[i].SetActive(false);
            }
        }
        if (CutscenesController.cus39 == 0)
        {
            for (int i = 0; i < Hide2.Length; i++)
            {
                Hide2[i].SetActive(false);
            }
        }
        if (CutscenesController.cus53 == 0)
        {
            for (int i = 0; i < Hide3.Length; i++)
            {
                Hide3[i].SetActive(false);
            }
        }
        if (CutscenesController.cus86 == 0)
        {
            for (int i = 0; i < Hide4.Length; i++)
            {
                Hide4[i].SetActive(false);
            }
        }
        if (CutscenesController.cus131 == 0)
        {
            for (int i = 0; i < Hide5.Length; i++)
            {
                Hide5[i].SetActive(false);
            }
        }

        SlideIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        num1.text = "1/" + ContainerController.DriedLeaves;
        num2.text = "1/" + ContainerController.PureWater;
        num3.text =  ContainerController.HealPotion + "";
        num4.text = "1/" + ContainerController.MorningDrop;
        num5.text = "1/" + ContainerController.PureWater;
        num6.text = ContainerController.ManaPotion + "";
        num7.text = "1/" + ContainerController.HealPotion;
        num8.text = "1/" + ContainerController.ManaPotion;
        num9.text = ContainerController.ElixirPotion + "";

        num10.text = "2/" + ContainerController.Iron;
        num11.text = "2/" + ContainerController.ManaGem ;
        num12.text = ContainerController.Bom + "";
        num13.text = "3/" + ContainerController.Wheat;
        num14.text = "2/" + ContainerController.PureWater;
        num15.text = ContainerController.Porridge + "";
        num16.text = "4/" + ContainerController.String;
        num17.text = "2/" + ContainerController.ManaGem;
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
        num45.text = "2/" + ContainerController.RedManaCrystal;
        num46.text = "2/" + ContainerController.BlueManaCrystal;
        num47.text = "2/" + ContainerController.Photonria;
        num48.text = "" + ContainerController.PhotonriaGem;

        num49.text = "2/" + ContainerController.ManaLiquid;
        num50.text = "2/" + ContainerController.PureWater;
        num51.text = "" + ContainerController.ManaLiquidCatalyst;
        num52.text = "2/" + ContainerController.RedManaSlimeBall;
        num53.text = "2/" + ContainerController.PureWater;
        num54.text = "" + ContainerController.RedLiquidCatalyst;
        num55.text = "2/" + ContainerController.BlueManaSlimeBall;
        num56.text = "2/" + ContainerController.PureWater;
        num57.text = "" + ContainerController.BlueLiquidCatalyst;

        num58.text = "1/" + ContainerController.ManaCoreFireZexel;
        num59.text = "2/" + ContainerController.RedManaCrystal;
        num60.text = "2/" + ContainerController.RedLiquidCatalyst;
        num61.text = "" + ContainerController.ManaCoreFireVayne;
        num62.text = "1/" + ContainerController.ManaCoreIceZexel;
        num63.text = "2/" + ContainerController.BlueManaCrystal;
        num64.text = "2/" + ContainerController.BlueLiquidCatalyst;
        num65.text = "" + ContainerController.ManaCoreIceVayne;
        num66.text = "2/" + ContainerController.Obsidian;
        num67.text = "3/" + ContainerController.GoldenFeather;
        num68.text = "2/" + ContainerController.Rock;
        num69.text = "" + ContainerController.PureObsidian;

        num70.text = "2/" + ContainerController.Porridge;
        num71.text = "2/" + ContainerController.ScorpionVenom;
        num72.text = "2/" + ContainerController.ElixirPotion;
        num73.text = "" + ContainerController.BackPainMedicine;
        num74.text = "1/" + ContainerController.PurifyingWater;
        num75.text = "2/" + ContainerController.PhotonriaGem;
        num76.text = "2/" + ContainerController.PureObsidian;
        num77.text = "" + ContainerController.PurifyingPotion;
        num78.text = "4/" + ContainerController.NatureGrass;
        num79.text = "4/" + ContainerController.GoldenFeather;
        num80.text = "2/" + ContainerController.Wheat;
        num81.text = "" + ContainerController.PowderOfLife;

        num82.text = "4/" + ContainerController.Iron;
        num83.text = "2/" + ContainerController.Wood;
        num84.text = "4/" + ContainerController.RedManaCrystal;
        num85.text = "" + ContainerController.FireManaGenerator;
        num86.text = "4/" + ContainerController.Iron;
        num87.text = "2/" + ContainerController.Wood;
        num88.text = "4/" + ContainerController.BlueManaCrystal;
        num89.text = "" + ContainerController.IceManaGenerator;
        num90.text = "1/" + ContainerController.BrokenManaDetector;
        num91.text = "4/" + ContainerController.BaxiataGem;
        num92.text = "4/" + ContainerController.ManaLiquidCatalyst;
        num93.text = "" + ContainerController.ManaDetector;

        num94.text = "2/" + ContainerController.HealPotion;
        num95.text = "1/" + ContainerController.BaxiataGem;
        num96.text = "2/" + ContainerController.RedLiquidCatalyst;
        num97.text = "" + ContainerController.HoliHP;
        num98.text = "2/" + ContainerController.ManaPotion;
        num99.text = "1/" + ContainerController.BaxiataGem;
        num100.text = "2/" + ContainerController.BlueLiquidCatalyst;
        num101.text = "" + ContainerController.HoliMP;
        num102.text = "2/" + ContainerController.ElixirPotion;
        num103.text = "2/" + ContainerController.ManaLiquidCatalyst;
        num104.text = "1/" + ContainerController.PowderOfLife;
        num105.text = "" + ContainerController.ReincarnationLife;

        num106.text = "2/" + ContainerController.Bom;
        num107.text = "1/" + ContainerController.PhotonriaGem;
        num108.text = "1/" + ContainerController.PureObsidian;
        num109.text = "" + ContainerController.UltraBom;
        num110.text = "4/" + ContainerController.ManaEagleFeather;
        num111.text = "2/" + ContainerController.IceLeather;
        num112.text = "2" + ContainerController.ManaCloth;
        num113.text = "" + ContainerController.OmnipotentBoundary;

        ManaSynSlider.value = ManaSynthesize;
        ManaFireSynSlider.value = ManaFireSynthesize;
        ManaIceSynSlider.value = ManaIceSynthesize;

        ManaSynText.text = ManaSynthesize.ToString();
        ManaFireSynText.text = ManaFireSynthesize.ToString();
        ManaIceSynText.text = ManaIceSynthesize.ToString();
    }
    
    public void BackButton()
    {
        ClickFX.Play();
        SlideIndex = 0;
        for (int i = 0; i < Slide.Length; i++)
        {
            Slide[i].SetActive(false);
        }

        ManaSynPanel.SetActive(false);
        HubController.BusyHub = false;
    }

    public void OpenManaSynPanel()
    {
        ClickFX.Play();
        ManaSynPanel.SetActive(true);
    }

    public void CloseManaSynPanel()
    {
        ClickFX.Play();
        ManaSynPanel.SetActive(false);
    }

    public void DriedLeavesDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Dried leave\n\n\nThis kind of leave can be find at Wishing hill";
        SynDetailPanel.SetActive(true);
    }

    public void MorningDropDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Morning drop\n\n\nMorning dew is usually gorgeous in Zexel town";
        SynDetailPanel.SetActive(true);
    }

    public void PureWaterDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Pure water\n\n\nWater sources that are indispensable for alchemy are found in areas with fountains";
        SynDetailPanel.SetActive(true);
    }

    public void IronDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Iron\n\n\nA cleaned mineral can only be found in the wishing forest";
        SynDetailPanel.SetActive(true);
    }

    public void ManaGemDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana gem\n\n\nA kind of mana obtained by defeating golems in the wishing forest";
        SynDetailPanel.SetActive(true);
    }

    public void WheatDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Wheat\n\n\nRice is an indispensable source of raw materials in villages especially Zexel town";
        SynDetailPanel.SetActive(true);
    }

    public void StringDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "String\n\n\nA silk that can only be found in the wishing forest, zexel gate";
        SynDetailPanel.SetActive(true);
    }

    public void WoodDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Wood\n\n\nWood is often found in forests like wishing forest";
        SynDetailPanel.SetActive(true);
    }

    public void ScorpionVenomDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Scorpion venom\n\n\nThe tail of the extremely poisonous scorpion can be found by defeating the inferno scorpion";
        SynDetailPanel.SetActive(true);
    }
    public void GuardianFeatherDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Guardian feather\n\n\nA gift left by the mana guardian";
        SynDetailPanel.SetActive(true);
    }

    public void ManaOreDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana ore\n\n\nA mineral that can be found in mana gate";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCrystalDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana crystal\n\n\nA crystal containing mana can be found in the mana temple";
        SynDetailPanel.SetActive(true);
    }

    public void InfernoSandDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Inferno sand\n\n\nSpecial sand with high heat found in inferno desert";
        SynDetailPanel.SetActive(true);
    }

    public void FireOreDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Fire ore\n\n\nThe ore containing fire elemental mana can be found in inferno volcano";
        SynDetailPanel.SetActive(true);
    }

    public void IceOreDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Ice ore\n\n\nThe ore containing fire elemental mana can be found in inferno ice";
        SynDetailPanel.SetActive(true);
    }

    public void GoldenFeatherDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Golden feather\n\n\nFeather type that can be obtained by defeating fire fang in inferno volcano";
        SynDetailPanel.SetActive(true);
    }

    public void IceLeatherDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Ice leather\n\n\nLeather type that can be obtained by defeating ice fang in inferno ice";
        SynDetailPanel.SetActive(true);
    }

    public void RedManaCrystalDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Red mana crystal\n\n\nA crystal containing fire elemental mana can be found deep inside the volcanic cave at inferno volcano";
        SynDetailPanel.SetActive(true);
    }

    public void BlueManaCrystalDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Blue mana crystal\n\n\nA crystal containing ice elemental mana can be found deep inside the ice cave at inferno ice";
        SynDetailPanel.SetActive(true);
    }

    public void ManaLiquidDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana liquid\n\n\nA liquid obtained by defeating slimes at the mana gate";
        SynDetailPanel.SetActive(true);
    }

    public void RedManaSlimeBallDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Red mana slime ball\n\n\nA slime obtained by defeating red slimes deep inside a volcanic cave in inferno volcano";
        SynDetailPanel.SetActive(true);
    }

    public void BlueManaSlimeBallDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Blue mana slime ball\n\n\nA slime obtained by defeating red slimes deep inside a ice cave in inferno ice";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCoreFireZexelDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana core fire Zexel\n\n\nFlame mana energy core created by Zexel";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCoreIceZexelDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana core ice Zexel\n\n\nIce mana energy core created by Zexel";
        SynDetailPanel.SetActive(true);
    }

    public void ObsidianDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Obsidian\n\n\nA natural form of volcanic glass created in the form of erupting igneous rock";
        SynDetailPanel.SetActive(true);
    }

    public void RockDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Rock\n\n\nIs a mineral commonly found in cliffs";
        SynDetailPanel.SetActive(true);
    }

    public void NatureGrassDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Nature grass\n\n\nA natural herb that can make special medicines can be found in alta inferno";
        SynDetailPanel.SetActive(true);
    }

    public void ManaEagleFeatherDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana eagle feather\n\n\nThe type of feathers that can be obtained by defeating the eagle on the mana cliff";
        SynDetailPanel.SetActive(true);
    }

    public void HealPotionDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Heal potion\n\n\nIt's the liquid solution to restore vitality created by alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void ManaPotionDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana potion\n\n\nIt's a liquid that restores mana created by alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void ElixirPotionDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Elixir potion\n\n\nThe type of liquid that can restore health and mana";
        SynDetailPanel.SetActive(true);
    }

    public void BomDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Bom\n\n\nA lethal weapon made from alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void PorridgeDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Porridge\n\n\nA culinary specialty made from Vayne's alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void ManaClothDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana cloth\n\n\nA culinary specialty made from Vayne's alchemy";
        SynDetailPanel.SetActive(true);
    }

    public void ManaShieldDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana shield\n\n\nA shield made of mana";
        SynDetailPanel.SetActive(true);
    }

    public void VenomKillerDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Venom killer\n\n\nSpecial medicine for the poison of scorpions";
        SynDetailPanel.SetActive(true);
    }

    public void ManaNecklaceDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana necklace\n\n\nThe mana necklace helps the user to fix the flow of mana and is a piece of jewelry";
        SynDetailPanel.SetActive(true);
    }

    public void ManaGeneratorDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana generator\n\n\nA mana transmitter and receiver makes mana recovery easier";
        SynDetailPanel.SetActive(true);
    }

    public void BaxiataDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Baxiata\n\n\nMetal ingots that are stronger than iron are made from minerals containing mana";
        SynDetailPanel.SetActive(true);
    }

    public void BaxiataGemDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Baxiata gem\n\n\nA precious gem extracted from a crystal containing mana";
        SynDetailPanel.SetActive(true);
    }

    public void PhotonriaDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Photonria\n\n\nA metal ingot synthesized from ores containing the element mana";
        SynDetailPanel.SetActive(true);
    }

    public void PhotonriaGemDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Photonria gem\n\n\nA precious gem extracted from a crystal containing the element mana";
        SynDetailPanel.SetActive(true);
    }

    public void ManaLiquidCatalystDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana liquid catalyst\n\n\nA catalyst extracted from slimes";
        SynDetailPanel.SetActive(true);
    }

    public void RedLiquidCatalystDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Red liquid catalyst\n\n\nA catalyst extracted from red slime";
        SynDetailPanel.SetActive(true);
    }

    public void BlueLiquidCatalystDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Blue liquid catalyst\n\n\nA catalyst extracted from blue slime";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCoreFireVayneDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana core fire Vayne\n\n\nFlame mana energy core created by Vayne";
        SynDetailPanel.SetActive(true);
    }

    public void ManaCoreIceVayneDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana core ice Vayne\n\n\nIce mana energy core created by Vayne";
        SynDetailPanel.SetActive(true);
    }

    public void PureObsidianDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Blue liquid catalyst\n\n\nA form of pure glass in the form of stone";
        SynDetailPanel.SetActive(true);
    }

    public void BackPainMedicineDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Back pain medicine\n\n\nAn anti-back pain medicine that specializes in treating back pain";
        SynDetailPanel.SetActive(true);
    }

    public void PurifyingWaterDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Purifying water\n\n\nA water capable of purifying magic";
        SynDetailPanel.SetActive(true);
    }

    public void PurifyingPotionDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Purifying potion\n\n\nA potion that can purify dark magic";
        SynDetailPanel.SetActive(true);
    }

    public void PowderOfLifeDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Powder of life\n\n\nA powder that can give life if it is further prepared";
        SynDetailPanel.SetActive(true);
    }

    public void FireManaGeneratorDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Fire mana generator\n\n\nA kind of mana transmitter and receiver containing fire element";
        SynDetailPanel.SetActive(true);
    }

    public void IceManaGeneratorDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Ice mana generator\n\n\nA kind of mana transmitter and receiver containing ice element";
        SynDetailPanel.SetActive(true);
    }

    public void BrokenManaDetectorDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana detector (Broken)\n\n\nA device that can detect traces of mana but it's broken";
        SynDetailPanel.SetActive(true);
    }

    public void ManaDetectorDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Mana detector\n\n\nA device that can detect traces of mana";
        SynDetailPanel.SetActive(true);
    }

    public void HoliHPDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Powder of life\n\n\nA liquid that can restore vitality very quickly";
        SynDetailPanel.SetActive(true);
    }

    public void HoliMPDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Powder of life\n\n\nA liquid that can restore mana very quickly";
        SynDetailPanel.SetActive(true);
    }

    public void ReincarnationLifeDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Reincarnation life\n\n\nItem that can revive the dead before a certain amount of time";
        SynDetailPanel.SetActive(true);
    }

    public void UltraBomDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Ultra bom\n\n\nThe bomb has tremendous power through processing minerals containing mana";
        SynDetailPanel.SetActive(true);
    }
    public void OmnipotentBoundaryDetail()
    {
        ClickFX.Play();
        SynDetailPanelText.text = "Omnipotent boundary\n\n\nAn extremely powerful barrier to prevent monsters from attacking";
        SynDetailPanel.SetActive(true);
    }

    public void CloseSynDetailPanel()
    {
        ClickFX.Play();
        SynDetailPanel.SetActive(false);
    }

    public void SynthesizeButton1()
    {
        if (ContainerController.DriedLeaves > 0 && ContainerController.PureWater > 0 && ContainerController.HealPotion < 4)
        {
            SynthesizeFX.Play();
            ContainerController.DriedLeaves -= 1;
            ContainerController.PureWater -= 1;
            ContainerController.HealPotionPick = 1;
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
            SynthesizeFX.Play();
            ContainerController.MorningDrop -= 1;
            ContainerController.PureWater -= 1;
            ContainerController.ManaPotionPick = 1;
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
            SynthesizeFX.Play();
            ContainerController.HealPotion -= 1;
            ContainerController.ManaPotion -= 1;
            ContainerController.ElixirPotionPick = 1;
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
        if (ContainerController.Iron >= 2 && ContainerController.ManaGem >= 2 && CutscenesController.cus25 == 0 && CutscenesController.cus24 == 1 && SynBugStop == 0)
        {
            SynthesizeFX.Play();
            SynBugStop = 1;
            //BomCut = true;
            ContainerController.Iron -= 2;
            ContainerController.ManaGem -= 2;
            ContainerController.BomPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Iron >= 0 && ContainerController.ManaGem >= 0 && ContainerController.Bom < 4)
        {
            SynthesizeFX.Play();
            ContainerController.Iron -= 2;
            ContainerController.ManaGem -= 2;
            ContainerController.BomPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Bom >= 4)
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
        if (ContainerController.Wheat >= 3 && ContainerController.PureWater >= 2 && CutscenesController.cus48 == 0 && CutscenesController.cus47 == 1 && SynBugStop == 0)
        {
            SynthesizeFX.Play();
            SynBugStop = 1;
            //PorridgeCut = true;
            ContainerController.Wheat -= 3;
            ContainerController.PureWater -= 2;
            ContainerController.PorridgePick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Wheat >= 3 && ContainerController.PureWater >= 2)
        {
            SynthesizeFX.Play();
            ContainerController.Wheat -= 3;
            ContainerController.PureWater -= 2;
            ContainerController.PorridgePick = 1;
            if (CutscenesController.cus23 == 0 && CutscenesController.cus22 == 1)
            {
                CutscenesTrigger.PorridgeSyn = 1;
            }
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
        if (ContainerController.String >= 4 && ContainerController.ManaGem >= 2)
        {
            SynthesizeFX.Play();
            ContainerController.String -= 4;
            ContainerController.ManaGem -= 2;
            ContainerController.ManaClothPick = 1;
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
        if (ContainerController.Iron >= 2 && ContainerController.Wood >= 3 && ContainerController.ManaCloth >= 2)
        {
            SynthesizeFX.Play();
            ContainerController.Iron -= 2;
            ContainerController.Wood -= 3;
            ContainerController.ManaCloth -= 2;
            ContainerController.ManaShieldPick = 1;
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
        if (ContainerController.ScorpionVenom <= 4 && ContainerController.ElixirPotion >= 2 && CutscenesController.cus45 == 0 && CutscenesController.cus44 == 1)
        {
            showr2.SetActive(true);
            showr1.text = "You need to keep a small number of inferno scorpion tails to give Orina";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ScorpionVenom >= 2 && ContainerController.ElixirPotion >= 2 && CutscenesController.cus40 == 0 && CutscenesController.cus39 == 1 && SynBugStop == 0)
        {
            SynthesizeFX.Play();
            SynBugStop = 1;
            //VenomKillerCut = true;
            ContainerController.ScorpionVenom -= 2;
            ContainerController.ElixirPotion -= 2;
            ContainerController.VenomKillerPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ScorpionVenom >= 2 && ContainerController.ElixirPotion >= 2)
        {
            SynthesizeFX.Play();
            ContainerController.ScorpionVenom -= 2;
            ContainerController.ElixirPotion -= 2;
            ContainerController.VenomKillerPick = 1;
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
            SynthesizeFX.Play();
            SynBugStop = 1;
            ManaSynthesize -= 20;
            //ManaNecklaceCut = true;
            ContainerController.String -= 1;
            ContainerController.ManaGem -= 1;
            ContainerController.GuardianFeather -= 1;
            ContainerController.ManaNecklacePick = 1;
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
            SynthesizeFX.Play();
            ManaSynthesize -= 80;
            ContainerController.Iron -= 4;
            ContainerController.Wood -= 2;
            ContainerController.ManaGem -= 4;
            ContainerController.ManaGeneratorPick = 1;
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
            SynthesizeFX.Play();
            ContainerController.Iron -= 1;
            ContainerController.ManaOre -= 2;
            ContainerController.BaxiataPick = 1;
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
            SynthesizeFX.Play();
            ManaSynthesize -= 20;
            ContainerController.ManaCrystal -= 2;
            ContainerController.InfernoSand -= 1;
            ContainerController.Baxiata -= 2;
            ContainerController.BaxiataGemPick = 1;
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
            SynthesizeFX.Play();
            ContainerController.FireOre -= 2;
            ContainerController.IceOre -= 2;
            ContainerController.Baxiata -= 1;
            ContainerController.PhotonriaPick = 1;
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
        if (ContainerController.RedManaCrystal >= 2 && ContainerController.BlueManaCrystal >= 2 && ContainerController.Photonria >= 2 && ManaSynthesize >= 40)
        {
            SynthesizeFX.Play();
            ManaSynthesize -= 40;
            ContainerController.RedManaCrystal -= 2;
            ContainerController.BlueManaCrystal -= 2;
            ContainerController.Photonria -= 2;
            ContainerController.PhotonriaGemPick = 1;
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

    public void SynthesizeButton15()
    {
        if (ContainerController.ManaLiquid >= 2 && ContainerController.PureWater >= 2 && ManaSynthesize >= 20)
        {
            SynthesizeFX.Play();
            ManaSynthesize -= 20;
            ContainerController.ManaLiquid -= 2;
            ContainerController.PureWater -= 2;
            ContainerController.ManaLiquidCatalystPick = 1;
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

    public void SynthesizeButton16()
    {
        if (ContainerController.RedManaSlimeBall >= 2 && ContainerController.PureWater >= 2 && ManaSynthesize >= 20)
        {
            SynthesizeFX.Play();
            ManaSynthesize -= 20;
            ContainerController.RedManaSlimeBall -= 2;
            ContainerController.PureWater -= 2;
            ContainerController.RedLiquidCatalystPick = 1;
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

    public void SynthesizeButton17()
    {
        if (ContainerController.BlueManaSlimeBall >= 2 && ContainerController.PureWater >= 2 && ManaSynthesize >= 20)
        {
            SynthesizeFX.Play();
            ManaSynthesize -= 20;
            ContainerController.BlueManaSlimeBall -= 2;
            ContainerController.PureWater -= 2;
            ContainerController.BlueLiquidCatalystPick = 1;
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

    public void SynthesizeButton18()
    {
        if (ContainerController.ManaCoreFireZexel > 0 && ContainerController.RedManaCrystal >= 2 && ContainerController.RedLiquidCatalyst >= 2 && ManaFireSynthesize >= 20 && SynBugStop == 0)
        {
            SynthesizeFX.Play();
            SynBugStop = 1;
            ManaFireSynthesize -= 20;
            //ManaNecklaceCut = true;
            ContainerController.ManaCoreFireZexel -= 1;
            ContainerController.RedManaCrystal -= 2;
            ContainerController.RedLiquidCatalyst -= 2;
            ContainerController.ManaCoreFireVaynePick = 1;
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

    public void SynthesizeButton19()
    {
        if (ContainerController.ManaCoreIceZexel > 0 && ContainerController.BlueManaCrystal >= 2 && ContainerController.BlueLiquidCatalyst >= 2 && ManaIceSynthesize >= 20)
        {
            SynthesizeFX.Play();
            ManaIceSynthesize -= 20;
            ContainerController.ManaCoreIceZexel -= 1;
            ContainerController.BlueManaCrystal -= 2;
            ContainerController.BlueLiquidCatalyst -= 2;
            ContainerController.ManaCoreIceVaynePick = 1;
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

    public void SynthesizeButton20()
    {
        if (ContainerController.Obsidian >= 2 && ContainerController.GoldenFeather >= 3 && ContainerController.Rock >= 2)
        {
            SynthesizeFX.Play();
            ContainerController.Obsidian -= 2;
            ContainerController.GoldenFeather -= 3;
            ContainerController.Rock -= 2;
            ContainerController.PureObsidianPick = 1;
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

    public void SynthesizeButton21()
    {
        if (ContainerController.Porridge >= 2 && ContainerController.ScorpionVenom >= 2 && ContainerController.ElixirPotion >= 2)
        {
            SynthesizeFX.Play();
            ContainerController.Porridge -= 2;
            ContainerController.ScorpionVenom -= 2;
            ContainerController.ElixirPotion -= 2;
            ContainerController.BackPainMedicinePick = 1;
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
        if (ContainerController.PurifyingWater >= 1 && ContainerController.Photonria >= 2 && ContainerController.PureObsidian >= 2 && ManaSynthesize >= 60)
        {
            SynthesizeFX.Play();
            ManaSynthesize -= 60;
            ContainerController.PurifyingWater -= 1;
            ContainerController.Photonria -= 2;
            ContainerController.PureObsidian -= 2;
            ContainerController.PurifyingPotionPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.PurifyingWater >= 1 && ContainerController.Photonria >= 2 && ContainerController.PureObsidian >= 2 && ManaSynthesize < 60)
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
        if (ContainerController.NatureGrass >= 4 && ContainerController.GoldenFeather >= 4 && ContainerController.Wheat >= 2)
        {
            SynthesizeFX.Play();
            ContainerController.NatureGrass -= 4;
            ContainerController.GoldenFeather -= 4;
            ContainerController.Wheat -= 2;
            ContainerController.PowderOfLifePick = 1;
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

    public void SynthesizeButton24()
    {
        if (ContainerController.Iron >= 4 && ContainerController.Wood >= 2 && ContainerController.RedManaCrystal >= 4 && ManaFireSynthesize >= 80)
        {
            SynthesizeFX.Play();
            ManaFireSynthesize -= 80;
            ContainerController.Iron -= 4;
            ContainerController.Wood -= 2;
            ContainerController.RedManaCrystal -= 4;
            ContainerController.FireManaGeneratorPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaCoreIceZexel > 0 && ContainerController.BlueManaCrystal >= 2 && ContainerController.BlueLiquidCatalyst >= 2 && ManaFireSynthesize < 80)
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

    public void SynthesizeButton25()
    {
        if (ContainerController.Iron >= 4 && ContainerController.Wood >= 2 && ContainerController.BlueManaCrystal >= 4 && ManaIceSynthesize >= 80)
        {
            SynthesizeFX.Play();
            ManaIceSynthesize -= 80;
            ContainerController.Iron -= 4;
            ContainerController.Wood -= 2;
            ContainerController.BlueManaCrystal -= 4;
            ContainerController.IceManaGeneratorPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Iron >= 4 && ContainerController.Wood >= 2 && ContainerController.BlueManaCrystal >= 4 && ManaIceSynthesize < 80)
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

    public void SynthesizeButton26()
    {
        if (ContainerController.BrokenManaDetector >= 1 && ContainerController.BaxiataGem >= 4 && ContainerController.ManaLiquidCatalyst >= 4 && ManaSynthesize >= 60)
        {
            SynthesizeFX.Play();
            ManaIceSynthesize -= 60;
            ContainerController.BrokenManaDetector -= 1;
            ContainerController.BaxiataGem -= 4;
            ContainerController.ManaLiquidCatalyst -= 4;
            ContainerController.ManaDetectorPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.BrokenManaDetector >= 1 && ContainerController.BaxiataGem >= 4 && ContainerController.ManaLiquidCatalyst >= 4 && ManaSynthesize < 60)
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

    public void SynthesizeButton27()
    {
        if (ContainerController.HealPotion >= 2 && ContainerController.BaxiataGem >= 1 && ContainerController.RedLiquidCatalyst >= 2 && ManaFireSynthesize >= 40)
        {
            SynthesizeFX.Play();
            ManaFireSynthesize -= 40;
            ContainerController.HealPotion -= 2;
            ContainerController.BaxiataGem -= 1;
            ContainerController.RedLiquidCatalyst -= 2;
            ContainerController.HoliHPPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.HealPotion >= 2 && ContainerController.BaxiataGem >= 1 && ContainerController.RedLiquidCatalyst >= 2 && ManaFireSynthesize < 40)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.HealPotion >= 2 && ContainerController.BaxiataGem >= 1 && ContainerController.RedLiquidCatalyst >= 2 && ManaFireSynthesize >= 40 && ContainerController.HoliHP >= 4)
        {
            showr2.SetActive(true);
            showr1.text = "Item limit has been reached!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton28()
    {
        if (ContainerController.ManaPotion >= 2 && ContainerController.BaxiataGem >= 1 && ContainerController.BlueLiquidCatalyst >= 2 && ManaSynthesize >= 40)
        {
            SynthesizeFX.Play();
            ManaIceSynthesize -= 40;
            ContainerController.ManaPotion -= 2;
            ContainerController.BaxiataGem -= 1;
            ContainerController.BlueLiquidCatalyst -= 2;
            ContainerController.HoliMPPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaPotion >= 2 && ContainerController.BaxiataGem >= 1 && ContainerController.BlueLiquidCatalyst >= 2 && ManaIceSynthesize < 40)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaPotion >= 2 && ContainerController.BaxiataGem >= 1 && ContainerController.BlueLiquidCatalyst >= 2 && ManaIceSynthesize >= 40 && ContainerController.HoliMP >= 4)
        {
            showr2.SetActive(true);
            showr1.text = "Item limit has been reached!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton29()
    {
        if (ContainerController.ElixirPotion >= 2 && ContainerController.ManaLiquid >= 2 && ContainerController.PowderOfLife >= 1 && ManaSynthesize >= 50)
        {
            SynthesizeFX.Play();
            ManaSynthesize -= 50;
            ContainerController.ElixirPotion -= 2;
            ContainerController.ManaLiquid -= 2;
            ContainerController.PowderOfLife -= 1;
            ContainerController.ReincarnationLifePick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ElixirPotion >= 2 && ContainerController.ManaLiquid >= 2 && ContainerController.PowderOfLife >= 1 && ManaSynthesize < 50)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ElixirPotion >= 2 && ContainerController.ManaLiquid >= 2 && ContainerController.PowderOfLife >= 1 && ManaSynthesize >= 50 && ContainerController.ReincarnationLife >= 4)
        {
            showr2.SetActive(true);
            showr1.text = "Item limit has been reached!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton30()
    {
        if (ContainerController.Bom >= 2 && ContainerController.PhotonriaGem >= 1 && ContainerController.PureObsidian >= 1 && ManaSynthesize >= 50)
        {
            SynthesizeFX.Play();
            ManaSynthesize -= 50;
            ContainerController.Bom -= 2;
            ContainerController.PhotonriaGem -= 1;
            ContainerController.PureObsidian -= 1;
            ContainerController.UltraBomPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Bom >= 2 && ContainerController.PhotonriaGem >= 1 && ContainerController.PureObsidian >= 1 && ManaSynthesize < 50)
        {
            showr2.SetActive(true);
            showr1.text = "You don't have enough mana to synthesize this item!";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.Bom >= 2 && ContainerController.PhotonriaGem >= 1 && ContainerController.PureObsidian >= 1 && ManaSynthesize >= 50 && ContainerController.ReincarnationLife >= 4)
        {
            showr2.SetActive(true);
            showr1.text = "Item limit has been reached!";
            Invoke("delay1", 1f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough material";
            Invoke("delay1", 1f);
        }
    }

    public void SynthesizeButton31()
    {
        if (ContainerController.ManaEagleFeather >= 4 && ContainerController.IceLeather >= 2 && ContainerController.ManaCloth >= 2 && ManaSynthesize >= 100 && CutscenesController.cus113 == 0 && CutscenesController.cus112 == 1 && SynBugStop == 0)
        {
            SynthesizeFX.Play();
            if (ContainerController.OmnipotentBoundary == 1)
            {
                SynBugStop = 1;
            }
            //OmnipotentBoundaryCut = true;
            ManaSynthesize -= 100;
            ContainerController.ManaEagleFeather -= 4;
            ContainerController.IceLeather -= 4;
            ContainerController.ManaCloth -= 2;
            ContainerController.OmnipotentBoundaryPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaEagleFeather >= 4 && ContainerController.IceLeather >= 2 && ContainerController.ManaCloth >= 2 && ManaSynthesize >= 100)
        {
            SynthesizeFX.Play();
            ContainerController.ManaEagleFeather -= 4;
            ContainerController.IceLeather -= 4;
            ContainerController.ManaCloth -= 2;
            ContainerController.OmnipotentBoundaryPick = 1;
            showr2.SetActive(true);
            showr1.text = "Success";
            Invoke("delay1", 1f);
        }
        else if (ContainerController.ManaEagleFeather >= 4 && ContainerController.IceLeather >= 2 && ContainerController.ManaCloth >= 2 && ManaSynthesize < 100)
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

    public void RightButton()
    {
        ClickFX.Play();
        if (SlideIndex != 9)
        {
            SlideIndex += 1;
            ShowSlide(SlideIndex);
        }
    }
    public void LeftButton()
    {
        ClickFX.Play();
        if (SlideIndex != 0)
        {
            SlideIndex -= 1;
            ShowSlide(SlideIndex);
        }
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
        /*if (CutscenesController.cus25 == 0 && CutscenesController.cus24 == 1 && BomCut == true)
        {
            ContainerController.Bom -= 1;
            SceneManager.LoadScene("Cutscenes");
        }
        if (CutscenesController.cus40 == 0 && CutscenesController.cus39 == 1 && VenomKillerCut == true)
        {
            ContainerController.VenomKiller -= 1;
            SceneManager.LoadScene("Cutscenes");
        }
        if (CutscenesController.cus48 == 0 && CutscenesController.cus47 == 1 && PorridgeCut == true)
        {
            ContainerController.Porridge -= 1;
            SceneManager.LoadScene("Cutscenes");
        }
        if (CutscenesController.cus54 == 0 && CutscenesController.cus53 == 1 && ManaNecklaceCut == true)
        {
            ContainerController.ManaNecklace -= 1;
            SceneManager.LoadScene("Cutscenes");
        }
        if (CutscenesController.cus75 == 0 && CutscenesController.cus74 == 1 && ManaFireCoreVayneCut == true)
        {
            SceneManager.LoadScene("Cutscenes");
        }
        if (CutscenesController.cus83 == 0 && CutscenesController.cus82 == 1)
        {
            SceneManager.LoadScene("Cutscenes");
        }
        if (CutscenesController.cus132 == 0 && CutscenesController.cus131 == 1 && ContainerController.OmnipotentBoundary >= 2 && OmnipotentBoundaryCut == true)
        {
            SceneManager.LoadScene("Cutscenes");
        }*/
    }
}
