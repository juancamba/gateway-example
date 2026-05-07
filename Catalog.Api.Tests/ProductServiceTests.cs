
using Catalog.Api.Services;

namespace Catalog.Api.Tests;
public class ProductServiceTests
{
    [Fact]
    public async Task GetByIdAsync_ShouldReturnProduct()
    {
        // Arrange
        var service = new ProductService();

        // Act
        var result = await service.GetByIdAsync(1);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Keyboard", result!.Product );
        
    }
}
