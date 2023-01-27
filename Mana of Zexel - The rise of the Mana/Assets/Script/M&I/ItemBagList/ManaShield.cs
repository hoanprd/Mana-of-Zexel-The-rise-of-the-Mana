using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaShield : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaShield;

        if (ContainerController.ManaShield <= 0)
        {
            Destroy(gameObject);
        }
    }
}
