using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroceryStoreController : MonoBehaviour
{
    public GameObject GroceryStorePanel;
    public Text MessageText;
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
        GroceryStorePanel.SetActive(false);
    }

    public void BuyString()
    {
        if (Global.Zen >= 20 && stop == false)
        {
            stop = true;
            ContainerController.StringPick = 1;
            MessageText.text = "Thanks for shopping";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyWood()
    {
        if (Global.Zen >= 30 && stop == false)
        {
            stop = true;
            ContainerController.WoodPick = 1;
            MessageText.text = "Thanks for shopping";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyIron()
    {
        if (Global.Zen >= 50 && stop == false)
        {
            stop = true;
            ContainerController.IronPick = 1;
            MessageText.text = "Thanks for shopping";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyManaGem()
    {
        if (Global.Zen >= 100 && stop == false)
        {
            stop = true;
            ContainerController.ManaGemPick = 1;
            MessageText.text = "Thanks for shopping";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyInfernoSand()
    {
        if (Global.Zen >= 40 && stop == false)
        {
            stop = true;
            ContainerController.InfernoSandPick = 1;
            MessageText.text = "Thanks for shopping";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyManaLiquid()
    {
        if (Global.Zen >= 150 && stop == false)
        {
            stop = true;
            ContainerController.ManaLiquidPick = 1;
            MessageText.text = "Thanks for shopping";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyGoldenFeather()
    {
        if (Global.Zen >= 300 && stop == false)
        {
            stop = true;
            ContainerController.GoldenFeatherPick = 1;
            MessageText.text = "Thanks for shopping";
            StartCoroutine(DelayBuy());
        }
    }

    public void BuyIceLeather()
    {
        if (Global.Zen >= 300 && stop == false)
        {
            stop = true;
            ContainerController.IceLeatherPick = 1;
            MessageText.text = "Thanks for shopping";
            StartCoroutine(DelayBuy());
        }
    }

    IEnumerator DelayBuy()
    {
        yield return new WaitForSeconds(1f);
        MessageText.text = "Wellcome!!!";
        stop = false;
    }
}
