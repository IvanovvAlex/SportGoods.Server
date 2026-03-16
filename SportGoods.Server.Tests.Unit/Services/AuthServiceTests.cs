using System;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using SportGoods.Server.Common.Requests.Auth;
using SportGoods.Server.Common.Responses.Auth;
using SportGoods.Server.Core.Exceptions;
using SportGoods.Server.Data;
using SportGoods.Server.Data.Entities;
using SportGoods.Server.Data.Interfaces;
using SportGoods.Server.Domain.Services;
using Xunit;

namespace SportGoods.Server.Tests.Unit.Services;

public class AuthServiceTests
{
    private readonly AuthService _authService;
    private readonly ApplicationDbContext _context;
    private readonly Mock<IUserRepository> _userRepositoryMock;
    private readonly Mock<IHttpContextAccessor> _httpContextAccessorMock;

    public AuthServiceTests()
    {
        DbContextOptions<ApplicationDbContext> options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;
        _context = new(options);
        _userRepositoryMock = new();
        _httpContextAccessorMock = new();
        _authService = new(_context, _userRepositoryMock.Object, _httpContextAccessorMock.Object);
    }

    [Fact]
    public async Task RegisterAsync_ShouldThrowAppException_WhenEmailIsAlreadyUsed()
    {
        _userRepositoryMock.Setup(x => x.IsEmailAlreadyUsed(It.IsAny<string>())).ReturnsAsync(true);

        RegisterUserRequest request = new()
        {
            Email = "test@example.com",
            Password = "password123",
            Names = "Test User",
            Phone = "123456789"
        };

        await Assert.ThrowsAsync<AppException>(() => _authService.RegisterAsync(request));
    }

    [Fact]
    public async Task RegisterAsync_ShouldReturnCorrectResponse_WhenUserIsSuccessfullyRegistered()
    {
        _userRepositoryMock.Setup(x => x.IsEmailAlreadyUsed(It.IsAny<string>())).ReturnsAsync(false);

        RegisterUserRequest request = new()
        {
            Email = "test@example.com",
            Password = "password123",
            Names = "Test User",
            Phone = "123456789"
        };

        RegisterUserResponse? response = await _authService.RegisterAsync(request);

        Assert.NotNull(response);
    }

    [Fact]
    public async Task LoginAsync_ShouldReturnNull_WhenUserNotFound()
    {
        _userRepositoryMock.Setup(x => x.IsEmailAlreadyUsed(It.IsAny<string>())).ReturnsAsync(false);

        LoginUserRequest request = new() { Email = "nonexistent@example.com", Password = "password123" };

        TokenResponse? response = await _authService.LoginAsync(request);

        Assert.Null(response);
    }

    [Fact]
    public async Task LogoutAsync_ShouldReturnTrue_WhenLogoutIsSuccessful()
    {
        _context.Users.Add(new()
        {
            RefreshToken = "refreshToken",
            Email = "test",
            Names = "test",
            Phone = "test",
            PasswordHash = "test"

        });
        await _context.SaveChangesAsync();
        
        _httpContextAccessorMock.Setup(x => x.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)).Returns(new Claim(ClaimTypes.NameIdentifier, _context.Users.First().Id.ToString()));

        bool result = await _authService.LogoutAsync();

        Assert.True(result);
    }

    [Fact]
    public async Task RefreshTokensAsync_ShouldReturnNull_WhenUserNotFound()
    {
        RefreshTokenRequest request = new() { UserId = Guid.NewGuid(), RefreshToken = "invalidRefreshToken" };

        TokenResponse? response = await _authService.RefreshTokensAsync(request);

        Assert.Null(response);
    }
}
