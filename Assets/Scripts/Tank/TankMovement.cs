using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public int m_PlayerNumber = 1; 
    private string m_MovementAxisName;     
    private string m_TurnAxisName;         
    private Rigidbody m_Rigidbody;         
	private Quaternion q;

    private void Start()
    {
		m_Rigidbody = GetComponent<Rigidbody>();
        m_MovementAxisName = "Vertical" + m_PlayerNumber;
        m_TurnAxisName = "Horizontal" + m_PlayerNumber;

	}
    
    private void Update()
    {

		Vector3 movement = transform.forward * 
			Input.GetAxis (m_MovementAxisName)*0.2f;
		m_Rigidbody.MovePosition(m_Rigidbody.position
		                         + movement);

		q = Quaternion.Euler (0.0f, Input.GetAxis 
		                      (m_TurnAxisName) * 4, 0.0f);
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * q);
	}
    }
