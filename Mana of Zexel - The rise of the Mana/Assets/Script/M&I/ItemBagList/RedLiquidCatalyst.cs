using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedLiquidCatalyst : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.RedLiquidCatalyst;

        if (ContainerController.RedLiquidCatalyst <= 0)
        {
            Destroy(gameObject);
        }
    }
}
