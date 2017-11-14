using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour { // This could be replaced by a common interface between spawners

    #region Fields / Properties

    [SerializeField] private PlanetSpawner planetSpawner;

    #endregion

    #region Public Behaviour

    public void SpawnLevel(LevelData levelData) {
        planetSpawner.SpawnPlanets(levelData.Planets);
    }

    #endregion
	
}
