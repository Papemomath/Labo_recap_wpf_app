using IdeaManager.Core.Entities;
using IdeaManager.Core.Interfaces;
using Moq;

namespace IdeaManager.Tests.Services
{
    public class IdeaServiceTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<IRepository<Idea>> _mockIdeaRepository;
        private readonly IdeaService _service;

        public IdeaServiceTests()
        {
            // Fake repo Idea
            _mockIdeaRepository = new Mock<IRepository<Idea>>();

            //Fake IUnitOfWork
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockUnitOfWork .Setup(u => u.IdeaRepository).Returns(_mockIdeaRepository.Object);
            
            _service = new IdeaService(_mockUnitOfWork.Object);
        }

        [Fact]
        public async Task SubmitIdeaAsync_NoTitle_ThrowEcecption()
        {
            // Arrange
            var ideaSansTitre = new Idea { Title = "", Description = "Description" };

            // Act 
            await Assert.ThrowsAsync<ArgumentException>(() => _service.SubmitIdeaAsync(ideaSansTitre));

            // Vérifier que AddAsync et SaveChangesAsync ne sont jamais appelés comme il n'yy pas de titre
            _mockIdeaRepository.Verify(r => r.AddAsync(It.IsAny<Idea>()), Times.Never);
            _mockUnitOfWork.Verify(u => u.SaveChangesAsync(), Times.Never);
        }
        

        [Fact]
        public async Task GetAllAsync_ReturnsAllIdeas()
        {
            // Arrange : créer une liste factice d'idées
            var fakeIdeas = new List<Idea>
            {
                new Idea { Title = "Idée 1", Description = "Desc 1" },
                new Idea { Title = "Idée 2", Description = "Desc 2" }
            };

            // Configurer le mock pour retourner cette liste
            _mockIdeaRepository.Setup(r => r.GetAllAsync()).ReturnsAsync(fakeIdeas);

            // Act - appeler la méthode GetAllAsync
            var result = await _service.GetAllAsync();

            // Assert - vérifier que le résultat est égal à la liste Fake
            Assert.Equal("Idée 1", result[0].Title);
            Assert.Equal("Idée 2", result[1].Title);

            // Vérifie que GetAllAsync du repository a bien été appelé UNE fois
            _mockIdeaRepository.Verify(r => r.GetAllAsync(), Times.Once);
        }

    }
}
