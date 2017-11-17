using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameStates;

public class GameController : StateMachine {

    #region Fields / Properties

    [SerializeField] private GameData gameData;
    [SerializeField] private GameConfigData gameConfigData;
    [SerializeField] private LevelController levelController;
    [SerializeField] private GameObject mainMenuScreen;
    [SerializeField] private GameObject levelScreen;

    public GameData GameData { get { return gameData; } }
    public GameConfigData GameConfigData { get { return gameConfigData; } }
    public LevelController LevelController { get { return levelController; } }
    public GameObject MainMenuScreen { get { return mainMenuScreen; } }
    public GameObject LevelScreen { get { return levelScreen; } }
    public Game Game {  get { return game; } }

    private Game game = new Game();

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
