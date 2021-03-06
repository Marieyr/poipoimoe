﻿using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Poi.Moe.Data
{
    public class MoeDbMigrationService : ITransientDependency
    {
        public ILogger<MoeDbMigrationService> Logger { get; set; }

        private readonly IDataSeeder _dataSeeder;
        private readonly IMoeDbSchemaMigrator _dbSchemaMigrator;

        public MoeDbMigrationService(
            IDataSeeder dataSeeder,
            IMoeDbSchemaMigrator dbSchemaMigrator)
        {
            _dataSeeder = dataSeeder;
            _dbSchemaMigrator = dbSchemaMigrator;

            Logger = NullLogger<MoeDbMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            Logger.LogInformation("Migrating database schema...");
            await _dbSchemaMigrator.MigrateAsync();

            Logger.LogInformation("Executing database seed...");
            await _dataSeeder.SeedAsync();

            Logger.LogInformation("Successfully completed database migrations.");
        }
    }
}