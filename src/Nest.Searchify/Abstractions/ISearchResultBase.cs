﻿namespace Nest.Searchify.Abstractions
{
	public interface ISearchResultBase<out TParameters> 
        where TParameters : IParameters
	{
		IPaginationOptions<TParameters> Pagination { get; }
		TParameters Parameters { get; }
		int TimeTaken { get; }

	}
}