﻿using Accounts.Brokers;
using Accounts.Models.Accounts;
using Accounts.Services.Accounts;
using FluentAssertions;
using Moq;
using Xunit;

namespace MyMath.App.Tests.Unit.Services.Accounts
{
    public class AccountServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IAccountService accountService;

        public AccountServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.accountService = new AccountService(storageBroker: this.storageBrokerMock.Object);
        } 

        [Fact]
        public void ShouldAddAccount()
        {
            // given
            var randomAccount = new Account();
            Account inputAccount = randomAccount;
            Account storageAccount = inputAccount;
            Account expectedAccount = storageAccount;

            this.storageBrokerMock.Setup(broker =>
                 broker.InsertAccount(inputAccount))
                   .Returns(storageAccount);

            // when
            Account actualAccount = this.accountService.AddAccount(inputAccount);

            // then
            actualAccount.Should().BeEquivalentTo(expectedAccount);

            this.storageBrokerMock.Verify(broker => 
                 broker.InsertAccount(inputAccount), Times.Once());

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}