using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour {

    #region Fields / Properties

    private float speed;
    private GameObject player;

    #endregion

    #region Mono Behaviour

    void Update () {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        player.GetComponent<Rigidbody2D>().AddForce((transform.position - player.transform.position) * transform.localScale.x * GameConfig.PlanetGravityStrength);
    }

    #endregion

    #region Public Behaviour

    public void Init (float speed, GameObject player) {
        this.speed = speed;
        this.player = player;
    }

    #endregion
	
}
