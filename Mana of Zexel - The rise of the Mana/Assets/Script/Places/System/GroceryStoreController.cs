using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroceryStoreController : MonoBehaviour
{
    public GameObject GroceryStorePanel;
    public bool IsActived = false;
    public Text InShock1, InShock2, InShock3, InShock4, InShock5, InShock6, InShock7, InShock8, InShock9, InShock10, InShock11, InShock12, InShock13, InShock14, InShock15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActived == true && Input.GetKeyDown(KeyCode.Space))
        {
            GroceryStorePanel.SetActive(true);
        }
        else if (IsActived == false)
        {
            GroceryStorePanel.SetActive(false);
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

    public void BuyManaGem()
    {
        if (Global.Zen >= 100)
        {
            ContainerController.ManaGem += 1;
        }
    }

    public void BuyManaLiquid()
    {
        if (Global.Zen >= 300)
        {
            ContainerController.ManaLiquid += 1;
        }
    }

    public void BuyGoldenFeather()
    {
        if (Global.Zen >= 500)
        {
            ContainerController.GoldenFeather += 1;
        }
    }

    public void BuyIceLeather()
    {
        if (Global.Zen >= 500)
        {
            ContainerController.IceLeather += 1;
        }
    }
}
