using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfigData", menuName = "ScriptableObject/GameConfig", order = 1)]
public class GameConfigData : ScriptableObject {

    [Header("Game")]
    public int TimeScale = 1;

    [Header("Camera")]
    public Vector3 CameraInitialPosition = new Vector3(0, 0, -10);
    public float CameraSpeed = 3;

    [Header("Player")]
    public float PlayerMaxDragDistance = 1;
    public float PlayerSpeed = 3;

    [Header("Planet")]
    public float PlanetGravityStrength = 0.1f;
    public float PlanetGravityDistanceRatio = 2;

}