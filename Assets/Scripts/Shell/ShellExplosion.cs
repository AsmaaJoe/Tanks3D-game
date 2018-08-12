using UnityEngine;

public class ShellExplosion : MonoBehaviour
{
	Rigidbody RB;
	public ParticleSystem m_ExplosionParticles;         // Reference to the particles that will play on explosion.
	public AudioSource m_ExplosionAudio;                // Reference to the audio that will play on explosion.

    private void Start()
	{
		RB = GetComponent<Rigidbody>();
		//RB.AddExplosionForce (30.0f, transform.position,20.0f);
		RB.velocity = transform.forward * 30.0f;
		Destroy (gameObject, 2.5f);

	}
	private void Update(){
		Destroy(GameObject.Find("ShellExplosion(Clone)"),1.0f);


	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name != "Shell(Clone)") {
			Instantiate (m_ExplosionParticles, gameObject.transform.position, gameObject.transform.rotation);
			Destroy(gameObject);
		}
	//	Destroy (m_ExplosionParticles);

		//Destroy (collision.gameObject);
			//Destroy (gameObject);

		}
	}