using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game {

    #region Fields / Properties

    public LevelData CurrentLevel { get { return levels[currentLevelIndex]; } } 

    private List<LevelData> levels;
    private int currentLevelIndex = 0;

    #endregion

    #region Public Behaviour

    public Game(List<LevelData> levels) {
        this.levels = levels;
    }

    public void IncreaseCurrentLevelIndex() {
        SetCurrentLevelIndex(currentLevelIndex + 1);
    }

    public void SetCurrentLevelIndex(int currentLevelIndex) {
        this.currentLevelIndex = currentLevelIndex;
    }

    #endregion

}
