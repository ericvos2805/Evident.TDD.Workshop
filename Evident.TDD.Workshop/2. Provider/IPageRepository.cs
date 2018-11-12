using System;    

namespace Evident.TDD.Workshop.Provider
{
    public interface IPageRepository
    {
        /// <summary>
        /// Adds the page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns>True if page was successfully added, otherwise returns False</returns>
        bool AddPage(Page page);

        /// <summary>
        /// Gets an page by id.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns>True if page was successfully added, otherwise returns False</returns>
        Page GetPageById(Guid id);

        /// <summary>
        /// Deletes the page.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <returns>True if page was successfully deleted, otherwise returns False</returns>
        bool DeletePage(Page page);
    }
}