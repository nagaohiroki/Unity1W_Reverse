using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField]
	float mMoveSpeed = 0.5f;
    void Update()
    {
		var vec = Vector3.zero;
		vec.x = Input.GetAxis("Horizontal");
		vec.z = Input.GetAxis("Vertical");
		transform.position += vec * mMoveSpeed;
        
    }
}
