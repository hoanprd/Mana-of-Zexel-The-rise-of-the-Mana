using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaDust : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaDust;

        if (ContainerController.ManaDust <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
