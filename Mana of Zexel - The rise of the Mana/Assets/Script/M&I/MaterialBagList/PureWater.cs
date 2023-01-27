using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PureWater : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.PureWater;

        if (ContainerController.PureWater <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
