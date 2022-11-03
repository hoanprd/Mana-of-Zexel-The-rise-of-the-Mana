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
    public Slider ManaSynSlider;
    public Text ManaSynText;
    public Slider ManaFireSynSlider;
    public Text ManaFireSynText;
    public Slider ManaIceSynSlider;
    public Text ManaIceSynText;
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
