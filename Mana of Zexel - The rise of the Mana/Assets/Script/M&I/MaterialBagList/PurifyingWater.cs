using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurifyingWater : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.PurifyingWater;

        if (ContainerController.PurifyingWater <= 0)
        {
            Destroy(gameObject);
        }
    }
}
