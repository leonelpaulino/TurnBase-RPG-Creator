﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
/// <summary>
/// Inventorio del jugador
/// </summary>
[Serializable]
public class Inventory:MonoBehaviour {

    public void Awake () {
        Armors = new List<AbstractArmor>();
        Usables = new List<AbstractUsable>();
        Weapons = new List<AbstractWeapon>();
        AbstractArmor aux = (Resources.Load("Armor/2fde446b-dd6e-459f-8ff8-47082c952525") as GameObject).GetComponent<Armor>().Data;
        AbstractWeapon aux2 = (Resources.Load("Weapon/dfaa859c-5ae4-44b4-9882-6ced915fd665") as GameObject).GetComponent<Weapon>().Data;
        Armors.Add(aux);
        Armors.Add(aux);
        Armors.Add(aux);
        Armors.Add(aux);
        Armors.Add(aux);
        Armors.Add(aux);
        Armors.Add(aux);
        Armors.Add(aux);
        Armors.Add(aux);
        Armors.Add(aux);
        AbstractWeapon copy = new AbstractWeapon();
        copy.ItemName = "Weapon1";
        copy.Image = aux2.Image;
        copy.Description = "Esta es la Primera arama."; 
        Weapons.Add(copy);
        copy = new AbstractWeapon();
        copy.ItemName = "Weapon2";
        copy.Image = aux2.Image;
        copy.Description = "Esta es la Segunda arama."; 
        Weapons.Add(copy);
        copy = new AbstractWeapon();
        copy.ItemName = "Weapon3";
        copy.Image = aux2.Image;
        copy.Description = "Esta es la Tercera arama."; 
        Weapons.Add(copy);
        copy = new AbstractWeapon();
        copy.ItemName = "Weapon4";
        copy.Image = aux2.Image;
        copy.Description = "Esta es la Cuarta arama."; 
        Weapons.Add(copy);
        copy = new AbstractWeapon();
        copy.ItemName = "Weapon5";
        copy.Image = aux2.Image;
        copy.Description = "Esta es la Quinta arama."; 
        Weapons.Add(copy);
        copy = new AbstractWeapon();
        copy.ItemName = "Weapon6";
        copy.Image = aux2.Image;
        copy.Description = "Esta es la Sexta arama."; 
        Weapons.Add(copy);
        copy = new AbstractWeapon();
        copy.ItemName = "Weapon7";
        copy.Image = aux2.Image;
        copy.Description = "Esta es la Septima arama."; 
        Weapons.Add(copy);
        copy = new AbstractWeapon();
        copy.ItemName = "Weapon8";
        copy.Image = aux2.Image;
        copy.Description = "Esta es la Octava arama."; 
        Weapons.Add(copy);
        copy = new AbstractWeapon();
        copy.ItemName = "Weapon9";
        copy.Image = aux2.Image;
        copy.Description = "Esta es la Novena arama."; 
        Weapons.Add(copy);
    }
    /// <summary>
    /// Lista de armor
    /// </summary>
    public List<AbstractArmor> Armors;
    /// <summary>
    /// Lista de Usables
    /// </summary>
    public List<AbstractUsable> Usables;
    /// <summary>
    /// Lista de weapons
    /// </summary>
    public List<AbstractWeapon> Weapons;
    /// <summary>
    /// Retorna una lista de armor dado un tipo
    /// </summary>
    /// <param name="type"> Tipo de armor</param>
    /// <returns>lista de armors</returns>
    public List<AbstractArmor> TypeArmor(AbstractArmor.ArmorType type) {
        List<AbstractArmor> returnList = new List<AbstractArmor>();
        foreach (AbstractArmor i in Armors) {
            if (i.Type == type)
                returnList.Add(i);
        }
        return returnList;
    }
}