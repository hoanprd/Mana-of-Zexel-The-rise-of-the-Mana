using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfernoSand : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.InfernoSand;

        if (ContainerController.InfernoSand <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
