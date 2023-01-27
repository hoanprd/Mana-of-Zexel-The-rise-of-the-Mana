using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueManaCrystal : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.BlueManaCrystal;

        if (ContainerController.BlueManaCrystal <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
