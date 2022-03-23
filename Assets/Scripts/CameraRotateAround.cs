using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateAround : MonoBehaviour
{
	private Camera cam;
	private Vector3 previousPosition;
	[SerializeField]
	private Transform target;
	public float zoom, zoomSensitivity;

	void Start()
	{
		cam = GetComponent<Camera>();
		zoom = 0f;
	}

	void Update()
	{
		if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
		{
			previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
		}

		if(Input.GetMouseButton(0) || Input.GetMouseButton(1))
		{
			Vector3 direction = previousPosition - cam.ScreenToViewportPoint(Input.mousePosition);

			if(target != null)
				cam.transform.position = target.position;
			else
				cam.transform.position = new Vector3();

			cam.transform.Rotate(new Vector3(0.01f,0,0), direction.y*180);
			cam.transform.Rotate(new Vector3(0,0.01f,0), -direction.x*180, Space.World);
			cam.transform.Translate(new Vector3(0,0,-(target.localScale.x*2-zoom)));

			previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
		}

		float axis = Input.GetAxis("Mouse ScrollWheel");
        if (axis != 0)
        {
        	if(axis<0 || Vector3.Distance(transform.position + transform.forward * axis * zoomSensitivity, target.transform.position) > target.localScale.x)
        	{
	            transform.position = transform.position + transform.forward * axis * zoomSensitivity;
	            zoom += axis * zoomSensitivity;
	        }
        }
	}

	public void SetTarget(Transform t)
	{
		target = t;
		zoom = 0f;
	}

	public void SetZoomSensitivity(float z)
	{
		zoomSensitivity = z;
	}
}