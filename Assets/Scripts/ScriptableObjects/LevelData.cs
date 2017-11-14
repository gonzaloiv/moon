using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObject/Level", order = 1)]
public class LevelData : ScriptableObject {

    #region Fields / Properties

    public List<Planet> Planets;

    #endregion

}
