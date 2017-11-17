using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerSpawner : MonoBehaviour {

    #region Fields / Properties

    [SerializeField] private GameObject playerPrefab;

    #endregion

    #region Public Behaviour

    public GameObject SpawnPlayer (Vector2 initialPosition, Camera cam) {
        GameObject player = Instantiate(playerPrefab, transform);
        player.transform.position = initialPosition;
        player.GetComponent<PlayerController>().Init(cam);
        return player;
    }

    #endregion
	
}