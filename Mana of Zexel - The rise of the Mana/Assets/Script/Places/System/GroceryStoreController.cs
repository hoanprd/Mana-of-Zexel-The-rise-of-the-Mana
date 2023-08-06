using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroceryStoreController : MonoBehaviour
{
    public GameObject GroceryStorePanel, BuyAskPanel;
    public Text MessageText;
    public AudioSource BuyFX, ClickFX;
    public int BuyIndex;
    public bool IsActived = false, stop = false;
    public Transform MainPanel;
    public GameObject[] GroceryPrefab, HideGroceryItem1, HideGroceryItem2, HideGroceryItem3;

    // Start is called before the first frame update
    void Start()
    {
        /*for (int i = 0; i < GroceryPrefab.Length; i++)
        {
            Instantiate(GroceryPrefab[i], MainPanel);
        }*/

        if (CutscenesController.cus35 == 0)
        {
            for (int i = 0; i < HideGroceryItem1.Length; i++)
            {
                Destroy(HideGroceryItem1[i]);
            }
        }
        if (CutscenesController.cus50 == 0)
        {
            for (int i = 0; i < HideGroceryItem2.Length; i++)
            {
                Destroy(HideGroceryItem2[i]);
            }
        }
        if (CutscenesController.cus64 == 0)
        {
            for (int i = 0; i < HideGroceryItem3.Length; i++)
            {
                Destroy(HideGroceryItem3[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActived == true && Input.GetKeyDown(KeyCode.Space))
        {
            HubController.BusyHub = true;
            GroceryStorePanel.SetActive(true);
        }
        /*else if (IsActived == false)
        {
            GroceryStorePanel.SetActive(false);
        }*/
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        IsActived = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        IsActived = false;
    }

    public void CloseGroceryPanel()
    {
        ClickFX.Play();
        GroceryStorePanel.SetActive(false);
        HubController.BusyHub = false;
    }

    public void BuyString()
    {
        ClickFX.Play();
        BuyIndex = 1;
        BuyAskPanel.SetActive(true);
    }

    public void BuyWood()
    {
        ClickFX.Play();
        BuyIndex = 2;
        BuyAskPanel.SetActive(true);
    }

    public void BuyIron()
    {
        ClickFX.Play();
        BuyIndex = 3;
        BuyAskPanel.SetActive(true);
    }

    public void BuyManaGem()
    {
        ClickFX.Play();
        BuyIndex = 4;
        BuyAskPanel.SetActive(true);
    }

    public void BuyInfernoSand()
    {
        ClickFX.Play();
        BuyIndex = 5;
        BuyAskPanel.SetActive(true);
    }

    public void BuyManaLiquid()
    {
        ClickFX.Play();
        BuyIndex = 6;
        BuyAskPanel.SetActive(true);
    }

    public void BuyGoldenFeather()
    {
        ClickFX.Play();
        BuyIndex = 7;
        BuyAskPanel.SetActive(true);
    }

    public void BuyIceLeather()
    {
        ClickFX.Play();
        BuyIndex = 8;
        BuyAskPanel.SetActive(true);
    }

    public void ConfirmBuyItem()
    {
        if (BuyIndex == 1)
        {
            if (Global.Zen >= 20 && stop == false)
            {
                stop = true;
                BuyFX.Play();
                ContainerController.StringPick = 1;
                Global.Zen -= 20;
                MessageText.text = "Thanks for shopping";
                BuyAskPanel.SetActive(false);
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
            if (Global.Zen >= 30 && stop == false)
            {
                stop = true;
                BuyFX.Play();
                ContainerController.WoodPick = 1;
                Global.Zen -= 30;
                MessageText.text = "Thanks for shopping";
                BuyAskPanel.SetActive(false);
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
            if (Global.Zen >= 50 && stop == false)
            {
                stop = true;
                BuyFX.Play();
                ContainerController.IronPick = 1;
                Global.Zen -= 50;
                MessageText.text = "Thanks for shopping";
                BuyAskPanel.SetActive(false);
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
            if (Global.Zen >= 100 && stop == false)
            {
                stop = true;
                BuyFX.Play();
                ContainerController.ManaGemPick = 1;
                Global.Zen -= 100;
                MessageText.text = "Thanks for shopping";
                BuyAskPanel.SetActive(false);
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
            if (Global.Zen >= 40 && stop == false)
            {
                stop = true;
                BuyFX.Play();
                ContainerController.InfernoSandPick = 1;
                Global.Zen -= 40;
                MessageText.text = "Thanks for shopping";
                BuyAskPanel.SetActive(false);
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
            if (Global.Zen >= 150 && stop == false)
            {
                stop = true;
                BuyFX.Play();
                ContainerController.ManaLiquidPick = 1;
                Global.Zen -= 150;
                MessageText.text = "Thanks for shopping";
                BuyAskPanel.SetActive(false);
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
            if (Global.Zen >= 300 && stop == false)
            {
                stop = true;
                BuyFX.Play();
                ContainerController.GoldenFeatherPick = 1;
                Global.Zen -= 300;
                MessageText.text = "Thanks for shopping";
                BuyAskPanel.SetActive(false);
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
            if (Global.Zen >= 300 && stop == false)
            {
                stop = true;
                BuyFX.Play();
                ContainerController.IceLeatherPick = 1;
                Global.Zen -= 300;
                MessageText.text = "Thanks for shopping";
                BuyAskPanel.SetActive(false);
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

    IEnumerator DelayBuy()
    {
        yield return new WaitForSeconds(2f);
        MessageText.text = "Wellcome!!!";
        stop = false;
    }
}
