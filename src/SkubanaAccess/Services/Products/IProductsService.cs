﻿using SkubanaAccess.Models;
using SkubanaAccess.Shared;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SkubanaAccess.Services.Products
{
	public interface IProductsService : IDisposable
	{
		Task< IEnumerable< Product > > GetProductsBySkus( IEnumerable< string > skus, CancellationToken token, Mark mark = null );
	}
}