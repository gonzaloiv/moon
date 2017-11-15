using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObject/Game", order = 1)]
public class GameData : ScriptableObject {

    #region Fields / Properties

    [SerializeField] private List<LevelData> levels;

    #endregion

    #region Public Behaviour

    public LevelData GetLevelData (int levelIndex) {
        return levels[levelIndex];
    }

    #endregion

}