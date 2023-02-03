using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OmnipotentBoundary : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.OmnipotentBoundary;

        if (ContainerController.OmnipotentBoundary <= 0)
        {
            Destroy(gameObject);
        }
    }
}
