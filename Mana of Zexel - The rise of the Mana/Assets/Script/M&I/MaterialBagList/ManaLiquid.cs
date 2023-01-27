using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaLiquid : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaLiquid;

        if (ContainerController.ManaLiquid <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
