using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedManaCrystal : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.RedManaCrystal;

        if (ContainerController.RedManaCrystal <= 0)
        {
            Destroy(gameObject);
        }
    }
}
