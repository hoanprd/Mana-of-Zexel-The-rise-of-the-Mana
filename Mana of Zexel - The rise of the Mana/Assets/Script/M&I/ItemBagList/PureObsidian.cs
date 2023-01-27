using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PureObsidian : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.PureObsidian;

        if (ContainerController.PureObsidian <= 0)
        {
            Destroy(gameObject);
        }
    }
}
