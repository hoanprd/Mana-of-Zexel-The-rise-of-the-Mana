using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealPotion : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.HealPotion;

        if (ContainerController.HealPotion <= 0)
        {
            Destroy(gameObject);
        }
    }
}
