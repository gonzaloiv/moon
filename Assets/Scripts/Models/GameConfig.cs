using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameConfig {

    #region Fields / Properties

    // Game
    public static int TimeScale;

    #endregion

    #region Mono Behaviour

    public static void Init (GameConfigData gameConfigData) {
        TimeScale = gameConfigData.TimeScale;
    }

    #endregion

}
