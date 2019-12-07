﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tutoriales
{
    [CreateAssetMenu(fileName = "itemStats", menuName = "tutoriales/item stats")] ///¿? comentar

    public class ItemStats : ScriptableObject
    {
        public string ItemName;
        public string SlotType;
        public bool HideOnTake;
        public bool ShowOnUse;
        public Sprite Icon;

        //public Vector3 baseRotation;

        public string animation;
        public string animLayer;

    }

}
