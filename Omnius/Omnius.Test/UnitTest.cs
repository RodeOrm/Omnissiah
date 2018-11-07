using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omnius.UI.Models;

namespace Omnius.Test
{
    [TestClass]
    public class PageViewModelTest
    {
        private PageViewModel _pageViewModel;

        [TestMethod]
        public void HasPreviousPage()
        {
            // Arrange 
            _pageViewModel = new PageViewModel(100,1,7,null);

            // Act
            var result = _pageViewModel.HasPreviousPage;

            //Assert
            Assert.IsFalse(result, "Не работает проверка наличия предыдущей страницы");
        }

        [TestMethod]
        public void HasNextPage()
        {
            // Arrange 
            _pageViewModel = new PageViewModel(100, 1, 7, null);

            // Act
            var result = _pageViewModel.HasNextPage;

            //Assert
            Assert.IsTrue(result, "Не работает проверка наличия следующей страницы");
        }
    }
}