using ApiAiNetCore;
using ApiAiNetCore.Exceptions;
using ApiAiNetCore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ApiAiNetCoreTest
{
    [TestClass]
    public class MainTests
    {
        private const string
            ClientAccessToken = "c0f6766c12b943e9bd1d04da4c0c3cd8",
            DeveloperAccessToken = "158904facaa144cea152c362bdeeb5af",
            ExampleEntityId = "be2e9d01-6eaa-4146-973a-1850565fb5d3";

        [TestMethod]
        public void QueryTest()
        {
            try
            {
                var result = QueryService.SendRequest(new ConfigModel { AccesTokenClient = ClientAccessToken }, "some text");
                Assert.IsFalse(string.IsNullOrEmpty(result.SessionId));

            }
            catch (ApiAiException ex)
            {
                // Use debug to check this "ex" value
                Assert.Fail();
            }
        }

        [TestMethod]
        public void EntitiesListTest()
        {
            try
            {
                var result = EntityService.GetEntities(new ConfigModel { AccesTokenDeveloper = DeveloperAccessToken });
                Assert.IsTrue(result.Any()); // fail you haven't any entities in the agent, it's ok (;
            }
            catch (ApiAiException ex)
            {
                // Use debug to check this "ex" value
                Assert.Fail();
            }
        }

        [TestMethod]
        public void EntriesListTest()
        {
            try
            {
                var result = EntityService.GetEntries(new ConfigModel { AccesTokenDeveloper = DeveloperAccessToken }, ExampleEntityId);
                Assert.IsTrue(result.Entries.Any());
            }
            catch (ApiAiException ex)
            {
                // Use debug to check this "ex" value
                Assert.Fail();
            }
        }

        [TestMethod]
        public void EntityCreateTest()
        {
            try
            {
                var NewEntityId = EntityService.CreateEntity(new ConfigModel { AccesTokenDeveloper = DeveloperAccessToken }, "test_entity_1", new Dictionary<string, string[]> {
                    { "test1", new[]{ "test 1", "test one" } },
                    { "test2", new[]{ "test 2", "test second" } }
                });
            }
            catch (ApiAiException ex)
            {
                // Use debug to check this "ex" value
                Assert.Fail();
            }
        }

        [TestMethod]
        public void EntityUpdateTest()
        {
            try
            {
                EntityService.UpdateEntity(new ConfigModel { AccesTokenDeveloper = DeveloperAccessToken }, ExampleEntityId, "test_entity_1", new Dictionary<string, string[]> {
                    { "test1", new[]{ "afafafafa" } }
                    //{ "test2", new[]{ "test 2", "test second" } }
                });
            }
            catch (ApiAiException ex)
            {
                // Use debug to check this "ex" value
                Assert.Fail();
            }
        }

        [TestMethod]
        public void EntityDeleteTest()
        {
            try
            {
                EntityService.DeleteEntity(new ConfigModel { AccesTokenDeveloper = DeveloperAccessToken }, ExampleEntityId);
            }
            catch (ApiAiException ex)
            {
                // Use debug to check this "ex" value
                Assert.Fail();
            }
        }

        [TestMethod]
        public void EntriesAddTest()
        {
            try
            {
                EntityService.AddEntries(new ConfigModel { AccesTokenDeveloper = DeveloperAccessToken }, ExampleEntityId, new Dictionary<string, string[]> {
                    { "test3", new[]{ "test 3", "test three" } },
                    { "test4", new[]{ "test 4", "test four" } }
                });
            }
            catch (ApiAiException ex)
            {
                // Use debug to check this "ex" value
                Assert.Fail();
            }
        }

        [TestMethod]
        public void EntriesUpdateTest()
        {
            try
            {
                EntityService.UpdateEntries(new ConfigModel { AccesTokenDeveloper = DeveloperAccessToken }, ExampleEntityId, new Dictionary<string, string[]> {
                    { "test1", new[]{ "test 1", "test one", "test before second" } },
                });
            }
            catch (ApiAiException ex)
            {
                // Use debug to check this "ex" value
                Assert.Fail();
            }
        }

        [TestMethod]
        public void EntriesDeleteTest()
        {
            try
            {
                EntityService.DeleteEntries(new ConfigModel { AccesTokenDeveloper = DeveloperAccessToken }, ExampleEntityId, "test1", "test2");
            }
            catch (ApiAiException ex)
            {
                // Use debug to check this "ex" value
                Assert.Fail();
            }
        }
    }
}
