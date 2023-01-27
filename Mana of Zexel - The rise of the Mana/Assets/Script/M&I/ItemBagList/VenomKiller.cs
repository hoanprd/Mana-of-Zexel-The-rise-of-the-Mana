using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VenomKiller : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.VenomKiller;

        if (ContainerController.VenomKiller <= 0)
        {
            Destroy(gameObject);
        }
    }
}
