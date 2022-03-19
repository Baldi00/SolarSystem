using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfosMenuManager : MonoBehaviour
{
	private GameObject mercuryEntry, venusEntry, earthEntry, marsEntry, jupiterEntry, saturnEntry, uranusEntry, neptuneEntry, dwarfPlanetEntry, ceresEntry, plutoEntry, haumeaEntry, makemakeEntry, erisEntry;
	private GameObject m1E, m2E, m3E, m4E, m5E, m6E, m7E, m8E, m9E, m10E, m11E, m12E, m13E, m14E, m15E, m16E, m17E, m18E, m19E, m20E;
	private GameObject waw1, waw2, waw3, waw4, waw5, waw6, waw7, waw8;
    private GameObject mis1E, mis2E, mis3E, mis4E, mis5E, mis6E, mis7E, mis8E, mis9E, mis10E, mis11E, mis12E, mis13E, mis14E, mis15E, mis16E, mis17E, mis18E, mis19E, mis20E, mis21E, mis22E, mis23E, mis24E, mis25E, mis26E, mis27E, mis28E, mis29E, mis30E, mis31E, mis32E;
	private GameObject sp2, sp3, sp4, sp5;
	private bool planetsOn, moonsOn, whereAreWeOn, missionsOn;
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
        dwarfPlanetEntry = GameObject.Find("DwarfPlanetEntry");
        ceresEntry = GameObject.Find("CeresEntry");
        plutoEntry = GameObject.Find("PlutoEntry");
        haumeaEntry = GameObject.Find("HaumeaEntry");
        makemakeEntry = GameObject.Find("MakemakeEntry");
        erisEntry = GameObject.Find("ErisEntry");
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
        mis1E = GameObject.Find("ApolloEntry");
        mis2E = GameObject.Find("ArtemisEntry");
        mis3E = GameObject.Find("CassiniEntry");
        mis4E = GameObject.Find("ChandraEntry");
        mis5E = GameObject.Find("CuriosityEntry");
        mis6E = GameObject.Find("DartEntry");
        mis7E = GameObject.Find("DawnEntry");
        mis8E = GameObject.Find("DeepSpaceEntry");
        mis9E = GameObject.Find("ExoMarsEntry");
        mis10E = GameObject.Find("GalileoEntry");
        mis11E = GameObject.Find("HubbleEntry");
        mis12E = GameObject.Find("IngenuityEntry");
        mis13E = GameObject.Find("ISSEntry");
        mis14E = GameObject.Find("JunoEntry");
        mis15E = GameObject.Find("KeplerEntry");
        mis16E = GameObject.Find("LunarOrbiterEntry");
        mis17E = GameObject.Find("MagellanEntry");
        mis18E = GameObject.Find("MarinerEntry");
        mis19E = GameObject.Find("MarsExpressEntry");
        mis20E = GameObject.Find("MarsOdysseyEntry");
        mis21E = GameObject.Find("MarsPathfinderEntry");
        mis22E = GameObject.Find("NewHorizonsEntry");
        mis23E = GameObject.Find("OpportunityEntry");
        mis24E = GameObject.Find("PerseveranceEntry");
        mis25E = GameObject.Find("PioneerEntry");
        mis26E = GameObject.Find("ShuttleEntry");
        mis27E = GameObject.Find("SpiritEntry");
        mis28E = GameObject.Find("SpitzerEntry");
        mis29E = GameObject.Find("SputnikEntry");
        mis30E = GameObject.Find("VikingEntry");
        mis31E = GameObject.Find("VoyagerEntry");
        mis32E = GameObject.Find("WebbEntry");
        sp2 = GameObject.Find("Spacing2");
        sp3 = GameObject.Find("Spacing3");
        sp4 = GameObject.Find("Spacing4");
        sp5 = GameObject.Find("Spacing5");
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
        if(dwarfPlanetEntry != null) dwarfPlanetEntry.SetActive(false);
        if(ceresEntry != null) ceresEntry.SetActive(false);
        if(plutoEntry != null) plutoEntry.SetActive(false);
        if(haumeaEntry != null) haumeaEntry.SetActive(false);
        if(makemakeEntry != null) makemakeEntry.SetActive(false);
        if(erisEntry != null) erisEntry.SetActive(false);
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
        if(mis1E != null) mis1E.SetActive(false);
        if(mis2E != null) mis2E.SetActive(false);
        if(mis3E != null) mis3E.SetActive(false);
        if(mis4E != null) mis4E.SetActive(false);
        if(mis5E != null) mis5E.SetActive(false);
        if(mis6E != null) mis6E.SetActive(false);
        if(mis7E != null) mis7E.SetActive(false);
        if(mis8E != null) mis8E.SetActive(false);
        if(mis9E != null) mis9E.SetActive(false);
        if(mis10E != null) mis10E.SetActive(false);
        if(mis11E != null) mis11E.SetActive(false);
        if(mis12E != null) mis12E.SetActive(false);
        if(mis13E != null) mis13E.SetActive(false);
        if(mis14E != null) mis14E.SetActive(false);
        if(mis15E != null) mis15E.SetActive(false);
        if(mis16E != null) mis16E.SetActive(false);
        if(mis17E != null) mis17E.SetActive(false);
        if(mis18E != null) mis18E.SetActive(false);
        if(mis19E != null) mis19E.SetActive(false);
        if(mis20E != null) mis20E.SetActive(false);
        if(mis21E != null) mis21E.SetActive(false);
        if(mis22E != null) mis22E.SetActive(false);
        if(mis23E != null) mis23E.SetActive(false);
        if(mis24E != null) mis24E.SetActive(false);
        if(mis25E != null) mis25E.SetActive(false);
        if(mis26E != null) mis26E.SetActive(false);
        if(mis27E != null) mis27E.SetActive(false);
        if(mis28E != null) mis28E.SetActive(false);
        if(mis29E != null) mis29E.SetActive(false);
        if(mis30E != null) mis30E.SetActive(false);
        if(mis31E != null) mis31E.SetActive(false);
        if(mis32E != null) mis32E.SetActive(false);
        if(sp2 != null) sp2.SetActive(false);
        if(sp3 != null) sp3.SetActive(false);
        if(sp4 != null) sp4.SetActive(false);
        if(sp5 != null) sp5.SetActive(false);
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
            dwarfPlanetEntry.SetActive(true);
            ceresEntry.SetActive(true);
            plutoEntry.SetActive(true);
            haumeaEntry.SetActive(true);
            makemakeEntry.SetActive(true);
            erisEntry.SetActive(true);
            sp2.SetActive(true);
            sp5.SetActive(true);
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

    public void ToggleMissions()
    {
        if(missionsOn)
        {
            DisableAllSubmenus();
        }
        else
        {
            DisableAllSubmenus();
            mis1E.SetActive(true);
            mis2E.SetActive(true);
            mis3E.SetActive(true);
            mis4E.SetActive(true);
            mis5E.SetActive(true);
            mis6E.SetActive(true);
            mis7E.SetActive(true);
            mis8E.SetActive(true);
            mis9E.SetActive(true);
            mis10E.SetActive(true);
            mis11E.SetActive(true);
            mis12E.SetActive(true);
            mis13E.SetActive(true);
            mis14E.SetActive(true);
            mis15E.SetActive(true);
            mis16E.SetActive(true);
            mis17E.SetActive(true);
            mis18E.SetActive(true);
            mis19E.SetActive(true);
            mis20E.SetActive(true);
            mis21E.SetActive(true);
            mis22E.SetActive(true);
            mis23E.SetActive(true);
            mis24E.SetActive(true);
            mis25E.SetActive(true);
            mis26E.SetActive(true);
            mis27E.SetActive(true);
            mis28E.SetActive(true);
            mis29E.SetActive(true);
            mis30E.SetActive(true);
            mis31E.SetActive(true);
            mis32E.SetActive(true);
            missionsOn = true;
        }
        scrollRect.verticalNormalizedPosition = 1f;
    }

    void OnDisable(){
    	DisableAllSubmenus();
    }
}
