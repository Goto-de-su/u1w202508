using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [Header("ControlKey")]
    [Tooltip("Use AWSD Key to move")]
    [SerializeField] private KeyCode m_ForwardKey = KeyCode.W;
    [SerializeField] private KeyCode m_BackwardKey = KeyCode.S;
    [SerializeField] private KeyCode m_LeftKey = KeyCode.A;
    [SerializeField] private KeyCode m_RightKey = KeyCode.D;

    private Vector3 m_InputVector;
    private float m_XInput;
    private float m_YInput;
    private float m_ZInput;

    // プロパティ
    public Vector3 InputVector => m_InputVector;

    // Update is called once per frame
    private void Update()
    {
        HandeleInput();
    }

    private void HandeleInput()
    {
        // 初期化
        m_XInput = 0;
        m_ZInput = 0;

        if (Input.GetKey(m_ForwardKey))
        {
            m_ZInput++;
        }
        if (Input.GetKey(m_BackwardKey))
        {
            m_ZInput--;
        }
        if (Input.GetKey(m_RightKey))
        {
            m_XInput++;
        }
        if (Input.GetKey(m_LeftKey))
        {
            m_XInput--;
        }
        m_InputVector = new Vector3(m_XInput, m_YInput, m_ZInput);
    }
}
