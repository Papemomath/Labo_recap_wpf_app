using IdeaManager.Core.Entities;
using IdeaManager.Core.Interfaces;
using IdeaManager.Services;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace IdeaManager.Tests.Services
{
    public class IdeaServiceTests
    {
        private readonly Mock<IRepository<Idea>> _mockRepository;
        private readonly IdeaService _ideaService;

        public IdeaServiceTests()
        {
            _mockRepository = new Mock<IRepository<Idea>>();
            //_ideaService = new IdeaService(_mockRepository);
        }

        [Fact]
        public async Task SubmitIdea_InvalidTitle_ThrowsException()
        {
            var idea = new Idea
            {
                Id = 1,
                Title = "",
                Description = "",
            };
            await Assert.ThrowsAsync<ArgumentException>(() => _ideaService.SubmitIdeaAsync(idea));

        }
    }
}
