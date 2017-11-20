using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LevelStates;

public class LevelController : StateMachine { // Takes care of every action during playtime, and between levels too

    #region Fields / Properties

    [SerializeField] private LevelScreenController levelScreenController;
    [SerializeField] private LevelSpawner levelSpawner;

    public LevelScreenController LevelScreenController { get { return levelScreenController; } }
    public LevelSpawner LevelSpawner { get { return levelSpawner; } }
    public Game Game { get { return game; } }

    private Game game;

    #endregion

    #region Public Behaviour

    public void Init (Game game) { // Wouldn't it be nicer a InitState ?
        this.game = game;
        gameObject.SetActive(true);
        ToLevelStartState();
    }

    public void Disable() { // Temporary naming...
        gameObject.SetActive(false);
        levelScreenController.Hide();
    }

    public void ToLevelStartState () {
        ChangeState<LevelStartState>();
    }

    public void ToLevelState () {
        ChangeState<LevelState>();
    }

    public void ToLevelEndState () {
        ChangeState<LevelEndState>();
    }

    #endregion

}