﻿using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class BrasHumain : Bras {

	void Start() {
		Charge = 0;
	}

	void Update() {
		//on override l'update de membre car il n'y a pas de rejet pour les membres humains
		return;
	}
}