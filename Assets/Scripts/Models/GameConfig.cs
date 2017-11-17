using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class GameConfig {

    #region Fields / Properties

    // Game
    public static int TimeScale;

    // Player
    public static int PlayerInitialLives;
    public static float PlayerMaxDragDistance;
    public static  float PlayerSpeed;

    // Planet
    public static float PlanetGravityStrength;

    #endregion

    #region Mono Behaviour

    public static void Init (GameConfigData gameConfigData) {
        TimeScale = gameConfigData.TimeScale;
        PlayerInitialLives = gameConfigData.PlayerInitialLives;
        PlayerMaxDragDistance = gameConfigData.PlayerMaxDragDistance;
        PlayerSpeed = gameConfigData.PlayerSpeed;
        PlanetGravityStrength = gameConfigData.PlanetGravityStrength;
    }

    #endregion

}
