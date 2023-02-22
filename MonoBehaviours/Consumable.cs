using SLZ.VFX;
using System;
using UltEvents;
using UnityEngine;

namespace iSurvivedBonelab.MonoBehaviours
{
    public class Consumable : MonoBehaviour
    {
        public Need type;

        public MeshRenderer[] biteRenderers;

        public AudioClip[] biteSounds;
        public AudioClip[] consumeSounds;
        
        public AudioSource audioOutput;

        public Blip blipScript;

        public int maxBites = 1;

        public int PointsGivenPerBite = 15;

        public UltEvent<Collider, Consumable> onConsumed;
        public UltEvent<Collider, Consumable> onBite;

        public string mouthTag = "Mouth";

        private int _curBites;

        private MeshRenderer _curBiteRenderer;

        private void Start()
        {
            
        }

        private void OnTriggerEnter(Collider collider)
        {
            
        }

        private void PlayRandomSound(AudioClip[] sounds)
        {
            
        }

    }
}
