using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaLiquidCatalyst : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaLiquidCatalyst;

        if (ContainerController.ManaLiquidCatalyst <= 0)
        {
            Destroy(gameObject);
        }
    }
}
