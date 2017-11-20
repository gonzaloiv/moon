using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class GameConfig {

    #region Fields / Properties

    // Game
    public static int TimeScale;

    // Camera
    public static float CameraSpeed;
    public static Vector3 CameraInitialPosition;

    // Player
    public static float PlayerMaxDragDistance;
    public static  float PlayerSpeed;

    // Planet
    public static float PlanetGravityStrength;
    public static float PlanetGravityDistanceRatio;

    #endregion

    #region Mono Behaviour

    public static void Init (GameConfigData gameConfigData) {
        TimeScale = gameConfigData.TimeScale;
        CameraSpeed = gameConfigData.CameraSpeed;
        CameraInitialPosition = gameConfigData.CameraInitialPosition;
        PlayerMaxDragDistance = gameConfigData.PlayerMaxDragDistance;
        PlayerSpeed = gameConfigData.PlayerSpeed;
        PlanetGravityStrength = gameConfigData.PlanetGravityStrength;
        PlanetGravityDistanceRatio = gameConfigData.PlanetGravityDistanceRatio;
    }

    #endregion

}
