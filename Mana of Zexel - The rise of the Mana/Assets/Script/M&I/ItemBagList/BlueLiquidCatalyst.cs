using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueLiquidCatalyst : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.BlueLiquidCatalyst;

        if (ContainerController.BlueLiquidCatalyst <= 0)
        {
            Destroy(gameObject);
        }
    }
}
