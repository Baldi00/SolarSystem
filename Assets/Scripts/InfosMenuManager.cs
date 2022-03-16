using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfosMenuManager : MonoBehaviour
{
	private GameObject mercuryEntry, venusEntry, earthEntry, marsEntry, jupiterEntry, saturnEntry, uranusEntry, neptuneEntry, plutoEntry;
	private GameObject m1E, m2E, m3E, m4E, m5E, m6E, m7E, m8E, m9E, m10E, m11E, m12E, m13E, m14E, m15E, m16E, m17E, m18E, m19E, m20E;
	private GameObject waw1, waw2, waw3, waw4, waw5, waw6, waw7, waw8;
	private GameObject sp2, sp3, sp4;
	private bool planetsOn, moonsOn, whereAreWeOn;
	private ScrollRect scrollRect;

    // Start is called before the first frame update
    void Start()
    {
        mercuryEntry = GameObject.Find("MercuryEntry");
        venusEntry = GameObject.Find("VenusEntry");
        earthEntry = GameObject.Find("EarthEntry");
        marsEntry = GameObject.Find("MarsEntry");
        jupiterEntry = GameObject.Find("JupiterEntry");
        saturnEntry = GameObject.Find("SaturnEntry");
        uranusEntry = GameObject.Find("UranusEntry");
        neptuneEntry = GameObject.Find("NeptuneEntry");
        plutoEntry = GameObject.Find("PlutoEntry");
        m1E = GameObject.Find("MoonEntry");
        m2E = GameObject.Find("PhobosEntry");
        m3E = GameObject.Find("DeimosEntry");
        m4E = GameObject.Find("IoEntry");
        m5E = GameObject.Find("EuropaEntry");
        m6E = GameObject.Find("GanymedeEntry");
        m7E = GameObject.Find("CallistoEntry");
        m8E = GameObject.Find("MimasEntry");
        m9E = GameObject.Find("EnceladusEntry");
        m10E = GameObject.Find("TethysEntry");
        m11E = GameObject.Find("DioneEntry");
        m12E = GameObject.Find("RheaEntry");
        m13E = GameObject.Find("TitanEntry");
        m14E = GameObject.Find("IapetusEntry");
        m15E = GameObject.Find("ArielEntry");
        m16E = GameObject.Find("UmbrielEntry");
        m17E = GameObject.Find("TitaniaEntry");
        m18E = GameObject.Find("OberonEntry");
        m19E = GameObject.Find("MirandaEntry");
        m20E = GameObject.Find("TritonEntry");
        waw1 = GameObject.Find("WhereAreWe (1)");
        waw2 = GameObject.Find("WhereAreWe (2)");
        waw3 = GameObject.Find("WhereAreWe (3)");
        waw4 = GameObject.Find("WhereAreWe (4)");
        waw5 = GameObject.Find("WhereAreWe (5)");
        waw6 = GameObject.Find("WhereAreWe (6)");
        waw7 = GameObject.Find("WhereAreWe (7)");
        waw8 = GameObject.Find("WhereAreWe (8)");
        sp2 = GameObject.Find("Spacing2");
        sp3 = GameObject.Find("Spacing3");
        sp4 = GameObject.Find("Spacing4");
        scrollRect = GetComponent<ScrollRect>();
        DisableAllSubmenus();
        scrollRect.verticalNormalizedPosition = 1f;
    }

    private void DisableAllSubmenus()
    {
        if(mercuryEntry != null) mercuryEntry.SetActive(false);
        if(venusEntry != null) venusEntry.SetActive(false);
        if(earthEntry != null) earthEntry.SetActive(false);
        if(marsEntry != null) marsEntry.SetActive(false);
        if(jupiterEntry != null) jupiterEntry.SetActive(false);
        if(saturnEntry != null) saturnEntry.SetActive(false);
        if(uranusEntry != null) uranusEntry.SetActive(false);
        if(neptuneEntry != null) neptuneEntry.SetActive(false);
        if(plutoEntry != null) plutoEntry.SetActive(false);
        if(m1E != null) m1E.SetActive(false);
        if(m2E != null) m2E.SetActive(false);
        if(m3E != null) m3E.SetActive(false);
        if(m4E != null) m4E.SetActive(false);
        if(m5E != null) m5E.SetActive(false);
        if(m6E != null) m6E.SetActive(false);
        if(m7E != null) m7E.SetActive(false);
        if(m8E != null) m8E.SetActive(false);
        if(m9E != null) m9E.SetActive(false);
        if(m10E != null) m10E.SetActive(false);
        if(m11E != null) m11E.SetActive(false);
        if(m12E != null) m12E.SetActive(false);
        if(m13E != null) m13E.SetActive(false);
        if(m14E != null) m14E.SetActive(false);
        if(m15E != null) m15E.SetActive(false);
        if(m16E != null) m16E.SetActive(false);
        if(m17E != null) m17E.SetActive(false);
        if(m18E != null) m18E.SetActive(false);
        if(m19E != null) m19E.SetActive(false);
        if(m20E != null) m20E.SetActive(false);
        if(waw1 != null) waw1.SetActive(false);
        if(waw2 != null) waw2.SetActive(false);
        if(waw3 != null) waw3.SetActive(false);
        if(waw4 != null) waw4.SetActive(false);
        if(waw5 != null) waw5.SetActive(false);
        if(waw6 != null) waw6.SetActive(false);
        if(waw7 != null) waw7.SetActive(false);
        if(waw8 != null) waw8.SetActive(false);
        if(sp2 != null) sp2.SetActive(false);
        if(sp3 != null) sp3.SetActive(false);
        if(sp4 != null) sp4.SetActive(false);
        planetsOn = false;
        moonsOn = false;
        whereAreWeOn = false;
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
	    	mercuryEntry.SetActive(true);
	        venusEntry.SetActive(true);
	        earthEntry.SetActive(true);
	        marsEntry.SetActive(true);
	        jupiterEntry.SetActive(true);
	        saturnEntry.SetActive(true);
	        uranusEntry.SetActive(true);
	        neptuneEntry.SetActive(true);
	        plutoEntry.SetActive(true);
	        sp2.SetActive(true);
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
	    	m1E.SetActive(true);
	        m2E.SetActive(true);
	        m3E.SetActive(true);
	        m4E.SetActive(true);
	        m5E.SetActive(true);
	        m6E.SetActive(true);
	        m7E.SetActive(true);
	        m8E.SetActive(true);
	        m9E.SetActive(true);
	        m10E.SetActive(true);
	        m11E.SetActive(true);
	        m12E.SetActive(true);
	        m13E.SetActive(true);
	        m14E.SetActive(true);
	        m15E.SetActive(true);
	        m16E.SetActive(true);
	        m17E.SetActive(true);
	        m18E.SetActive(true);
	        m19E.SetActive(true);
	        m20E.SetActive(true);
	        sp3.SetActive(true);
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
	        waw1.SetActive(true);
	        waw2.SetActive(true);
	        waw3.SetActive(true);
	        waw4.SetActive(true);
	        waw5.SetActive(true);
	        waw6.SetActive(true);
	        waw7.SetActive(true);
	        waw8.SetActive(true);
	        sp4.SetActive(true);
	        whereAreWeOn = true;
    	}
        scrollRect.verticalNormalizedPosition = 1f;
    }

    void OnDisable(){
    	DisableAllSubmenus();
    }
}
