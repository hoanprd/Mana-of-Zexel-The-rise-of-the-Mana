using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wheat : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.Wheat;

        if (ContainerController.Wheat <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
