using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfosMenuManager : MonoBehaviour
{
	private GameObject planetsListEntry;
	private GameObject moonsListEntry;
    private GameObject waw;
    private GameObject missionsListEntry;
	private bool planetsOn, moonsOn, whereAreWeOn, missionsOn;
	private ScrollRect scrollRect;

    // Start is called before the first frame update
    void Start()
    {
        planetsListEntry = GameObject.Find("PlanetsListEntry");
        moonsListEntry = GameObject.Find("MoonsListEntry");
        waw = GameObject.Find("WhereAreWe");
        missionsListEntry = GameObject.Find("MissionsListEntry");
        scrollRect = GetComponent<ScrollRect>();
        planetsListEntry.GetComponent<RectTransform>().sizeDelta = new Vector2 (1000, 460);
        waw.GetComponent<RectTransform>().sizeDelta = new Vector2 (1000, 2800);
        moonsListEntry.GetComponent<RectTransform>().sizeDelta = new Vector2 (1000, 2062);
        missionsListEntry.GetComponent<RectTransform>().sizeDelta = new Vector2 (1000, 3264);
        DisableAllSubmenus();
        scrollRect.verticalNormalizedPosition = 1f;
    }

    private void DisableAllSubmenus()
    {
        if(planetsListEntry != null) planetsListEntry.SetActive(false);
        if(moonsListEntry != null) moonsListEntry.SetActive(false);
        if(waw != null) waw.SetActive(false);
        if(missionsListEntry != null) missionsListEntry.SetActive(false);
        planetsOn = false;
        moonsOn = false;
        whereAreWeOn = false;
        missionsOn = false;
    }

    public void TogglePlanets()
    {
    	if(planetsOn)
    	{
    		DisableAllSubmenus();
    	}
    	else
    	{
    		DisableAllSubmenus();
	    	planetsListEntry.SetActive(true);
	        planetsOn = true;
    	}
        scrollRect.verticalNormalizedPosition = 1f;
    }

    public void ToggleMoons()
    {
    	if(moonsOn)
    	{
    		DisableAllSubmenus();
    	}
    	else
    	{
    		DisableAllSubmenus();
	    	moonsListEntry.SetActive(true);
	        moonsOn = true;
    	}
        scrollRect.verticalNormalizedPosition = 1f;
    }

    public void ToggleWhereAreWe()
    {
        if(whereAreWeOn)
        {
            DisableAllSubmenus();
        }
        else
        {
            DisableAllSubmenus();
            waw.SetActive(true);
            whereAreWeOn = true;
        }
        scrollRect.verticalNormalizedPosition = 1f;
    }

    public void ToggleMissions()
    {
        if(missionsOn)
        {
            DisableAllSubmenus();
        }
        else
        {
            DisableAllSubmenus();
            missionsListEntry.SetActive(true);
            missionsOn = true;
        }
        scrollRect.verticalNormalizedPosition = 1f;
    }

    void OnDisable(){
    	DisableAllSubmenus();
    }
}
