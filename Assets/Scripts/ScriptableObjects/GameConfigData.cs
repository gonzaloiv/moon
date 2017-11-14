using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfigData", menuName = "ScriptableObject/GameConfig", order = 1)]
public class GameConfigData : ScriptableObject {

	[Header("Game")]
	public int TimeScale = 1;

}