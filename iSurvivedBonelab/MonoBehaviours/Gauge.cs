using System;
using UnityEngine;
using UnityEngine.UI;

namespace iSurvivedBonelab.MonoBehaviours
{
    [Elixir]
    [DontAssignIntPtr]
    // TODO: on GaugeTemplate
    public class Gauge : MonoBehaviour
    {
        public enum GaugeType
        {
            Need = 0,
            Effect = 1
        }

        public GaugeType type;

        public Image imageBar;
        public Slider simpleBar;
    }
}
