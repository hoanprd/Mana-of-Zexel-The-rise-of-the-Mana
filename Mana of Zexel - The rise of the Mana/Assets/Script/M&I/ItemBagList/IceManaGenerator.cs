using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceManaGenerator : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.IceManaGenerator;

        if (ContainerController.IceManaGenerator <= 0)
        {
            Destroy(gameObject);
        }
    }
}
