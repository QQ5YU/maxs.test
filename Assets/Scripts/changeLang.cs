using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization; 

public class changeLang : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetSelectedLocale(Locale locale) 
    {
        LocalizationSettings.SelectedLocale = locale;
    }

    public void changeLangToEN() {
        SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[0]);
    }
    public void changeLangToJP() {
        SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[1]);
    }

    public void changeLangToKR() {
        SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[2]);
    }
}
