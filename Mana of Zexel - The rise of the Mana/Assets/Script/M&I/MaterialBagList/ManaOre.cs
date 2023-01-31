using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaOre : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaOre;

        if (ContainerController.ManaOre <= 0)
        {
            Destroy(gameObject);
        }
    }
}
