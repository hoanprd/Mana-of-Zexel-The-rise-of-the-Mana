using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceLeather : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.IceLeather;

        if (ContainerController.IceLeather <= 0)
        {
            Destroy(gameObject);
        }
    }
}
