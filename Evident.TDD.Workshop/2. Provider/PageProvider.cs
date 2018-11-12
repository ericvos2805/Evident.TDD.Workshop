using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evident.TDD.Workshop.Provider
{
    /// <summary>
    /// A provider to add, delete and retrieve pages.
    /// It makes sure that only authorized users can perform the appropriate actions.
    /// </summary>
    public class PageProvider
    {
        private ILogger<PageProvider> Logger { get; set; }
        private IPageRepository PageRepository { get; set; }


        public PageProvider(ILogger<PageProvider> logger, IPageRepository pageRepository)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            PageRepository = pageRepository ?? throw new ArgumentNullException(nameof(pageRepository));
        }

        /// <summary>
        /// Adds the page.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">
        /// user
        /// or
        /// page
        /// </exception>
        /// <exception cref="System.UnauthorizedAccessException">Only admin users can add new pages</exception>
        public bool AddPage(User user, Page page)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            if (page == null)
            {
                throw new ArgumentNullException(nameof(page));
            }

            if (!user.IsAdmin)
            {
                throw new UnauthorizedAccessException("Only admin users can add new pages");
            }

            return PageRepository.AddPage(page);
        }

        /// <summary>
        /// Deletes the page.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">
        /// user
        /// or
        /// page
        /// </exception>
        /// <exception cref="System.UnauthorizedAccessException">Only admin users can delete pages</exception>
        public bool DeletePage(User user, Page page)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            if (page == null)
            {
                throw new ArgumentNullException(nameof(page));
            }

            if (!user.IsAdmin)
            {
                throw new UnauthorizedAccessException("Only admin users can delete pages");
            }

            return PageRepository.DeletePage(page);
        }

        /// <summary>
        /// Gets the page by identifier.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">user</exception>
        public Page GetPageById(User user, Guid id)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return PageRepository.GetPageById(id);
        }
    }
}
