﻿using SDDev.Net.GenericRepository.Contracts.BaseEntity;

namespace SDDev.Net.GenericRepository.Tests.TestModels
{
    public class BaseTestObject : BaseStorableEntity
    {
        public string Name { get; set; }

        public string Prop1 { get; set; } = "Primary";
    }
}
