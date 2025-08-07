using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerInput m_PlayerInput;
    PlayerMovement m_PlayerMovement;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        m_PlayerInput = GetComponent<PlayerInput>();
        m_PlayerMovement = GetComponent<PlayerMovement>();
    }

    private void LateUpdate()
    {
        Vector3 inputVector = m_PlayerInput.InputVector;
        m_PlayerMovement.Move(inputVector);
    }
}
