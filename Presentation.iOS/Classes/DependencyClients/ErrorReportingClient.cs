﻿using System;
using Common.Dependencies.Error;

namespace Presentation.iOS.Classes.DependencyClients
{
	public class ErrorReportingClient : IErrorReportingDependency
	{
		public ErrorReportingClient ()
		{
		}

		#region IErrorReportingDependency implementation

		public void ReportError (Exception ex)
		{
			//throw new NotImplementedException ();
		}

		#endregion
	}
}

