using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameConfig {

    #region Fields / Properties

    public static int TimeScale;
    public static int PlayerInitialLives;

    #endregion

    #region Mono Behaviour

    public static void Init (GameConfigData gameConfigData) {
        TimeScale = gameConfigData.TimeScale;
        PlayerInitialLives = gameConfigData.PlayerInitialLives;
    }

    #endregion

}
