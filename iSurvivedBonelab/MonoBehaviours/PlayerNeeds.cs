using System;
using System.Collections.Generic;
using UnityEngine;

namespace iSurvivedBonelab.MonoBehaviours
{
    [Elixir]
    [DontAssignIntPtr]
    // TODO: On HUD gameObject
    public class PlayerNeeds : MonoBehaviour
    {
        public List<Need> needs;

        public Transform needGaugeContainer;
        public Transform effectGaugeContainer;

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
