﻿using SourceControlSync.Domain;

namespace SourceControlSync.DataAWS
{
    public class AWSS3RepositoryFactory : IDestinationRepositoryFactory
    {
        public IDestinationRepository CreateDestinationRepository(string connectionString)
        {
            return new DestinationRepository(
                new DeleteItemCommand(connectionString),
                new UploadItemCommand(connectionString)
                );
        }
    }
}
