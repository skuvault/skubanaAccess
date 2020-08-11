﻿using System.Collections.Generic;
using CuttingEdge.Conditions;
using SkubanaAccess.Configuration;

namespace SkubanaAccess.Models.Commands
{
    public class GetVendorsCommand : SkubanaCommand
    {
	    public GetVendorsCommand( SkubanaConfig config, int page, int limit ) : base( config, SkubanaEndpoint.GetAllVendorsUrl )
	    {
		    Condition.Requires( page, "page" ).IsGreaterOrEqual( 1 );
		    Condition.Requires( limit, "limit" ).IsGreaterOrEqual( 1 );

		    this.RequestParameters = new Dictionary< string, string >()
		    {
			    { "page", page.ToString() },
			    { "limit", limit.ToString() }
		    };
	    }
    }
}
