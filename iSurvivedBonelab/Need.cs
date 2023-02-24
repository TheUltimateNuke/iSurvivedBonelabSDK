using iSurvivedBonelab.MonoBehaviours;
using SLZ.UI;
using UnityEngine;
using UnityEngine.UI;

namespace iSurvivedBonelab
{
    [System.Serializable]
    public class Need
    {
        public NeedPref prefs;
        public NeedEle ele;

        public Image imageBar;
        public Slider simpleBar;

        public string DisplayName { get; }

        public bool enabled;
        public bool decayHealthWhenEmpty;
        public bool passiveDecay;

        public float curValue;
        public float maxValue;
        public float startValue;
        public float decayRate;
        public float regenRate;
        public float healthDecayRate;

        public void Add(float amount)
        {
            
        }

        public void Subtract(float amount)
        {
            
        }
        
        public void CreatePrefsAndEle()
        {
            
        }
    }
}
