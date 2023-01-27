using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueManaSlimeBall : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.BlueManaSlimeBall;

        if (ContainerController.BlueManaSlimeBall <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
