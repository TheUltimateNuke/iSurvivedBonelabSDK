using UnityEngine;
using UnityEngine.UI;

namespace iSurvivedBonelab
{
    [System.Serializable]
    public class Need
    {
        //public NeedPref prefs;
        //public NeedEle ele;

        public Image imageBar;
        public Slider simpleBar;

        public float curValue;
        public float maxValue;
        public float startValue;

        public float decayRate;
        public float regenRate;

        public string displayName;

        public bool enabled;
        public bool decayHealthWhenEmpty;

        public float healthDecayWhenEmpty;

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

        public Need()
        {
            
        }
    }
}
