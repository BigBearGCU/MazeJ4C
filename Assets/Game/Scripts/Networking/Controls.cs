using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(20,100,50,50), "up"))
		{
			GameObject.Find("pf_NetworkTestPlayer(Clone)").transform.position = new Vector3(0,5,0); 
		}
	}
}
