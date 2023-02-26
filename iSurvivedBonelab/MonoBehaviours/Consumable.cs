using SLZ.VFX;
using System;
using UltEvents;
using UnityEngine;

namespace iSurvivedBonelab.MonoBehaviours
{
    [Elixir]
    [DontAssignIntPtr]
    public class Consumable : MonoBehaviour
    {
        public string needDisplayName;

        // TODO: Soon maybe
        //public MeshRenderer[] biteRenderers;

        public AudioClip[] biteSounds;
        public AudioClip[] consumeSounds;
        
        public AudioSource audioOutput;

        public Blip blipScript;

        public int maxBites = 1;

        public int PointsGivenPerBite = 15;

        public UltEvent<Collider, Consumable> onConsumed;
        public UltEvent<Collider, Consumable> onBite;

        public string mouthName = "Mouth";

        private int _curBites;

        // TODO: Soon maybe
        //private MeshRenderer _curBiteRenderer;

        private PlayerNeeds _playerNeeds;

        private Need _curType;

        private void Start()
        {
            
        }

        private void OnTriggerEnter(Collider other)
        {
            
        }

        private void PlayRandomSound(AudioClip[] sounds)
        {
            
        }

        private void Consume(Collider other)
        {
            
        }
    }
}
