using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    #region Fields / Properties

    public int Lives { get { return lives; } }
    private int lives;

    #endregion

    #region Public Behaviour

    public Player (int lives) {
        this.lives = lives;
    }

    #endregion
	
}