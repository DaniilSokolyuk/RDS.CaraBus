﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using RDS.CaraBus.Tests.Unit;

namespace RDS.CaraBus.InMemory.Tests.Unit
{
    [TestFixture]
    public class CaraBusTests : CaraBusUnitTestsSpec
    {
        protected override ICaraBus CreateCaraBus()
        {
            return new CaraBus();
        }
    }
}
