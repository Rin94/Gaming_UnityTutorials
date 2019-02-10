﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Comportamiento del disparo
/// </summary>
public class DisparoScript : MonoBehaviour
{
	/// <summary>
	/// Daño inflingido
	/// </summary>
	public int danho = 0;
	
	/// <summary>
	/// El disparo es del jugador o del enemigo?
	/// </summary>
	public bool esDisparoEnemigo = false;
	
	void Start()
	{
		// Que desaparezca el objeto disparo despues de un tiempo definido
		Destroy(gameObject, 20); // 20 segundos
	}
}

