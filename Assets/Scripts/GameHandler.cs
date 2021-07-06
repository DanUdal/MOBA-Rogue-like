using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
	[SerializeField]
	CameraControl cam;
	Vector3 camMove;
	[SerializeField]
	float camMoveSpeed = 10f;
	[SerializeField]
	float edgeSize = 30f;
    // Start is called before the first frame update
    void Start()
    {
		camMove = cam.gameObject.transform.position;
		cam.movement(() => camMove);
    }

    // Update is called once per frame
    void Update()
    {
		if ((Input.mousePosition.x > Screen.width - edgeSize) && (Input.mousePosition.x < Screen.width))
		{
			camMove.x += camMoveSpeed * Time.deltaTime;
		}
		if ((Input.mousePosition.y > Screen.height - edgeSize) && (Input.mousePosition.y < Screen.height))
		{
			camMove.y += camMoveSpeed * Time.deltaTime;
		}
		if ((Input.mousePosition.x < edgeSize) && (Input.mousePosition.x > 0))
		{
			camMove.x -= camMoveSpeed * Time.deltaTime;
		}
		if ((Input.mousePosition.y < edgeSize) && (Input.mousePosition.y > 0))
		{
			camMove.y -= camMoveSpeed * Time.deltaTime;
		}
    }
}
