using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaCrystal : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaCrystal;

        if (ContainerController.ManaCrystal <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
