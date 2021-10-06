using System;
using System.Data.Common;
using System.IO;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Bluebird.Tests
{
    public class SqliteConnectionProvider : IDisposable
    {
        public DbConnection Connection { get; }

        public DbContextOptions<TContext> GetDbContextOptions<TContext>()
            where TContext : DbContext
            => new DbContextOptionsBuilder<TContext>().UseSqlite(Connection).Options;

        public SqliteConnectionProvider() => Connection = CreateTemporaryDatabase();

        private static DbConnection CreateTemporaryDatabase()
        {
            var tempDb = Path.GetTempFileName();
            var connection = new SqliteConnection($"Filename={tempDb}");
            connection.Open();
            return connection;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Connection?.Dispose();
            }
        }
    }
}