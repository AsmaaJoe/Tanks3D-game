using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    public float m_StartingHealth = 100f;          
    public Slider m_Slider;                        
    public Image m_FillImage;                      
    public Color m_FullHealthColor = Color.green;  
    public GameObject m_ExplosionPrefab;
	private void Start(){
	}
	private void Update(){
		if (m_Slider.value > 75.0f)
		m_Slider.GetComponentInChildren<Image> ().color = Color.red;
		if (m_Slider.value == 100.0f)
			Destroy (gameObject);
	}
	void OnCollisionEnter(Collision collision)
	{
	if(collision.gameObject.name=="Shell(Clone)")
		   {m_Slider.value+=4.0f; }

	}
}