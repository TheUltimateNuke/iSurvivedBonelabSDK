using iSurvivedBonelab.MonoBehaviours;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace iSurvivedBonelab
{
    [System.Serializable]
    public class Need
    {
        public string DisplayName;
        public bool enabled;

        public Color barColor;
        public Sprite icon;

        [Tooltip("Optional")]
        public Gauge gauge;

        public bool decayHealthWhenEmpty;
        public bool passiveDecay;

        public float curValue;
        public float maxValue;
        public float startValue;
        public float decayRate;
        public float regenRate;
        public float healthDecayRate;

        public NeedPref prefs;
        public NeedEle ele;

        public void Add(float amount)
        {
            
        }

        public void Subtract(float amount)
        {
            
        }

        public float GetPercentage()
        {
            return curValue / maxValue;
        }
        
        public void CreatePrefsAndEle()
        {
            
        } 
    }
}
