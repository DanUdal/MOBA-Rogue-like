using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	[SerializeField]
	GameObject planeObj;
	Plane plane;
	Transform player;
	[SerializeField]
	CharacterController controller;
	Vector3 movePoint = Vector3.zero;
	[SerializeField]
	float moveSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
		player = gameObject.transform;
		plane = new Plane(Vector3.up, planeObj.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButton(1))
		{
			//Create a ray from the Mouse click position
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			//Initialise the enter variable
			float enter = 0.0f;

			if (plane.Raycast(ray, out enter))
			{
				//Get the point that is clicked
				movePoint = ray.GetPoint(enter);

				player.LookAt(movePoint);
			}
		}
		if (movePoint != Vector3.zero)
		{
			Vector3 move = (movePoint - player.position).normalized * moveSpeed * Time.deltaTime;
			controller.Move(move);
			if ((player.position - movePoint).magnitude <= moveSpeed * Time.deltaTime * 1.2f)
			{
				movePoint = Vector3.zero;
			}
		}
    }
}
