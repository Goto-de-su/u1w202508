using UnityEngine;

public class LightSwitchModule : MonoBehaviour
{
    // ライトをON
    public void TurnOff(GameObject light)
    {
        light.SetActive(false);
    }

    // ライトをOFF
    public void TurnOn(GameObject light)
    {
        light.SetActive(true);
    }
}
