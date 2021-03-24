using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Tweetbook.Contracts.V1;
using Tweetbook.Domain;
using Xunit;

namespace Tweetbook.IntegrationTests
{
    public class PostControllerTests : IntegrationTest
    {
        [Fact]
        public async Task GetAll_WithoutAnyPosts_Returns_EmptyResponse()
        {
            // Arrange
            await AuthenticateAsync();
            // Act
            var response = await TestClient.GetAsync(ApiRoutes.Posts.GetAll);
            // Assert

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            (await response.Content.ReadFromJsonAsync<List<Post>>()).Should().BeEmpty();
        }
    }
}