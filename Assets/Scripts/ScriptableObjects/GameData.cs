using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObject/Game", order = 1)]
public class GameData : ScriptableObject {

    #region Fields / Properties

    public List<LevelData> Levels;

    #endregion

}
