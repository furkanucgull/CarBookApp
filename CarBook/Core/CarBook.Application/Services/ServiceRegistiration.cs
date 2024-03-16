﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Services
{
	public static class ServiceRegistiration
	{
		public static void AddApplicationServices(this IServiceCollection services, IConfiguration configration)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
		}
	}
}
