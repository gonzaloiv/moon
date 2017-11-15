using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game { // Works as a data provider for Game and Level controllers

    #region Fields / Properties

    public Player Player { get { return player; } } 
    public int CurrentLevelIndex { get { return currentLevelIndex; } } // TODO: Including here a Level class containing the points on the GDD

    private Player player;
    private int currentLevelIndex;

    #endregion

    #region Public Behaviour

    public void Init (Player player) {
        this.player = player;
        currentLevelIndex = 0;
    }

    public void IncreaseCurrentLevelIndex() {
        SetCurrentLevelIndex(currentLevelIndex + 1);
    }

    public void SetCurrentLevelIndex(int currentLevelIndex) {
        this.currentLevelIndex = currentLevelIndex;
    }

    #endregion
	
}
