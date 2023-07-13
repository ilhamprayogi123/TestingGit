using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Localization.Settings;

public class LocalSelect : MonoBehaviour
{
    // Make sure that the coroutine not called more than once
    private bool active;

    private int dataID;

    private void Start()
    {
        // Get saved locale ID
        int ID = PlayerPrefs.GetInt("LocaleKey", dataID);
        ChangeLocale(ID);
    }

    // Change Locale ID
    public void ChangeLocale(int localeID)
    {
        if (active == true)
        {
            return;
        }

        StartCoroutine(SetLocale(localeID));
    }

    // Get locale ID from locale variables
    IEnumerator SetLocale(int _localeID)
    {
        active = true;

        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
        // Save current locale id
        dataID = _localeID;
        PlayerPrefs.SetInt("LocaleKey", _localeID);

        active = false;
    }
}
