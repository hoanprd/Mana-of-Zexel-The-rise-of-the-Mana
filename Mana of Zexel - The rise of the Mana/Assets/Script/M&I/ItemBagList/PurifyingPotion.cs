using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurifyingPotion : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.PurifyingPotion;

        if (ContainerController.PurifyingPotion <= 0)
        {
            Destroy(gameObject);
        }
    }
}
