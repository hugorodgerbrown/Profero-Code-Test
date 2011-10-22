using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using Profero.Interview.Business.Core;
using Profero.Interview.Business.Shipping;
using Profero.Interview.IoC;
using System.Linq;

namespace Profero.Interview.Tests
{
    [TestFixture]
    public class CreateSampleData
    {
        [Test]
        public void CreateSampleShippingOptions()
        {
            var shippings = new Dictionary<string, ShippingBase>
                                {
                                    {"FlatRate", new FlatRateShipping{FlatRate = 1.5m}},
                                    {"PerRegion", new PerRegionShipping{PerRegionCosts = 
                                    new List<RegionShippingCost>
                                        {
                                            new RegionShippingCost{DestinationRegion = RegionShippingCost.Regions.UK, Amount = .5m},
                                            new RegionShippingCost{DestinationRegion = RegionShippingCost.Regions.Europe, Amount = 1m},
                                            new RegionShippingCost{DestinationRegion = RegionShippingCost.Regions.RestOfTheWorld, Amount = 2m},
                                        }}}
                                };

            var ser = SerializationHelper.DataContractSerialize(shippings);

            using (var fileWriter = new StreamWriter(@"..\..\..\Profero.Interview\App_Data\Shipping.xml", false))
            {
                fileWriter.Write(ser);
            }

        }

        [Test]
        public void RegistrationTest()
        {
            ObjectFactory.WindsorContainer.Install(new WindsorInstaller());
        }

        [Test]
        public void GetConstants()
        {
            var constants = ReflectionHelpers.GetConstants(typeof (RegionShippingCost.Regions));

            Assert.That(constants.Count(), Is.EqualTo(3));
        }
    }
}
