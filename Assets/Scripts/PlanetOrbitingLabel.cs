using UnityEngine;

public class PlanetOrbitingLabel : MonoBehaviour
{
    public Transform planetFollowing;
    private Transform cameraTransform;
    private TextMesh text;
    private MeshRenderer textRenderer;
    public bool isInternal = false;
    public float cutoff = 20;

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
        transform.position = new Vector3(planetPosition.x, planetPosition.y + planetFollowing.localScale.y / 2, planetPosition.z);

        Vector3 cameraRotation = cameraTransform.eulerAngles;
        transform.eulerAngles = new Vector3(cameraRotation.x, cameraRotation.y, cameraRotation.z);

        float scale = planetFollowing.localScale.x / 10;
        transform.localScale = new Vector3(scale, scale, scale);

        if (isInternal && scale > cutoff)
        {
            textRenderer.enabled = false;
        }
        else
        {
            textRenderer.enabled = true;
        }
    }
}
