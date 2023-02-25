using System.Collections.Generic;
using UnityEngine;

namespace iSurvivedBonelab.MonoBehaviours
{
    // TODO: On HUD gameObject
    public class PlayerNeeds : MonoBehaviour
    {
        public List<Need> needs;

        public Need GetNeed(string name)
        {
            return needs.Find(item => item.DisplayName == name);
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            
        }

        private void DecayPlayerHealth(float amount)
        {
            
        }
    }
}
