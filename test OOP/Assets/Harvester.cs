using System;
using System.Collections.Generic;
using UnityEngine;

namespace oop
{
    public class Harvester : npc
    {
        private enum HarvestState
        {
            search,
            harvest,
            back
        }

        private HarvestState currentState = HarvestState.search;
        private Vector3 m_target;

        

        private void Search()
        {
            Vector3 nearest = new Vector3();
            // GO THROUGH ALL COLLECTIBLE AND CHECK VECTOR3.DISTANCE TO GET NEAREST
            m_target = nearest;
        }

        protected override void UpdateMovement()
        {
            // can't move during harvest
            if (currentState == HarvestState.harvest)
            {
                return;
            }
            
            base.UpdateMovement();
        }
        protected override void CollisionCollectible(Collectible collectible)
        {
            base.CollisionCollectible(collectible);
            collectible.ApplyHit(1000);
        }
    }
}