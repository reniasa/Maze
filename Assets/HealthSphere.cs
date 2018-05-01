using System;

namespace Assets
{
    class HealthSphere : AdditionalHealthFactory
    {
        public override int RegenerateHealthpoints { get { return 2; } }

        public override AdditionalHealthFactory CreateHealthObject()
        {
            return new HealthSphere();
        }
    }
}
