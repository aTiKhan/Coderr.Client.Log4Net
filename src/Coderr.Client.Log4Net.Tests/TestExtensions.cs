﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coderr.Client.Contracts;

namespace Coderr.Client.Log4Net.Tests
{
    public static class TestExtensions
    {
        public static string GetCollectionProperty(this ErrorReportDTO report, string collectionName,
            string propertyName)
        {
            var collection = report.ContextCollections.First(x => x.Name == collectionName);
            return collection.Properties[propertyName];
        }
    }
}
