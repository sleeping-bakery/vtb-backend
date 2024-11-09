using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Moq;
using Multibanking.Contracts.Loan;
using Multibanking.Data.OpenAPIBankClients.LoanClient;
using Multibanking.Services.Loans.Implementations;
using Xunit;

namespace Multibanking.Services.Tests.Loans;

[TestSubject(typeof(InstallmentPlanService))]
public class InstallmentPlanServiceTests
{
    private readonly Mock<IInstallmentPlanClient> _mockInstallmentPlanClient;
    private readonly InstallmentPlanService _installmentPlanService;

    public InstallmentPlanServiceTests()
    {
        _mockInstallmentPlanClient = new Mock<IInstallmentPlanClient>();
        _installmentPlanService = new InstallmentPlanService(_mockInstallmentPlanClient.Object);
    }

    [Fact]
    public void GetBankOffers_ShouldReturnListOfBankOffers()
    {
        // Arrange
        var expectedOffers = new List<BankOffer>
        {
            new() { Id = Guid.NewGuid(), QuantityMonths = 12, BankName = "123" },
            new() { Id = Guid.NewGuid(), QuantityMonths = 24, BankName = "123" }
        };
        const int loanSize = 10000;
        const string currency = "USD";

        _mockInstallmentPlanClient.Setup(client => client.GetBankOffers(loanSize, currency))
            .Returns(expectedOffers);

        // Act
        var result = _installmentPlanService.GetBankOffers(loanSize, currency);

        // Assert
        Assert.Equal(expectedOffers, result);
        _mockInstallmentPlanClient.Verify(client => client.GetBankOffers(loanSize, currency), Times.Once);
    }

    [Fact]
    public void CreateInstallmentPlan_ShouldCallInstallmentPlanClientWithCorrectParameters()
    {
        // Arrange
        var bankOfferId = Guid.NewGuid();
        var transactionId = Guid.NewGuid();
        var bankOffer = new BankOffer { Id = bankOfferId, QuantityMonths = 24, BankName = "123" };

        _mockInstallmentPlanClient.Setup(client => client.GetBankOffer(bankOfferId)).Returns(bankOffer);

        // Act
        _installmentPlanService.CreateInstallmentPlan(bankOfferId, transactionId);

        // Assert
        _mockInstallmentPlanClient.Verify(client => client.GetBankOffer(bankOfferId), Times.Once);
        _mockInstallmentPlanClient.Verify(client => client.CreateInstallmentPlan(
            It.Is<InstallmentPlan>(plan =>
                plan.BankOfferId == bankOfferId &&
                plan.TransactionId == transactionId &&
                plan.QuantityMonths == bankOffer.QuantityMonths
            )), Times.Once);
    }

    [Fact]
    public void CreateInstallmentPayment_ShouldCallInstallmentPlanClientWithCorrectParameter()
    {
        // Arrange
        var installmentPlanId = Guid.NewGuid();

        // Act
        _installmentPlanService.CreateInstallmentPayment(installmentPlanId);

        // Assert
        _mockInstallmentPlanClient.Verify(client => client.CreateInstallmentPayment(installmentPlanId), Times.Once);
    }
}