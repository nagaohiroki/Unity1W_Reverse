using UnityEngine;
public class Anchor : MonoBehaviour
{
	void OnTriggerEnter(Collider inColl)
	{
		Debug.Log("a");
		var player = inColl.gameObject.GetComponent<Player>();
		var rend = GetComponent<Renderer>();
		if (player != null)
		{
			rend.material.color = Color.red;
		}
		var reverse = inColl.gameObject.GetComponent<ReversePlayer>();
		if (reverse != null)
		{
			rend.material.color = Color.blue;
		}
		
	}
}
