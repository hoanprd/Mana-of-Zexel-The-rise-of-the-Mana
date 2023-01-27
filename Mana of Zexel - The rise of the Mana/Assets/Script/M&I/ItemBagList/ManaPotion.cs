using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaPotion : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaPotion;

        if (ContainerController.ManaPotion <= 0)
        {
            Destroy(gameObject);
        }
    }
}
