using UnityEngine;

public class LightSwitchModule : MonoBehaviour
{
    // ���C�g��ON
    public void TurnOff(GameObject light)
    {
        light.SetActive(false);
    }

    // ���C�g��OFF
    public void TurnOn(GameObject light)
    {
        light.SetActive(true);
    }
}
