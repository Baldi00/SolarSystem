using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private GameObject mainCamera;
    private Transform mainCameraTransform;
    private CameraTransition mainCameraTransition;
    private bool movingToOrbits, movingToMainMenu, movingToSizes;
    private bool movingToMercury, movingToVenus, movingToEarth, movingToMars;
    private bool movingToJupiter, movingToSaturn, movingToUranus, movingToNeptune, movingToMoon, movingToPluto;
    private GameObject mainMenu, orbits, planetsInOrbit, titleScreenTexts;
    private GameObject sun, mercury, venus, earth, mars, jupiter, saturn, uranus, neptune, moon, ceres, pluto, haumea, makemake, eris;
    private PlanetRotation sunPlanetRotation, mercuryPlanetRotation, venusPlanetRotation, earthPlanetRotation, marsPlanetRotation, jupiterPlanetRotation, saturnPlanetRotation, uranusPlanetRotation, neptunePlanetRotation, plutoPlanetRotation, ceresPlanetRotation, erisPlanetRotation, haumeaPlanetRotation, makemakePlanetRotation, moonPlanetRotation;
    private GameObject mercuryInfo, venusInfo, earthInfo, marsInfo, jupiterInfo, saturnInfo, uranusInfo, neptuneInfo, moonInfo, ceresInfo, plutoInfo, haumeaInfo, makemakeInfo, erisInfo;
    private FreeCam freeCam;
    private CameraRotateAround camRotateAround;
    private Transform mainMenuTransform, sizesTransform, orbitsTransform;
    private Transform mercuryCamPos, venusCamPos, earthCamPos, marsCamPos, jupiterCamPos, saturnCamPos, uranusCamPos, neptuneCamPos, plutoCamPos, moonCamPos;
    private GameObject UIMenu, UIPlanetInfo;
    private GameObject bigNotInScaleLabels;
    private GameObject toggleSizesLabels, orbitsInfo;
    private bool isInPlanetInfo, isRotatingAroundPlanet;
    private ScrollRect UIPlanetInfoScrollPosition;


    // Use this for initialization
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
        mainCameraTransform = mainCamera.GetComponent<Transform>();
        mainMenu = GameObject.Find("BigNotInScale");
        orbits = GameObject.Find("Orbits");
        planetsInOrbit = GameObject.Find("PlanetsInOrbit");
        titleScreenTexts = GameObject.Find("TitleScreenTexts");

        sun = GameObject.Find("Sun");
        mercury = GameObject.Find("Mercury");
        venus = GameObject.Find("Venus");
        earth = GameObject.Find("Earth");
        mars = GameObject.Find("Mars");
        jupiter = GameObject.Find("Jupiter");
        saturn = GameObject.Find("Saturn");
        uranus = GameObject.Find("Uranus");
        neptune = GameObject.Find("Neptune");
        moon = GameObject.Find("Moon");
        ceres = GameObject.Find("Ceres");
        pluto = GameObject.Find("Pluto");
        haumea = GameObject.Find("Haumea");
        makemake = GameObject.Find("Makemake");
        eris = GameObject.Find("Eris");

        mercuryInfo = GameObject.Find("MercuryInfoEntry");
        venusInfo = GameObject.Find("VenusInfoEntry");
        earthInfo = GameObject.Find("EarthInfoEntry");
        marsInfo = GameObject.Find("MarsInfoEntry");
        jupiterInfo = GameObject.Find("JupiterInfoEntry");
        saturnInfo = GameObject.Find("SaturnInfoEntry");
        uranusInfo = GameObject.Find("UranusInfoEntry");
        neptuneInfo = GameObject.Find("NeptuneInfoEntry");
        moonInfo = GameObject.Find("MoonInfoEntry");
        ceresInfo = GameObject.Find("CeresInfoEntry");
        plutoInfo = GameObject.Find("PlutoInfoEntry");
        haumeaInfo = GameObject.Find("HaumeaInfoEntry");
        makemakeInfo = GameObject.Find("MakemakeInfoEntry");
        erisInfo = GameObject.Find("ErisInfoEntry");

        bigNotInScaleLabels = GameObject.Find("BigNotInScaleLabels");

        mercuryCamPos = GameObject.Find("MercuryCameraPosition2").GetComponent<Transform>();
        venusCamPos = GameObject.Find("VenusCameraPosition2").GetComponent<Transform>();
        earthCamPos = GameObject.Find("EarthCameraPosition2").GetComponent<Transform>();
        marsCamPos = GameObject.Find("MarsCameraPosition2").GetComponent<Transform>();
        jupiterCamPos = GameObject.Find("JupiterCameraPosition2").GetComponent<Transform>();
        saturnCamPos = GameObject.Find("SaturnCameraPosition2").GetComponent<Transform>();
        uranusCamPos = GameObject.Find("UranusCameraPosition2").GetComponent<Transform>();
        neptuneCamPos = GameObject.Find("NeptuneCameraPosition2").GetComponent<Transform>();
        plutoCamPos = GameObject.Find("PlutoCameraPosition2").GetComponent<Transform>();
        moonCamPos = GameObject.Find("MoonCameraPosition2").GetComponent<Transform>();

        mainMenuTransform = GameObject.Find("MainMenuCameraPosition").GetComponent<Transform>();
        sizesTransform = GameObject.Find("SizesCameraPosition").GetComponent<Transform>();
        orbitsTransform = GameObject.Find("OrbitsCameraPosition").GetComponent<Transform>();
        UIMenu = GameObject.Find("UIMenu");
        UIPlanetInfo = GameObject.Find("UIPlanetInfo");
        orbitsInfo = GameObject.Find("OrbitsInfoCanvas");
        toggleSizesLabels = GameObject.Find("ToggleSizesLabelsCanvas");
        UIPlanetInfoScrollPosition = UIPlanetInfo.transform.GetChild(0).GetComponent<ScrollRect>();

        sunPlanetRotation = sun.GetComponent<PlanetRotation>();
		mercuryPlanetRotation = mercury.GetComponent<PlanetRotation>();
		venusPlanetRotation = venus.GetComponent<PlanetRotation>();
		earthPlanetRotation = earth.GetComponent<PlanetRotation>();
		marsPlanetRotation = mars.GetComponent<PlanetRotation>();
		jupiterPlanetRotation = jupiter.GetComponent<PlanetRotation>();
		saturnPlanetRotation = saturn.GetComponent<PlanetRotation>();
		uranusPlanetRotation = uranus.GetComponent<PlanetRotation>();
		neptunePlanetRotation = neptune.GetComponent<PlanetRotation>();
		plutoPlanetRotation = pluto.GetComponent<PlanetRotation>();
		ceresPlanetRotation = ceres.GetComponent<PlanetRotation>();
		erisPlanetRotation = eris.GetComponent<PlanetRotation>();
		haumeaPlanetRotation = haumea.GetComponent<PlanetRotation>();
		makemakePlanetRotation = makemake.GetComponent<PlanetRotation>();
		moonPlanetRotation = moon.GetComponent<PlanetRotation>();

        mainCameraTransition = mainCamera.GetComponent<CameraTransition>();
        freeCam = mainCamera.GetComponent<FreeCam>();
        camRotateAround = mainCamera.GetComponent<CameraRotateAround>();

        freeCam.enabled = false;
        camRotateAround.enabled = false;
        orbits.SetActive(false);
        planetsInOrbit.SetActive(false);
        bigNotInScaleLabels.SetActive(false);
        UIMenu.SetActive(false);
        orbitsInfo.SetActive(false);
        toggleSizesLabels.SetActive(false);

        SetAllMovingToFalseAndReset();
    }

    // Update is called once per frame
    void Update()
    {
        if (movingToOrbits)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                movingToOrbits = false;
                freeCam.enabled = true;
                mainMenu.SetActive(false);
                titleScreenTexts.SetActive(false);
            }
        }
        else if (movingToMainMenu)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                mainCamera.transform.position = mainMenuTransform.position;
                mainCamera.transform.eulerAngles = mainMenuTransform.eulerAngles;
                movingToMainMenu = false;
                orbits.SetActive(false);
                planetsInOrbit.SetActive(false);
                mainCameraTransition.stopDistance = 5;
            }
        }
        else if (movingToSizes)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                movingToSizes = false;
                freeCam.enabled = true;
                titleScreenTexts.SetActive(false);
            }
        }
        else if (movingToMercury)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                movingToMercury = false;
                camRotateAround.SetTarget(mercury.transform);
                camRotateAround.SetZoomSensitivity(3f);
                sun.transform.localScale = new Vector3(36.6f,36.6f,36.6f);
                sun.SetActive(true);
                UIPlanetInfo.SetActive(true);
                mercuryInfo.SetActive(true);
            }
        }
        else if (movingToVenus)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                movingToVenus = false;
                camRotateAround.SetTarget(venus.transform);
                camRotateAround.SetZoomSensitivity(5f);
                sun.transform.localScale = new Vector3(20.6f,20.6f,20.6f);
                sun.SetActive(true);
                UIPlanetInfo.SetActive(true);
                venusInfo.SetActive(true);
            }
        }
        else if (movingToEarth)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                movingToEarth = false;
                camRotateAround.SetTarget(earth.transform);
                camRotateAround.SetZoomSensitivity(5f);
                sun.transform.localScale = new Vector3(15.764f,15.764f,15.764f);
                sun.SetActive(true);
                UIPlanetInfo.SetActive(true);
                earthInfo.SetActive(true);
            }
        }
        else if (movingToMars)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                movingToMars = false;
                camRotateAround.SetTarget(mars.transform);
                camRotateAround.SetZoomSensitivity(4f);
                sun.transform.localScale = new Vector3(11.078f,11.078f,11.078f);
                sun.SetActive(true);
                UIPlanetInfo.SetActive(true);
                marsInfo.SetActive(true);
            }
        }
        else if (movingToJupiter)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                movingToJupiter = false;
                camRotateAround.SetTarget(jupiter.transform);
                camRotateAround.SetZoomSensitivity(20f);
                sun.transform.localScale = new Vector3(3.62f,3.62f,3.62f);
                sun.SetActive(true);
                UIPlanetInfo.SetActive(true);
                jupiterInfo.SetActive(true);
            }
        }
        else if (movingToSaturn)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                camRotateAround.SetTarget(saturn.transform);
                camRotateAround.SetZoomSensitivity(15f);
                movingToSaturn = false;
                UIPlanetInfo.SetActive(true);
                saturnInfo.SetActive(true);
            }
        }
        else if (movingToUranus)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                camRotateAround.SetTarget(uranus.transform);
                camRotateAround.SetZoomSensitivity(10f);
                movingToUranus = false;
                UIPlanetInfo.SetActive(true);
                uranusInfo.SetActive(true);
            }
        }
        else if (movingToNeptune)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                camRotateAround.SetTarget(neptune.transform);
                camRotateAround.SetZoomSensitivity(10f);
                movingToNeptune = false;
                UIPlanetInfo.SetActive(true);
                neptuneInfo.SetActive(true);
            }
        }
        else if (movingToPluto)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                camRotateAround.SetTarget(pluto.transform);
                camRotateAround.SetZoomSensitivity(3f);
                movingToPluto = false;
                UIPlanetInfo.SetActive(true);
                plutoInfo.SetActive(true);
            }
        }
        else if (movingToMoon)
        {
            if (mainCameraTransition.HasFinishedMovement())
            {
                camRotateAround.SetTarget(moon.transform);
                camRotateAround.SetZoomSensitivity(3f);
                movingToMoon = false;
                sun.transform.localScale = new Vector3(15.764f,15.764f,15.764f);
                sun.SetActive(true);
                UIPlanetInfo.SetActive(true);
                moonInfo.SetActive(true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !isRotatingAroundPlanet)
        {
            UIMenu.SetActive(false);
            SetAllPlanetsVisibility(true);
            GoToMainMenuSection();
        }
        else if (isRotatingAroundPlanet && (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)))
        {
            camRotateAround.enabled = false;
            isRotatingAroundPlanet = false;
            if(mercury.activeSelf) { mainCameraTransform.position = mercuryCamPos.position; mainCameraTransform.eulerAngles = mercuryCamPos.eulerAngles; }
            else if(venus.activeSelf){ mainCameraTransform.position = venusCamPos.position; mainCameraTransform.eulerAngles = venusCamPos.eulerAngles; }
            else if(earth.activeSelf){ mainCameraTransform.position = earthCamPos.position; mainCameraTransform.eulerAngles = earthCamPos.eulerAngles; }
            else if(mars.activeSelf){ mainCameraTransform.position = marsCamPos.position; mainCameraTransform.eulerAngles = marsCamPos.eulerAngles; }
            else if(jupiter.activeSelf){ mainCameraTransform.position = jupiterCamPos.position; mainCameraTransform.eulerAngles = jupiterCamPos.eulerAngles; }
            else if(saturn.activeSelf){ mainCameraTransform.position = saturnCamPos.position; mainCameraTransform.eulerAngles = saturnCamPos.eulerAngles; }
            else if(uranus.activeSelf){ mainCameraTransform.position = uranusCamPos.position; mainCameraTransform.eulerAngles = uranusCamPos.eulerAngles; }
            else if(neptune.activeSelf){ mainCameraTransform.position = neptuneCamPos.position; mainCameraTransform.eulerAngles = neptuneCamPos.eulerAngles; }
            else if(moon.activeSelf){ mainCameraTransform.position = moonCamPos.position; mainCameraTransform.eulerAngles = moonCamPos.eulerAngles; }
            //else if(ceres.activeSelf){ mainCameraTransform.position = ceresCamPos.position; mainCameraTransform.eulerAngles = ceresCamPos.eulerAngles; }
            else if(pluto.activeSelf){ mainCameraTransform.position = plutoCamPos.position; mainCameraTransform.eulerAngles = plutoCamPos.eulerAngles; }
            //else if(haumea.activeSelf){ mainCameraTransform.position = haumeaCamPos.position; mainCameraTransform.eulerAngles = haumeaCamPos.eulerAngles; }
            //else if(makemake.activeSelf){ mainCameraTransform.position = makemakeCamPos.position; mainCameraTransform.eulerAngles = makemakeCamPos.eulerAngles; }
            //else if(eris.activeSelf){ mainCameraTransform.position = erisCamPos.position; mainCameraTransform.eulerAngles = erisCamPos.eulerAngles; }
            
            UIPlanetInfo.SetActive(true);
        }
        else if (isInPlanetInfo && Input.GetKeyDown(KeyCode.P))
        {
            UIPlanetInfo.SetActive(false);
            camRotateAround.enabled = true;
            isRotatingAroundPlanet = true;
        }
        else if (isInPlanetInfo && Input.GetKeyDown(KeyCode.R))
        {
            ToggleAllPlanetRotations();
        }
    }

    public void GoToOrbitsSection()
    {
        SetAllMovingToFalseAndReset();
        orbitsInfo.SetActive(true);
        orbits.SetActive(true);
        planetsInOrbit.SetActive(true);
        movingToOrbits = true;
        freeCam.enabled = false;
        freeCam.fastMovementSpeed = 1000;
        mainCameraTransition.MoveTo(orbitsTransform);
    }

    public void GoToMainMenuSection()
    {
        SetAllMovingToFalseAndReset();
        mainMenu.SetActive(true);
        titleScreenTexts.SetActive(true);
        movingToMainMenu = true;
        freeCam.enabled = false;
        freeCam.fastMovementSpeed = 100;
        mainCameraTransition.stopDistance = 0.01f;
        mainCameraTransition.MoveTo(mainMenuTransform);
    }

    public void GoToSizesSection()
    {
        SetAllMovingToFalseAndReset();
        bigNotInScaleLabels.SetActive(true);
        mainMenu.SetActive(true);
        orbits.SetActive(false);
        toggleSizesLabels.SetActive(true);
        planetsInOrbit.SetActive(false);
        movingToSizes = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(sizesTransform);
    }

    public void GoToMercury()
    {
        SetAllMovingToFalseAndReset();
        SetAllPlanetsVisibility(false);
        mainCameraTransition.stopDistance = 0.1f;
        mainCameraTransform.position = new Vector3(-10000f, 0f, 0f);
        mainCameraTransform.eulerAngles = new Vector3(0f, 90f, 0f);
        mercury.SetActive(true);
        UIMenu.SetActive(false);
        movingToMercury = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(mercuryCamPos);
        isInPlanetInfo = true;
    }

    public void GoToVenus()
    {
        SetAllMovingToFalseAndReset();
        SetAllPlanetsVisibility(false);
        mainCameraTransition.stopDistance = 0.1f;
        mainCameraTransform.position = new Vector3(-10000f, 0f, 0f);
        mainCameraTransform.eulerAngles = new Vector3(0f, 90f, 0f);
        venus.SetActive(true);
        UIMenu.SetActive(false);
        movingToVenus = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(venusCamPos);
        isInPlanetInfo = true;
    }

    public void GoToEarth()
    {
        SetAllMovingToFalseAndReset();
        SetAllPlanetsVisibility(false);
        mainCameraTransition.stopDistance = 0.1f;
        mainCameraTransform.position = new Vector3(-10000f, 0f, 0f);
        mainCameraTransform.eulerAngles = new Vector3(0f, 90f, 0f);
        earth.SetActive(true);
        UIMenu.SetActive(false);
        movingToEarth = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(earthCamPos);
        isInPlanetInfo = true;
    }

    public void GoToMars()
    {
        SetAllMovingToFalseAndReset();
        SetAllPlanetsVisibility(false);
        mainCameraTransition.stopDistance = 0.1f;
        mainCameraTransform.position = new Vector3(-10000f, 0f, 0f);
        mainCameraTransform.eulerAngles = new Vector3(0f, 90f, 0f);
        mars.SetActive(true);
        UIMenu.SetActive(false);
        movingToMars = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(marsCamPos);
        isInPlanetInfo = true;
    }

    public void GoToJupiter()
    {
        SetAllMovingToFalseAndReset();
        SetAllPlanetsVisibility(false);
        mainCameraTransition.stopDistance = 0.1f;
        mainCameraTransform.position = new Vector3(-10000f, 0f, 0f);
        mainCameraTransform.eulerAngles = new Vector3(0f, 90f, 0f);
        jupiter.SetActive(true);
        UIMenu.SetActive(false);
        movingToJupiter = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(jupiterCamPos);
        isInPlanetInfo = true;
    }

    public void GoToSaturn()
    {
        SetAllMovingToFalseAndReset();
        SetAllPlanetsVisibility(false);
        mainCameraTransition.stopDistance = 0.1f;
        mainCameraTransform.position = new Vector3(-10000f, 0f, 0f);
        mainCameraTransform.eulerAngles = new Vector3(0f, 90f, 0f);
        saturn.SetActive(true);
        UIMenu.SetActive(false);
        movingToSaturn = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(saturnCamPos);
        isInPlanetInfo = true;
    }

    public void GoToUranus()
    {
        SetAllMovingToFalseAndReset();
        SetAllPlanetsVisibility(false);
        mainCameraTransition.stopDistance = 0.1f;
        mainCameraTransform.position = new Vector3(-10000f, 0f, 0f);
        mainCameraTransform.eulerAngles = new Vector3(0f, 90f, 0f);
        uranus.SetActive(true);
        UIMenu.SetActive(false);
        movingToUranus = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(uranusCamPos);
        isInPlanetInfo = true;
    }

    public void GoToNeptune()
    {
        SetAllMovingToFalseAndReset();
        SetAllPlanetsVisibility(false);
        mainCameraTransition.stopDistance = 0.1f;
        mainCameraTransform.position = new Vector3(-10000f, 0f, 0f);
        mainCameraTransform.eulerAngles = new Vector3(0f, 90f, 0f);
        neptune.SetActive(true);
        UIMenu.SetActive(false);
        movingToNeptune = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(neptuneCamPos);
        isInPlanetInfo = true;
    }

    public void GoToPluto()
    {
        SetAllMovingToFalseAndReset();
        SetAllPlanetsVisibility(false);
        mainCameraTransition.stopDistance = 0.1f;
        mainCameraTransform.position = new Vector3(-10000f, 0f, 0f);
        mainCameraTransform.eulerAngles = new Vector3(0f, 90f, 0f);
        pluto.SetActive(true);
        UIMenu.SetActive(false);
        movingToPluto = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(plutoCamPos);
        isInPlanetInfo = true;
    }

    public void GoToMoon()
    {
        SetAllMovingToFalseAndReset();
        SetAllPlanetsVisibility(false);
        mainCameraTransition.stopDistance = 0.1f;
        mainCameraTransform.position = new Vector3(-10000f, 0f, 0f);
        mainCameraTransform.eulerAngles = new Vector3(0f, 90f, 0f);
        moon.SetActive(true);
        UIMenu.SetActive(false);
        movingToMoon = true;
        freeCam.enabled = false;
        mainCameraTransition.MoveTo(moonCamPos);
        isInPlanetInfo = true;
    }

    public bool ArePlanetOrbiting()
    {
        return planetsInOrbit.activeSelf;
    }

    public void ShowInfosMenu()
    {
        titleScreenTexts.SetActive(false);
        UIMenu.SetActive(true);
    }

    public void SetAllPlanetsVisibility(bool visibility)
    {
        sun.SetActive(visibility);
        mercury.SetActive(visibility);
        venus.SetActive(visibility);
        earth.SetActive(visibility);
        mars.SetActive(visibility);
        jupiter.SetActive(visibility);
        saturn.SetActive(visibility);
        uranus.SetActive(visibility);
        neptune.SetActive(visibility);
        pluto.SetActive(visibility);
        ceres.SetActive(visibility);
        eris.SetActive(visibility);
        haumea.SetActive(visibility);
        makemake.SetActive(visibility);
        moon.SetActive(visibility);
    }

    private void SetAllMovingToFalseAndReset()
    {
        UIPlanetInfoScrollPosition.verticalNormalizedPosition = 1f;
        movingToOrbits = false;
        movingToMainMenu = false;
        movingToSizes = false;
        movingToMercury = movingToVenus = movingToEarth = movingToMars = false;
        movingToJupiter = movingToSaturn = movingToUranus = movingToNeptune = false;
        movingToMoon = movingToPluto = false;

        UIPlanetInfo.SetActive(false);
        mercuryInfo.SetActive(false);
        venusInfo.SetActive(false);
        earthInfo.SetActive(false);
        marsInfo.SetActive(false);
        jupiterInfo.SetActive(false);
        saturnInfo.SetActive(false);
        uranusInfo.SetActive(false);
        neptuneInfo.SetActive(false);
        moonInfo.SetActive(false);
        ceresInfo.SetActive(false);
        plutoInfo.SetActive(false);
        haumeaInfo.SetActive(false);
        makemakeInfo.SetActive(false);
        erisInfo.SetActive(false);

        isInPlanetInfo = false;
        isRotatingAroundPlanet = false;

        freeCam.movementSpeed = 10;
        freeCam.fastMovementSpeed = 100;
        mainCameraTransition.stopDistance = 5;
        freeCam.enabled = false;
        camRotateAround.enabled = false;
        sun.SetActive(true);
        sun.transform.localScale = new Vector3(1391.4f,1391.4f,1391.4f);
        bigNotInScaleLabels.SetActive(false);
        orbitsInfo.SetActive(false);
        toggleSizesLabels.SetActive(false);
        SetAllPlanetRotationState(true);
    }

    private void ToggleAllPlanetRotations(){
        bool toggle = !sun.GetComponent<PlanetRotation>().enabled;
        SetAllPlanetRotationState(toggle);
    }

    private void SetAllPlanetRotationState(bool state){
        if(sunPlanetRotation!=null)
            sunPlanetRotation.enabled = state;

        if(mercuryPlanetRotation!=null)
            mercuryPlanetRotation.enabled = state;

        if(venusPlanetRotation!=null)
            venusPlanetRotation.enabled = state;

        if(earthPlanetRotation!=null)
            earthPlanetRotation.enabled = state;

        if(marsPlanetRotation!=null)
            marsPlanetRotation.enabled = state;

        if(jupiterPlanetRotation!=null)
            jupiterPlanetRotation.enabled = state;

        if(saturnPlanetRotation!=null)
            saturnPlanetRotation.enabled = state;

        if(uranusPlanetRotation!=null)
            uranusPlanetRotation.enabled = state;

        if(neptunePlanetRotation!=null)
            neptunePlanetRotation.enabled = state;

        if(plutoPlanetRotation!=null)
            plutoPlanetRotation.enabled = state;

        if(ceresPlanetRotation!=null)
            ceresPlanetRotation.enabled = state;

        if(erisPlanetRotation!=null)
            erisPlanetRotation.enabled = state;

        if(haumeaPlanetRotation!=null)
            haumeaPlanetRotation.enabled = state;

        if(makemakePlanetRotation!=null)
            makemakePlanetRotation.enabled = state;

        if(moonPlanetRotation!=null)
            moonPlanetRotation.enabled = state;
    }

    public void ToggleSizesLabels(){
        bigNotInScaleLabels.SetActive(!bigNotInScaleLabels.activeSelf);
    }
}
