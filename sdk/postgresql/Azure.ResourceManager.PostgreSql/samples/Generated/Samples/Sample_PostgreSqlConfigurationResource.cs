// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.PostgreSql.Samples
{
    public partial class Sample_PostgreSqlConfigurationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ConfigurationGet()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ConfigurationGet.json
            // this example is just showing the usage of "Configurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlConfigurationResource created on azure
            // for more information of creating PostgreSqlConfigurationResource, please refer to the document of PostgreSqlConfigurationResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string configurationName = "array_nulls";
            ResourceIdentifier postgreSqlConfigurationResourceId = PostgreSqlConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, configurationName);
            PostgreSqlConfigurationResource postgreSqlConfiguration = client.GetPostgreSqlConfigurationResource(postgreSqlConfigurationResourceId);

            // invoke the operation
            PostgreSqlConfigurationResource result = await postgreSqlConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ConfigurationCreateOrUpdate()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ConfigurationCreateOrUpdate.json
            // this example is just showing the usage of "Configurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlConfigurationResource created on azure
            // for more information of creating PostgreSqlConfigurationResource, please refer to the document of PostgreSqlConfigurationResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string configurationName = "array_nulls";
            ResourceIdentifier postgreSqlConfigurationResourceId = PostgreSqlConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, configurationName);
            PostgreSqlConfigurationResource postgreSqlConfiguration = client.GetPostgreSqlConfigurationResource(postgreSqlConfigurationResourceId);

            // invoke the operation
            PostgreSqlConfigurationData data = new PostgreSqlConfigurationData
            {
                Value = "off",
                Source = "user-override",
            };
            ArmOperation<PostgreSqlConfigurationResource> lro = await postgreSqlConfiguration.UpdateAsync(WaitUntil.Completed, data);
            PostgreSqlConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
