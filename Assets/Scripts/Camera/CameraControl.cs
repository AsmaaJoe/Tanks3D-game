using UnityEngine;

public class CameraControl : MonoBehaviour
{                  
    public Transform[] m_Targets; 
    private Camera m_Camera;                        
    private float m_Move;                 
    private Vector3 m_DesiredPosition;              
	private Vector3 vec1;              
	private Vector3 vec2;              
	private void Start ()
	{
		m_Camera = GetComponentInChildren<Camera> ();
		gameObject.transform.position = m_DesiredPosition;
	}
	private void Update ()
	{
		vec1 = GameObject.Find ("Tank").transform.position; 
		vec2 = GameObject.Find ("Tank (1)").transform.position; 
		m_DesiredPosition = (vec1 + vec2) / 2.0f;
		gameObject.transform.position = m_DesiredPosition;
		m_Move = (vec1 - vec2).magnitude;
		m_Camera.orthographicSize=m_Move*0.7f ;
	}
}
