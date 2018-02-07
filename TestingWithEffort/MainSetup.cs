using NUnit.Framework;

namespace TestingWithEffort
{
    [SetUpFixture]
    public class MainSetup
    {
        [OneTimeSetUp]
        public void Setup()
        {
            Effort.Provider.EffortProviderConfiguration.RegisterProvider();
        }
    }
}