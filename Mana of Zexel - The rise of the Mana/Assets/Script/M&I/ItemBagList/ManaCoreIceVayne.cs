using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaCoreIceVayne : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaCoreIceVayne;

        if (ContainerController.ManaCoreIceVayne <= 0)
        {
            Destroy(gameObject);
        }
    }
}
