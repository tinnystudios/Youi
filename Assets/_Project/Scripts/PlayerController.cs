using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _Speed = 2;
    [SerializeField] private float _JumpForce = 3;

    [SerializeField] private Rigidbody _Rb;

	// Update is called once per frame
	void Update ()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        transform.position += new Vector3(x, 0, y) * Time.deltaTime * _Speed;

        if (Input.GetButtonUp("Jump"))
        {
            Jump();
        }
    }

    public void Jump()
    {
        _Rb.velocity = new Vector3(0, _JumpForce, 0);
    }
}
