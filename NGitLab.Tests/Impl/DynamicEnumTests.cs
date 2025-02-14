﻿using NUnit.Framework;

namespace NGitLab.Tests.Impl
{
    public class DynamicEnumTests
    {
        [Test]
        public void Test_comparison()
        {
            Assert.AreEqual(new DynamicEnum<MockEnum>(MockEnum.A), MockEnum.A);
            Assert.AreNotEqual(new DynamicEnum<MockEnum>(MockEnum.A), MockEnum.B);
            Assert.AreEqual(new DynamicEnum<MockEnum>("unknown").StringValue, "unknown");
            Assert.AreNotEqual(new DynamicEnum<MockEnum>("unknown").StringValue, "other");
        }

        public enum MockEnum
        {
            A,
            B,
        }
    }
}
