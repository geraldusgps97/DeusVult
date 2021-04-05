using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {

	private Player currentPlayer;

    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag(gameObject.tag).Length > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(this.gameObject);
    }

    public Player CurrentPlayer {
		get
		{
			if (currentPlayer == null) {
				currentPlayer = gameObject.AddComponent<Player>();
			}
			return currentPlayer;
		}
	}
}
