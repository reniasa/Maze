using System;

namespace Assets
{
    public class HealthCube : AdditionalHealthFactory
    {
        public override int RegenerateHealthpoints { get { return 1; } }

        public override AdditionalHealthFactory CreateHealthObject()
        {
            return new HealthCube();
        }
    }
}
