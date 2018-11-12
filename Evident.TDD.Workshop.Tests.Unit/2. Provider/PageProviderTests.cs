using Evident.TDD.Workshop.Provider;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Evident.TDD.Workshop.Tests.Unit.Provider
{
    public class PageProviderTests
    {
        public ILogger<PageProvider> MockedLogger { get; set; }

        //
        // Create class wide mocks here in the constructor
        //
        public PageProviderTests()
        {
            // Create a mocked logger to be used in the PageProvider
            MockedLogger = Mock.Of<ILogger<PageProvider>>();
        }

        //
        // EXAMPLE: This test verifies that a null value for a User is not allowed.
        //
        [Fact]
        public void ShouldThrowNullArgumentExceptionWhenUserIsNull()
        {
            var mockedRepo = new Mock<IPageRepository>();
            var provider = new PageProvider(MockedLogger, mockedRepo.Object);

            var result = false;

            try
            {
                var added = provider.AddPage(
                    null,
                    new Page
                    {
                        Id = Guid.NewGuid(),
                        Title = "TDDWorkshop",
                        Content = "Lorem ipsum"
                    });
            }
            catch(Exception ex)
            {
                if (ex is ArgumentNullException)
                {
                    result = true;
                }
            }

            Assert.True(result);
        }

        //
        // EXCERCISE: Complete this test so that it checks that a page is added
        // QUESTION:  How can you mock the IPageRepository so that it's AddPage method returns true?
        //
        [Fact]
        public void ShouldAddPage()
        {
            var mockedRepo = new Mock<IPageRepository>();
            // HINT: Complete the mocking of the repository here

            var provider = new PageProvider(MockedLogger, mockedRepo.Object);
            var result = false;

            // HINT: Make sure you mock the User with the correct rights
            //       and then call the AddPage method here

            Assert.True(result);
        }

        //
        // QUESTION: How would you mock/test the GetPageById method ?
        //

    }
}
