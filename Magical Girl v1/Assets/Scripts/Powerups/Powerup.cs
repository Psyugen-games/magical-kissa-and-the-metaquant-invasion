using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Powerups
{
    class Powerup : MonoBehaviour
    {
        public static readonly Enums.PUType type = Enums.PUType.NONE;

        [Header("Required Objects")]
        [SerializeField]
        private Transform rotationCenter;
        [SerializeField]
        private GameObject powerup;

        public float Bonus { get; set; }

        [Tooltip("Maximum length of the hellipse.")]
        private float a;
        [SerializeField]
        [Tooltip("Maximum height of the hellipse.")]
        private float b;
        [SerializeField]
        [Tooltip("Speed of particle1.")]
        private float angularSpeed1;
        [SerializeField]
        [Tooltip("Speed of particle2.")]
        private float angularSpeed2;
        [SerializeField]
        [Tooltip("Timeout for extintion.")]
        private float fullTimeout;


        private float alpha, beta, X1, Y1, timeout;

        private void Start()
        {
            timeout = fullTimeout;
        }

        public void FixedUpdate()
        {
            timeout -= Time.deltaTime;

            if (timeout <= 0)
            {
                EventManager.FirePowerupExtinction(type);
                Destroy(gameObject);
            }
            else
            {
                DoMovement();
            }
        }

        private void DoMovement()
        {
            alpha += Time.deltaTime * angularSpeed1;
            beta -= Time.deltaTime * angularSpeed2;

            if (alpha >= 360.0f)
                alpha = 0.0f;

            if (beta <= 0.0f)
                beta = 360.0f;

            X1 = rotationCenter.position.x + a * Mathf.Cos(alpha);
            Y1 = rotationCenter.position.y + b * Mathf.Sin(alpha);

            powerup.transform.position = new Vector2(X1, Y1);
        }
    }
}
