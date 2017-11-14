using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlanetSpawner : MonoBehaviour {

    #region Fields / Properties

    private List<GameObject> currentPlanets;

    #endregion

    #region Public Behaviour

    public void SpawnPlanets(List<Planet> planets) {
        currentPlanets = new List<GameObject>();
        planets.ForEach(planet => currentPlanets.Add(SpawnPlanet(planet)));
    }

    public GameObject SpawnPlanet(Planet planet) {
        GameObject currentPlanet = Instantiate(planet.Prefab);
        currentPlanet.GetComponent<PlanetController>().Init(planet.Speed);
        return currentPlanet;
    }

    #endregion
	
}