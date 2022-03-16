using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LanguageSelector : MonoBehaviour
{
    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            switch (gameObject.name)
            {
                case "Ita":
                	LoadLocale("it");
                    break;
                case "Eng":
                	LoadLocale("en");
                    break;
            }
        }
    }
    public void LoadLocale(string languageIdentifier)
	{
		LocalizationSettings settings = LocalizationSettings.Instance;
		LocaleIdentifier localeCode = new LocaleIdentifier(languageIdentifier);
		for(int i = 0; i < LocalizationSettings.AvailableLocales.Locales.Count; i++)
		{
			Locale aLocale = LocalizationSettings.AvailableLocales.Locales[i];
			LocaleIdentifier anIdentifier = aLocale.Identifier;
			if(anIdentifier == localeCode)
			{
				LocalizationSettings.SelectedLocale = aLocale;
			}
		}
	}
}
