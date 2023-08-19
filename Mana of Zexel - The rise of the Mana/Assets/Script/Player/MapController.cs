using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    //public Transform target2;
    public static bool WishingHillToZexelTown, ZexelTownToTavern, TavernToSaveRoom, ZexelTownToGroceryStore, ZexelTownToWeaponStore, ZexelTownToWishingForest, ZexelTownToInfernoDesert, InfernoDesertToZexelGate,
        InfernoDesertToManaGate, InfernoDesertToInfernoVolcano, InfernoDesertToInfernoIce, InfernoDesertToManaCliff, ManaGateToManaDimension, ManaDimensionToManaTemple,
        InfernoVolcanoToInsideVolcanoCave, InfernoVolcanoToAltaInferno, InfernoIceToInsideIceCave, InfernoIceToAltaInferno, ZexelGateToZexelTemple;
    public static bool ZexelTownToWishingHill, TavernToZexelTown, SaveRoomToTavern, GroceryStoreToZexelTown, WeaponStoreToZexelTown, WishingForestToZexelTown, InfernoDesertToZexelTown, ZexelGateToInfernoDesert,
        ManaGateToInfernoDesert, InfernoVolcanoToInfernoDesert, InfernoIceToInfernoDesert, ManaCliffToInfernoDesert, ManaDimensionToManaGate, ManaTempleToManaDimension,
        InsideVolcanoCaveToInfernoVolcano, AltaInfernoToInfernoVolcano, InsideIceCaveToInfernoIce, AltaInfernoToInfernoIce, ZexelTempleToZexelGate;

    // Start is called before the first frame update
    void Start()
    {
        if (WishingHillToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", 5);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            WishingHillToZexelTown = false;
        }
        else if (ZexelTownToWishingHill == true)
        {
            PlayerPrefs.SetFloat("x", -59);
            PlayerPrefs.SetFloat("y", -14);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToWishingHill = false;
        }
        else if (ZexelTownToTavern == true)
        {
            PlayerPrefs.SetFloat("x", -5);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToTavern = false;
        }
        else if (TavernToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", -42);
            PlayerPrefs.SetFloat("y", -2);
            PlayerPrefs.SetFloat("z", 0);
            TavernToZexelTown = false;
        }
        else if (TavernToSaveRoom == true)
        {
            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            TavernToSaveRoom = false;
        }
        else if (SaveRoomToTavern == true)
        {
            PlayerPrefs.SetFloat("x", 4.5f);
            PlayerPrefs.SetFloat("y", 4);
            PlayerPrefs.SetFloat("z", 0);
            SaveRoomToTavern = false;
        }
        else if (ZexelTownToGroceryStore == true)
        {
            PlayerPrefs.SetFloat("x", -5);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToGroceryStore = false;
        }
        else if (GroceryStoreToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", -60);
            PlayerPrefs.SetFloat("y", -10);
            PlayerPrefs.SetFloat("z", 0);
            GroceryStoreToZexelTown = false;
        }
        else if (ZexelTownToWeaponStore == true)
        {
            PlayerPrefs.SetFloat("x", -5);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToWeaponStore = false;
        }
        else if (WeaponStoreToZexelTown == true)
        {
            //PlayerPrefs.SetFloat("x", -21);
            //PlayerPrefs.SetFloat("y", -18);
            PlayerPrefs.SetFloat("x", -22);
            PlayerPrefs.SetFloat("y", -16);
            PlayerPrefs.SetFloat("z", 0);
            WeaponStoreToZexelTown = false;
        }
        else if (ZexelTownToWishingForest == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 14);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToWishingForest = false;
        }
        else if (WishingForestToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", -48);
            PlayerPrefs.SetFloat("y", -40);
            PlayerPrefs.SetFloat("z", 0);
            WishingForestToZexelTown = false;
        }
        else if (ZexelTownToInfernoDesert == true)
        {
            PlayerPrefs.SetFloat("x", -1.25f);
            PlayerPrefs.SetFloat("y", 9);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTownToInfernoDesert = false;
        }
        else if (InfernoDesertToZexelTown == true)
        {
            PlayerPrefs.SetFloat("x", -71.5f);
            PlayerPrefs.SetFloat("y", -21.5f);
            PlayerPrefs.SetFloat("z", 0);
            InfernoDesertToZexelTown = false;
        }
        else if (InfernoDesertToZexelGate == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 6);
            PlayerPrefs.SetFloat("z", 0);
            InfernoDesertToZexelGate = false;
        }
        else if (ZexelGateToInfernoDesert == true)
        {
            PlayerPrefs.SetFloat("x", -66);
            PlayerPrefs.SetFloat("y", 44);
            PlayerPrefs.SetFloat("z", 0);
            ZexelGateToInfernoDesert = false;
        }
        else if (InfernoDesertToManaGate == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", -1);
            PlayerPrefs.SetFloat("z", 0);
            InfernoDesertToManaGate = false;
        }
        else if (ManaGateToInfernoDesert == true)
        {
            PlayerPrefs.SetFloat("x", -77);
            PlayerPrefs.SetFloat("y", -13);
            PlayerPrefs.SetFloat("z", 0);
            ManaGateToInfernoDesert = false;
        }
        else if (InfernoDesertToInfernoVolcano == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            InfernoDesertToInfernoVolcano = false;
        }
        else if (InfernoVolcanoToInfernoDesert == true)
        {
            PlayerPrefs.SetFloat("x", -130);
            PlayerPrefs.SetFloat("y", 32);
            PlayerPrefs.SetFloat("z", 0);
            InfernoVolcanoToInfernoDesert = false;
        }
        else if (InfernoDesertToInfernoIce == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            InfernoDesertToInfernoIce = false;
        }
        else if (InfernoIceToInfernoDesert == true)
        {
            PlayerPrefs.SetFloat("x", -138);
            PlayerPrefs.SetFloat("y", 13);
            PlayerPrefs.SetFloat("z", 0);
            InfernoIceToInfernoDesert = false;
        }
        else if (InfernoDesertToManaCliff == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            InfernoDesertToManaCliff = false;
        }
        else if (ManaCliffToInfernoDesert == true)
        {
            PlayerPrefs.SetFloat("x", -120);
            PlayerPrefs.SetFloat("y", -8);
            PlayerPrefs.SetFloat("z", 0);
            ManaCliffToInfernoDesert = false;
        }
        else if (ManaGateToManaDimension == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            ManaGateToManaDimension = false;
        }
        else if (ManaDimensionToManaGate == true)
        {
            PlayerPrefs.SetFloat("x", 55);
            PlayerPrefs.SetFloat("y", -6);
            PlayerPrefs.SetFloat("z", 0);
            ManaDimensionToManaGate = false;
        }
        else if (ManaDimensionToManaTemple == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            ManaDimensionToManaTemple = false;
        }
        else if (ManaTempleToManaDimension == true)
        {
            PlayerPrefs.SetFloat("x", 36);
            PlayerPrefs.SetFloat("y", -5);
            PlayerPrefs.SetFloat("z", 0);
            ManaTempleToManaDimension = false;
        }
        else if (InfernoVolcanoToInsideVolcanoCave == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            InfernoVolcanoToInsideVolcanoCave = false;
        }
        else if (InsideVolcanoCaveToInfernoVolcano == true)
        {
            PlayerPrefs.SetFloat("x", -62);
            PlayerPrefs.SetFloat("y", 14);
            PlayerPrefs.SetFloat("z", 0);
            InsideVolcanoCaveToInfernoVolcano = false;
        }
        else if (InfernoVolcanoToAltaInferno == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 10);
            PlayerPrefs.SetFloat("z", 0);
            InfernoVolcanoToAltaInferno = false;
        }
        else if (AltaInfernoToInfernoVolcano == true)
        {
            PlayerPrefs.SetFloat("x", -81);
            PlayerPrefs.SetFloat("y", -12);
            PlayerPrefs.SetFloat("z", 0);
            AltaInfernoToInfernoVolcano = false;
        }
        else if (InfernoIceToInsideIceCave == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            InfernoIceToInsideIceCave = false;
        }
        else if (InsideIceCaveToInfernoIce == true)
        {
            PlayerPrefs.SetFloat("x", -34);
            PlayerPrefs.SetFloat("y", -79);
            PlayerPrefs.SetFloat("z", 0);
            InsideIceCaveToInfernoIce = false;
        }
        else if (InfernoIceToAltaInferno == true)
        {
            PlayerPrefs.SetFloat("x", -22);
            PlayerPrefs.SetFloat("y", -21);
            PlayerPrefs.SetFloat("z", 0);
            InfernoIceToAltaInferno = false;
        }
        else if (AltaInfernoToInfernoIce == true)
        {
            PlayerPrefs.SetFloat("x", -45);
            PlayerPrefs.SetFloat("y", -27);
            PlayerPrefs.SetFloat("z", 0);
            AltaInfernoToInfernoIce = false;
        }
        else if (ZexelGateToZexelTemple == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            ZexelGateToZexelTemple = false;
        }
        else if (ZexelTempleToZexelGate == true)
        {
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 15);
            PlayerPrefs.SetFloat("z", 0);
            ZexelTempleToZexelGate = false;
        }

        transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("x", transform.position.x);
        PlayerPrefs.SetFloat("y", transform.position.y);
        PlayerPrefs.SetFloat("z", transform.position.z);
    }
}
