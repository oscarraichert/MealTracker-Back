﻿namespace Commands.Infra
{
    public class DatabaseSettings
    {
        public required string ConnectionString { get; set; }

        public required string DatabaseName { get; set; }

        public required string CollectionName { get; set; }
    }
}
