using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [Tooltip("All speed ratio")]
    [SerializeField] private float m_PlayerSpeedRatio = 1f / 100f;
    [Tooltip("Horizontal speed")]
    [SerializeField] private float m_MoveSpeed = 3f;
    [Tooltip("Rate of change for move speed")]
    [SerializeField] private float m_Acceleration = 5f;
    [Tooltip("Deceleration rate when no inoput is provided")]
    [SerializeField] private float m_Deceleration = 3f;

    private float m_CurrentSpeed = 0f;
    private CharacterController m_CharaController;
    private float m_InitialYPosition;

    private void Awake()
    {
        m_CharaController = GetComponent<CharacterController>();
    }

    void Start()
    {
        m_InitialYPosition = transform.position.y;
    }

    public void Move(Vector3 inputVector)
    {
        // キー離した時、減速
        if(inputVector  == Vector3.zero)
        {
            if(m_CurrentSpeed > 0)
            {
                // 減速処理
                m_CurrentSpeed -= m_Deceleration * Time.deltaTime;
                // スピードを0以下にしない
                m_CurrentSpeed = Mathf.Max(m_CurrentSpeed, 0);
            }
        }
        else
        {
            m_CurrentSpeed = Mathf.Lerp(m_CurrentSpeed, m_MoveSpeed, Time.deltaTime * m_Acceleration);
        }

        Vector3 movement = m_CurrentSpeed * m_PlayerSpeedRatio * Time.deltaTime * inputVector.normalized;

        //transform.Translate(movement);
        m_CharaController.Move(movement);

        // Force the y position to be constant
        transform.position = new Vector3(transform.position.x, m_InitialYPosition, transform.position.z);
    }
}
