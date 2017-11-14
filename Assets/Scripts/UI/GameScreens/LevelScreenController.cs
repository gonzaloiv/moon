using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScreenController : MonoBehaviour {

    #region Fields / Properties

    [SerializeField] private Text planetAmountIndicator;

    #endregion

    #region Public Behaviour

    public void Init (LevelData levelData) {
        planetAmountIndicator.text = levelData.Planets.Count.ToString();
    }

    #endregion
	
}