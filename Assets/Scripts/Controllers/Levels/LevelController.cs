using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LevelStates;

public class LevelController : StateMachine {

    #region Fields / Properties

    [SerializeField] private LevelScreenController levelScreenController;
    [SerializeField] private LevelSpawner levelSpawner;

    public LevelScreenController LevelScreenController { get { return levelScreenController; } }
    public LevelSpawner LevelSpawner { get { return levelSpawner; } }

    #endregion

    #region Public Behaviour

    // Game should work as an independent module, maybe listening to the GameObjects events by itself
    // And then everything related to level indexes would be a LevelController dependent class (Level?)
    public void InitLevel (GameData gameData, Game game) { // TODO: Level model Generation
        LevelData currentLevelData = gameData.GetLevelData(game.CurrentLevelIndex);
        levelScreenController.Init(currentLevelData);
        levelSpawner.SpawnLevel(currentLevelData);
        ToLevelStartState();
    }

    public void ToLevelStartState() {
        ChangeState<LevelStartState>();
    }

    public void ToLevelState() {
        ChangeState<LevelState>();
    }

    public void ToLevelEndState() {
        ChangeState<LevelEndState>();
    }

    #endregion
	
}