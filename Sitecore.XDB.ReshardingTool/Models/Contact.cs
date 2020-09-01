﻿using System;
using System.Data.SqlTypes;
using Sitecore.XDB.ReshardingTool.Models;
using Sitecore.XDB.ReshardingTool.Utilities;

namespace Sitecore.XDB.ReshardingTool.Models
{
    public class Contact : IEntity
    {
        public Guid ContactId { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime Created { get; set; }
        public Guid ConcurrencyToken { get; set; }
        public byte[] GetKey()
        {
            return PartitionKeyGenerator.Generate(ContactId);
        }

        public SqlGuid GetOrderFieldValue()
        {
            return new SqlGuid(ContactId);
        }
    }
}