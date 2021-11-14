﻿// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace BlockHartNftWebsite.Helpers
{
	public static class LoggingEvents
	{
		public static readonly EventId INIT_DATABASE = new EventId(101, "Error whilst creating and seeding database");
		public static readonly EventId SEND_EMAIL = new EventId(201, "Error whilst sending email");
	}

}
