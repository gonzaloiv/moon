using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObject/Game", order = 1)]
public class GameData : ScriptableObject {

    #region Fields / Properties

    public int PlayerInitialLives { get { return playerInitialLives; } } 

    [SerializeField] int playerInitialLives = 3;
    [SerializeField] List<LevelData> levels;

    #endregion

    #region Public Behaviour

    public LevelData GetLevelData (int levelIndex) {
        return levels[levelIndex];
    }

    #endregion

}