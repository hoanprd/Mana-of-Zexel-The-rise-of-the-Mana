using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedManaSlimeBall : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.RedManaSlimeBall;

        if (ContainerController.RedManaSlimeBall <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
