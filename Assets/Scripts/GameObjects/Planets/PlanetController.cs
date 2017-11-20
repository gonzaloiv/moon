using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour {

    #region Fields / Properties

    private float rotationSpeed; // Translation speed separated from rotation speed
    private float translationSpeed;
    private GameObject player;
    private GameObject parent;

    #endregion

    #region Mono Behaviour

    void Update () {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, player.transform.position) <= transform.localScale.x * GameConfig.PlanetGravityDistanceRatio)
            player.GetComponent<Rigidbody2D>().AddForce((transform.position - player.transform.position) * transform.localScale.x * GameConfig.PlanetGravityStrength);
        if(parent != null)
            transform.RotateAround(parent.transform.position, Vector3.forward, translationSpeed * Time.deltaTime);
    }

    #endregion

    #region Public Behaviour

    public void Init (float speed, GameObject player, GameObject parent) {
        rotationSpeed = speed;
        translationSpeed = rotationSpeed / 3; // TODO: Adding this to GameConfig
        this.player = player;
        this.parent = parent;
    }

    #endregion
	
}
