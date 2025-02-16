using AutoMapper;

namespace CustomerApi.Tests
{
    public class AutoMapperConfigurationTests
    {
        private IMapper _mapper;

        [SetUp]
        public void Setup()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile()); // Ensure this is the correct name and location of your AutoMapper profile
            });
            _mapper = mappingConfig.CreateMapper();
        }

        [Test]
        public void AutoMapper_Configuration_ShouldBeValid()
        {
            _mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}
