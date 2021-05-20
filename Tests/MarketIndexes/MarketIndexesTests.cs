﻿using MatthiWare.FinancialModelingPrep;
using MatthiWare.FinancialModelingPrep.Model;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.CompanyValuation
{
    public class MarketIndexesTests : TestingBase
    {
        public MarketIndexesTests(ITestOutputHelper testOutput) : base(testOutput)
        {
        }

        [Fact]
        public async Task GetDowJonesCompaniesTests()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.MarketIndexes.GetDowJonesCompaniesAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetNasdaqCompaniesTests()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.MarketIndexes.GetNasdaqCompaniesAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetSP500CompaniesTests()
        {
            var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

            var result = await api.MarketIndexes.GetSP500CompaniesAsync();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }
    }
}
