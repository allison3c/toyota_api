﻿using Microsoft.Extensions.Configuration;

namespace TOYOTA.API.Context
{
    public class DapperContext
    {
        private DapperContext() { }
        private static DapperContext current;
        public static DapperContext Current
        {
            get
            {
                if (current == null)
                {
                    current = new DapperContext();
                }
                return current;
            }
        }
        public IConfigurationRoot Configuration { get; set; }
        public string SqlConnection
        {
            get
            {
                return Configuration["Data:TOYOTAConnection:ConnectionString"];
            }
        }
    }
}
