using Leopotam.Ecs;
using UnityEngine;

namespace Voody.UniLeo
{
    public abstract class MonoProvider <T> : BaseMonoProvider, IConvertToEntity where T : struct
    {
        [SerializeField]
        protected T value;

        public T Value
        {
            set
            {
                this.value = value;
            }
			get
			{
				return value;
			}
        }

        void IConvertToEntity.Convert(EcsEntity entity)
        {
            entity.Replace(value);
        }
    }
}
