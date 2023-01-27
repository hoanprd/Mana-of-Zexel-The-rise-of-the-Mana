using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireOre : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.FireOre;

        if (ContainerController.FireOre <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
