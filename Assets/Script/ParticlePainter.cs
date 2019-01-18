using System.Collections.Generic;
using Es.InkPainter;
using UnityEngine;

namespace Onoty3D
{
    public class ParticlePainter : MonoBehaviour
    {
        public Brush Brush = null;
        public ParticleSystem Particle;

        private List<ParticleCollisionEvent> _collisionEvents;

        // Use this for initialization
        private void Start()
        {
            this.Particle = this.GetComponent<ParticleSystem>();
            this._collisionEvents = new List<ParticleCollisionEvent>(16);
        }

        // Update is called once per frame
        private void Update()
        {
        }

        private void OnParticleCollision(GameObject other)
        {
            var safeSize = Particle.GetSafeCollisionEventSize();
            if (this._collisionEvents.Count < safeSize)
            {
                this._collisionEvents = new List<ParticleCollisionEvent>(safeSize);
            }

            this.Particle.GetCollisionEvents(other, this._collisionEvents);

            foreach (var collisionEvent in this._collisionEvents)
            {
                if (collisionEvent.colliderComponent == null)
                {
                    continue;
                }

                var canvas = collisionEvent.colliderComponent.GetComponent<InkCanvas>();
                if (canvas == null)
                {
                    continue;
                }
                canvas.PaintNearestTriangleSurface(Brush, collisionEvent.intersection);
            }
        }
    }
}
