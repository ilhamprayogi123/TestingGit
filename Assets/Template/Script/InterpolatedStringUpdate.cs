using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.SmartFormat.Extensions;
using UnityEngine.Localization.SmartFormat.GlobalVariables;

public class InterpolatedStringUpdate : MonoBehaviour
{
    [SerializeField] private string[] _characterNames;

    private void Start()
    {
        var source = LocalizationSettings
            .StringDatabase
            .SmartFormatter
            .GetSourceExtension<PersistentVariablesSource>();
        var characterName =
            source["global"]["PlayerName"] as UnityEngine.Localization.SmartFormat.PersistentVariables.StringVariable;
        var randomCharacterName = _characterNames[
            Random.Range(0, _characterNames.Length)
        ];

        characterName.Value = randomCharacterName;
    }
}
