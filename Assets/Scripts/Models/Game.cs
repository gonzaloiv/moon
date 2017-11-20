using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game { // Works as a data provider for Game and Level controllers

    #region Fields / Properties

    public Player Player { get { return player; } } 
    public LevelData CurrentLevelData { get { return gameData.GetLevelData(currentLevelIndex); } }

    private GameData gameData;
    private Player player;
    private int currentLevelIndex;

    #endregion

    #region Public Behaviour

    public void Init (GameData gameData) {
        this.gameData = gameData;
        this.player = new Player(gameData.PlayerInitialLives);
        currentLevelIndex = 0; // TODO: Loading from saved games
    }

    public void IncreaseCurrentLevelIndex() {
        SetCurrentLevelIndex(currentLevelIndex + 1);
    }

    public void SetCurrentLevelIndex(int currentLevelIndex) {
        this.currentLevelIndex = currentLevelIndex;
    }

    #endregion
	
}
