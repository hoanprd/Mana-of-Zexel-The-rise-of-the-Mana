using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaCoreFireZexel : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaCoreFireZexel;

        if (ContainerController.ManaCoreFireZexel <= 0)
        {
            Destroy(gameObject);
        }
    }
}
