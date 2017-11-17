using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfigData", menuName = "ScriptableObject/GameConfig", order = 1)]
public class GameConfigData : ScriptableObject {

	[Header("Game")]
	public int TimeScale = 1;

    [Header("Player")]
    public int PlayerInitialLives = 3;
    public float PlayerMaxDragDistance = 1;
    public float PlayerSpeed = 3;

    [Header("Planet")]
    public float PlanetGravityStrength = 0.03f;

}