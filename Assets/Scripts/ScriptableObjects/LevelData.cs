using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObject/Level", order = 1)]
public class LevelData : ScriptableObject {

    #region Fields / Properties

    public Vector2 PlayerInitialPosition;
    public int PlayerMovementsAmount;
    public List<Planet> Planets;

    #endregion

}