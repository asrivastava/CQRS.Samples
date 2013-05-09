using Cqrs.Net;

namespace Cqrs.Net
{
    public static class ServiceLocator
    {
        private static FakeBus _bus;
        public static FakeBus Bus
        {
            set
            {
                _bus = value;
            }
        }

        public static ICommandBus CommandBus
        {
            get
            {
                return (ICommandBus)_bus;
            }
        }

        public static IEventBus EventBus
        {
            get
            {
                return (IEventBus)_bus;
            }
        }
    }
}