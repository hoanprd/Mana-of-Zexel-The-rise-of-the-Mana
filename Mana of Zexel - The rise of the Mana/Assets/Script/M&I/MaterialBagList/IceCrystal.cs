using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceCrystal : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.IceCrystal;

        if (ContainerController.IceCrystal <= 0)
        {
            Destroy(gameObject);
        }
    }
}
