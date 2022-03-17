using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetLabel : MonoBehaviour
{
    public Transform planetFollowing;
    private Transform cameraTransform;
    private TextMesh text;
    private MeshRenderer textRenderer;

    void Start()
    {
        cameraTransform = GameObject.Find("Main Camera").GetComponent<Transform>();
        text = GetComponent<TextMesh>();
        textRenderer = GetComponent<MeshRenderer>();
        text.fontSize = 200;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 planetPosition = planetFollowing.position;
        transform.position = new Vector3(planetPosition.x + (planetFollowing.localScale.x / 2)+5, planetPosition.y, planetPosition.z);

        Vector3 cameraRotation = cameraTransform.eulerAngles;
        transform.eulerAngles = new Vector3(cameraRotation.x, cameraRotation.y, cameraRotation.z);

        float scale = Vector3.Distance(planetPosition, cameraTransform.position)/650;
        transform.localScale = new Vector3(scale,scale,scale);
    }
}
