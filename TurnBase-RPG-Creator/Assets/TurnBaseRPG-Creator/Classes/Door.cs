﻿using UnityEngine;
using System.Collections;
/// <summary>
/// Representa una puerta en el juego.
/// </summary>
public class Door: RPGElement  {
    public Door() {
        InMap = new AbstractMap();
        OutMap = new AbstractMap();
    }
    /// <summary>
    /// Define cual es el mapa que se va mostrar al salir por la puerta
    /// </summary>
    public AbstractMap InMap;
    /// <summary>
    // Define cual es el mapa que se va mostrar al salir por la puerta
    /// </summary>
    public AbstractMap OutMap;
    /// <summary>
    /// Sprite que representa la puerta.
    /// </summary>
    public Sprite Image;

}
