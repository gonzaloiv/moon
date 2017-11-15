using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    #region Fields / Properties

    [SerializeField] private LevelScreenController levelScreenController;
    [SerializeField] private LevelSpawner levelSpawner;

    private GameData gameData;
    private Game game; // Game should work as an independent module carrying all the data and models of the game

    #endregion

    #region Public Behaviour

    public void InitLevel (GameData gameData, Game game) { // TODO: Level model Generation
        LevelData currentLevelData = gameData.GetLevelData(game.CurrentLevelIndex);
        levelScreenController.Init(currentLevelData);
        levelSpawner.SpawnLevel(currentLevelData);
    }

    #endregion
	
}