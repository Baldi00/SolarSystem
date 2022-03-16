using UnityEngine;

public class DrawOrbit : MonoBehaviour
{
    public int segments;
    LineRenderer line;
    private GameObject mainCamera;
    public PlanetOrbiting planet;


    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
        line = GetComponent<LineRenderer>();

        line.positionCount = (segments + 1);
        line.useWorldSpace = false;
        CreatePoints();
    }

    void Update()
    {
        if (planet != null)
        {
            line.widthMultiplier = planet.GetDistance() / 1500;
        }
    }

    void CreatePoints()
    {
        if(planet==null)
            return;
        
        float x;
        float y;
        float z;

        float angle = 20f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * planet.orbitingPath.xAxis;
            y = Mathf.Cos(Mathf.Deg2Rad * angle) * planet.orbitingPath.yAxis;
            z = -x*planet.xInclination/45f + -y*planet.yInclination/45f;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / segments);
        }
    }
}
 