using System.Collections;
using UnityEngine;

public class PlanetOrbiting : MonoBehaviour
{

    private GameObject mainCamera;
    private Transform orbitingObject;
    public Ellipse orbitingPath;

    private GameManager gameManager;

    [Range(0f, 1f)]
    public float orbitProgress = 0f;
    public float orbitPeriod = 3f;
    public bool orbitActive = true;
    public float xInclination = 0f;
    public float yInclination = 0f;

    private Vector3 initialPosition;
    private bool alreadyActivated;

    private TrailRenderer trail;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        mainCamera = GameObject.Find("Main Camera");
        trail = GetComponent<TrailRenderer>();
        orbitingObject = transform;
        initialPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        alreadyActivated = false;
    }

    private void ActivateOrbiting()
    {
        orbitActive = true;
        SetOrbitingObjectPosition();
        StartCoroutine(AnimateOrbit());
    }

    private void SetOrbitingObjectPosition()
    {
        Vector2 orbitPos = orbitingPath.Evaluate(orbitProgress);
        float heightIncrementerX = xInclination/45f;
        float heightIncrementerY = yInclination/45f;
        float height = orbitPos.x*heightIncrementerX + orbitPos.y*heightIncrementerY;
        orbitingObject.localPosition = new Vector3(orbitPos.x + initialPosition.x, height, orbitPos.y + initialPosition.z);
    }

    IEnumerator AnimateOrbit()
    {
        if (orbitPeriod < 0.1f)
        {
            orbitPeriod = 0.1f;
        }
        float orbitSpeed = 1f / orbitPeriod;
        while (orbitActive)
        {
            orbitProgress += Time.deltaTime * orbitSpeed;
            orbitProgress %= 1f;
            SetOrbitingObjectPosition();
            yield return null;
        }
    }

    void Update()
    {
        float distance = GetDistance() / 50f;
        transform.localScale = new Vector3(distance, distance, distance);
        if (trail != null)
        {
            trail.startWidth = distance / 5;
        }

        if(gameManager != null)
        {
            if (gameManager.ArePlanetOrbiting())
            {
                if (!alreadyActivated)
                {
                    ActivateOrbiting();
                    alreadyActivated = true;
                }
            }
            else
            {
                orbitActive = false;
                alreadyActivated = false;
            }
        }
    }

    void OnDisable()
    {
        orbitActive = false;
        alreadyActivated = false;
    }

    public float GetDistance()
    {
        if(transform!=null && mainCamera!=null)
            return Vector3.Distance(transform.position, mainCamera.transform.position);
        return 0;
    }
}
