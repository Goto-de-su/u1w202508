using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerInput m_PlayerInput;
    PlayerMovement m_PlayerMovement;
    // ����
    LightSwitchModule m_Light;
    [SerializeField] private GameObject lightObject;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        m_PlayerInput = GetComponent<PlayerInput>();
        m_PlayerMovement = GetComponent<PlayerMovement>();
        m_Light = GetComponent<LightSwitchModule>();
    }

    private void LateUpdate()
    {
        // �ړ�����
        Vector3 inputVector = m_PlayerInput.InputVector;
        m_PlayerMovement.Move(inputVector);


        // �A�N�V��������
        bool light = m_PlayerInput.ActionFlag;
        if (light == true)
        {
            m_Light.TurnOn(lightObject);
        }
        else
        {
            m_Light.TurnOff(lightObject);
        }

    }
}
