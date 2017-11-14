using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStates;

public class GameController : StateMachine {

    #region Fields / Properties

    [SerializeField] private GameObject mainMenuScreen;
    [SerializeField] private GameObject levelScreen;

    public GameObject MainMenuScreen { get { return mainMenuScreen; } }
    public GameObject LevelScreen { get { return levelScreen; } }

    #endregion

    #region Mono Behaviour

    void Start () {
        ChangeState<InitState>();		
    }

    #endregion

    #region Public Behaviour

    public void ToMainMenuState () {
        ChangeState<MainMenuState>();
    }

    public void ToLevelState () {
        ChangeState<LevelState>();
    }

    #endregion

}
