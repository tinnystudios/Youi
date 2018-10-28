using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform Target;
    public float Speed = 3;
    public float distance = 5;

	// Update is called once per frame
	void Update ()
    {
        var newPosition = Target.position;
        newPosition -= transform.forward * distance;

        transform.position = Vector3.Slerp(transform.position,newPosition,Speed * Time.deltaTime);
	}
}
