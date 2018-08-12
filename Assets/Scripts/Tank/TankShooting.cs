using UnityEngine;
using UnityEngine.UI;

public class TankShooting : MonoBehaviour
{
	float nextfire;
	public float firerate;
	public GameObject Shell; 
	public Transform respawn;
	public Transform respawn1;

    private void Update()
	{		if (Input.GetButton ("Fire1") &&( Time.time > nextfire)) {
			nextfire=Time.time+firerate;
			Instantiate (Shell, respawn.position, respawn.rotation);
		}
		if (Input.GetButton ("Fire2") &&( Time.time > nextfire)) {
			nextfire=Time.time+firerate;
			Instantiate (Shell, respawn1.position, respawn1.rotation);
		}
    }

}