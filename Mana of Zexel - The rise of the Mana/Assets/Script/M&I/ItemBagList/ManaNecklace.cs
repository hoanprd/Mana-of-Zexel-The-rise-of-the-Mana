using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaNecklace : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaNecklace;

        if (ContainerController.ManaNecklace <= 0)
        {
            Destroy(gameObject);
        }
    }
}
