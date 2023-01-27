using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceOre : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.IceOre;

        if (ContainerController.IceOre <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
