using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaCoreFireVayne : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaCoreFireVayne;

        if (ContainerController.ManaCoreFireVayne <= 0)
        {
            Destroy(gameObject);
        }
    }
}
