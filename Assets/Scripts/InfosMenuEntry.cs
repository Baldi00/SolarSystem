using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class InfosMenuEntry : MonoBehaviour
{
	private InfosMenuManager infosMenuManager;
	private GameManager gameManager;

    [SerializeField]
    private Texture2D cursorTexture;
    private CursorMode cursorMode;
    private Vector2 hotSpot;

    // Start is called before the first frame update
    void Start()
    {
        infosMenuManager = GameObject.Find("InfosMenu").GetComponent<InfosMenuManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        cursorMode = CursorMode.Auto;
        hotSpot = Vector2.zero;
    }

    void OnMouseOver()
    {
        SetRocketCursorIfNecessary(gameObject.name);
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
            Cursor.SetCursor(null, Vector2.zero, cursorMode);
        }
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    private void SetRocketCursorIfNecessary(string gameObjectName)
    {
        if(cursorTexture == null)
            return;
        
        switch (gameObjectName)
        {
            case "MercuryEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "VenusEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "EarthEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "MarsEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "JupiterEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "SaturnEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "UranusEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "NeptuneEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "PlutoEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "CeresEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "HaumeaEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "MakemakeEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "ErisEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
            case "MoonEntry":
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                break;
        }
    }
}
