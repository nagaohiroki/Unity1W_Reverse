using UnityEngine;
public class ReversePlayer : MonoBehaviour
{
	[SerializeField]
	Player mPlayer = null;
    void Update()
    {
		var pos = mPlayer.transform.position;
		pos.x = -pos.x;
		pos.z = -pos.z;
		transform.position = pos;
    }
}
