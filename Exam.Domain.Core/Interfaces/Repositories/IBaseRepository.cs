
using System;
using System.Collections.Generic;
namespace Exam.Domain.Core.Interfaces.Repositories
{
    public interface IBaseRepository<T> : IDisposable
    {
        IEnumerable<T> GetAll();

        /// <summary>
        /// Gets an entity item by id
        /// </summary>
        /// <param name="id">The id of the entity to get</param>
        T GetById(params object[] id);

        /// <summary>
        /// Add an entity item
        /// </summary>
        /// <param name="entityItem">The entity item to add</param>
        T Add(T Item);

        /// <summary>
        /// Delete entity item
        /// </summary>
        /// <param name="id">The id of the entity item to delete</param>
        void DeleteById(int id);

        /// <summary>
        /// Update an existing entity item
        /// </summary>
        /// <param name="entitytItem">The entity item to update</param>
        void UpdateById(T Item);

        /// <summary>
        /// Save all changes in this context
        /// </summary>
        bool Save();
    }
}
