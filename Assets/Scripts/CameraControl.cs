using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
	private Func<Vector3> GetPosition;

	public void movement(Func<Vector3> GetPosition)
	{
		this.GetPosition = GetPosition;
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 movement = GetPosition();
		movement = gameObject.transform.rotation * movement;
		movement.y = gameObject.transform.position.y;
		transform.position = movement;
    }
}
