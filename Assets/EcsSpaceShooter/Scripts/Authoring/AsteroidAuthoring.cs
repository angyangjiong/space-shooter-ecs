using UnityEngine;
using Unity.Entities;

namespace SpaceShooter
{
    public class AsteroidAuthoring : CollisionAuthoring
    {
        public override void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            base.Convert(entity, dstManager, conversionSystem);
            dstManager.AddComponentData(entity, new AsteroidTag());
        }
    }
}