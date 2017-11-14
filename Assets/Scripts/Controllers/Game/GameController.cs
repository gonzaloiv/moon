using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStates;

public class GameController : StateMachine {

    #region Fields / Properties

    [SerializeField] private GameData gameData;
    [SerializeField] private LevelController levelController;
    [SerializeField] private GameObject mainMenuScreen;
    [SerializeField] private GameObject levelScreen;

    public Game Game { get { return game; } }
    public LevelController LevelController { get { return levelController; } }
    public GameObject MainMenuScreen { get { return mainMenuScreen; } }
    public GameObject LevelScreen { get { return levelScreen; } }

    private Game game;

    #endregion

    #region Mono Behaviour

    void Awake() {
        game = new Game(gameData.Levels);
    }

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
