using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldenFeather : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.GoldenFeather;

        if (ContainerController.GoldenFeather <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
