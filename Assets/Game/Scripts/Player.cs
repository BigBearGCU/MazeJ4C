using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	
	public float speed=10.0f;
	public Transform spotLightTransform;
	public AudioClip stepOne;
	public AudioClip stepTwo;
	bool leftRight = false;

	// Use this for initialization
	void Start () 
	{
		//Remember to add in code to check for audiosource
	}
	
	// Update is called once per frame
	void Update () 
	{
		//have to play the character audio here!!!
		
		rigidbody.AddTorque(-speed*Input.GetAxis("Horizontal")*Vector3.forward);
		rigidbody.AddTorque(speed*Input.GetAxis("Vertical")*Vector3.right);
		
		if((Input.GetAxis("Horizontal") != 0 ||Input.GetAxis("Horizontal") != 0 )&&!this.gameObject.GetComponent<AudioSource>().isPlaying)
		{
			if(leftRight)
				this.gameObject.GetComponent<AudioSource>().clip = stepOne;
			else
				this.gameObject.GetComponent<AudioSource>().clip = stepTwo;
			this.gameObject.GetComponent<AudioSource>().Play();
		}

		
		
		
		Vector3 spotPosUpdate=spotLightTransform.position;
		spotPosUpdate.x=transform.position.x;
		spotPosUpdate.z=transform.position.z;
		spotLightTransform.position=spotPosUpdate;
		
	}
}
