using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardianFeather: MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.GuardianFeather;

        if (ContainerController.GuardianFeather <= 0)
        {
            Destroy(gameObject);
        }
    }
}
