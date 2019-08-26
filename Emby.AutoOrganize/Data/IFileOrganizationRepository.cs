﻿using MediaBrowser.Model.Querying;
using System.Threading;
using System.Threading.Tasks;
using Emby.AutoOrganizeMD.Model;

namespace Emby.AutoOrganizeMD.Data
{
    public interface IFileOrganizationRepository
    {
        /// <summary>
        /// Saves the result.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        void SaveResult(FileOrganizationResult result, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task.</returns>
        void Delete(string id);

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>FileOrganizationResult.</returns>
        FileOrganizationResult GetResult(string id);

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>IEnumerable{FileOrganizationResult}.</returns>
        QueryResult<FileOrganizationResult> GetResults(FileOrganizationResultQuery query);

        /// <summary>
        /// Deletes all.
        /// </summary>
        /// <returns>Task.</returns>
        void DeleteAll();

        /// <summary>
        /// Deletes all.
        /// </summary>
        /// <returns>Task.</returns>
        void DeleteCompleted();

        void SaveResult(SmartMatchResult result, CancellationToken cancellationToken);

        void DeleteSmartMatch(string id);

        void DeleteSmartMatch(string id, string matchString);

        void DeleteAllSmartMatch();

        QueryResult<SmartMatchResult> GetSmartMatch(FileOrganizationResultQuery query);
    }
}
