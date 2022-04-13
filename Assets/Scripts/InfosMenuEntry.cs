using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfosMenuEntry : MonoBehaviour
{
	private InfosMenuManager infosMenuManager;
	private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        infosMenuManager = GameObject.Find("InfosMenu").GetComponent<InfosMenuManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            switch (gameObject.name)
            {
                case "SunEntry":
                    infosMenuManager.ToggleSun();
                    break;
                case "PlanetsEntry":
                    infosMenuManager.TogglePlanets();
                    break;
                case "MoonsEntry":
                	infosMenuManager.ToggleMoons();
                    break;
                case "GalaxyEntry":
                    infosMenuManager.ToggleWhereAreWe();
                    break;
                case "MissionsEntry":
                    infosMenuManager.ToggleMissions();
                    break;
                case "MercuryEntry":
                	gameManager.GoToMercury();
                    break;
                case "VenusEntry":
                	gameManager.GoToVenus();
                    break;
                case "EarthEntry":
                	gameManager.GoToEarth();
                    break;
                case "MarsEntry":
                	gameManager.GoToMars();
                    break;
                case "JupiterEntry":
                	gameManager.GoToJupiter();
                    break;
                case "SaturnEntry":
                	gameManager.GoToSaturn();
                    break;
                case "UranusEntry":
                	gameManager.GoToUranus();
                    break;
                case "NeptuneEntry":
                    gameManager.GoToNeptune();
                    break;
                case "PlutoEntry":
                    gameManager.GoToPluto();
                    break;
                case "CeresEntry":
                    gameManager.GoToCeres();
                    break;
                case "HaumeaEntry":
                    gameManager.GoToHaumea();
                    break;
                case "MakemakeEntry":
                    gameManager.GoToMakemake();
                    break;
                case "ErisEntry":
                    gameManager.GoToEris();
                    break;
                case "MoonEntry":
                    gameManager.GoToMoon();
                    break;
            }
        }
    }
}
