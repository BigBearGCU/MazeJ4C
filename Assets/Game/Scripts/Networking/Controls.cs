using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour 
{
	int x = -1;
	// Use this for initialization
	void Start () 
	{
		gameObject.GetComponent<NetworkView>().observed=this.gameObject.GetComponent<Controls>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		if(Network.player.ToString() != "0")
		{
			if(GUI.Button(new Rect(20,100,50,50), "up"))
			{
				x=10;
				//GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Up",Network.player.ToString());
				//this.gameObject.GetComponent<NetworkView>().RPC("GetVote",RPCMode.All,Network.player.ToString(),"Up");
				//this.gameObject.GetComponent<NetworkView>().RPC("GetVote", RPCMode.All, Network.player.ToString(), "Up");
				//this.gameObject.GetComponent<NetworkView>().RPC("GetVote",RPCMode.All);
	
			}
				
			if(GUI.Button(new Rect(20,160,50,50), "down"))
			{
				x=11;
			//	GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Down",Network.player.ToString());
				
				//this.gameObject.GetComponent<NetworkView>().RPC("GetVote",RPCMode.All,Network.player.ToString(),"Down");
				//this.gameObject.GetComponent<NetworkView>().RPC("GetVote",RPCMode.All);
			}
			
			if(GUI.Button(new Rect(20,210,50,50), "left"))
			{
				x=12;
			//	GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Left",Network.player.ToString());
				//this.gameObject.GetComponent<NetworkView>().RPC("GetVote",RPCMode.All,Network.player.ToString(),"Left");
				//this.gameObject.GetComponent<NetworkView>().RPC("GetVote",RPCMode.All);
			}
			
			if(GUI.Button(new Rect(20,260,50,50), "right"))
			{
				x=13;
			// GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().GetVote("Right",Network.player.ToString());
				//this.gameObject.GetComponent<NetworkView>().RPC("GetVote",RPCMode.All,Network.player.ToString(),"Right");
				//this.gameObject.GetComponent<NetworkView>().RPC("GetVote",RPCMode.All);
			}
		}
		GUI.Label(new Rect(500,500,200,200),x.ToString());
	}
	
	void OnSerializeNetworkView (BitStream stream, NetworkMessageInfo info) {
		if (stream.isWriting) {
			// Sending
			//horizontalInput = Input.GetAxis ("Horizontal");
			stream.Serialize(ref x);
		} else {
			// Receiving
			stream.Serialize(ref x);
			// ... do something meaningful with the received variable
		}
	}
	
}
