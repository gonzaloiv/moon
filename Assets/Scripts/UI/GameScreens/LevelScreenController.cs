using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScreenController : BaseScreenController {

    #region Fields / Properties

    [SerializeField] private Text playerMovesAmountIndicator;
    [SerializeField] private Text planetAmountIndicator;

    #endregion

    #region Public Behaviour

    public void Show (LevelData levelData) {
        base.Show();
        playerMovesAmountIndicator.text = levelData.PlayerMovementsAmount.ToString("000");
        planetAmountIndicator.text = levelData.Planets.Count.ToString("000");
    }

    #endregion
	
}