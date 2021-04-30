﻿// Copyright 2014 The Noda Time Authors. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.
using NUnit.Framework;

namespace NodaTime.Test
{
    public class TimeAdjustersTest
    {

        [Test]
        public void TruncateToMicrosecond()
        {
            var start = LocalTime.FromHourMinuteSecondMillisecondTick(7, 4, 30, 123, 4567);
            var end = LocalTime.FromHourMinuteSecondMillisecondTick(7, 4, 30, 123, 4560);
            Assert.AreEqual(end, TimeAdjusters.TruncateToMicroseconds(start));
        }

        [Test]
        public void TruncateToMillisecond()
        {
            var start = LocalTime.FromHourMinuteSecondMillisecondTick(7, 4, 30, 123, 4567);
            var end = LocalTime.FromHourMinuteSecondMillisecondTick(7, 4, 30, 123, 0);
            Assert.AreEqual(end, TimeAdjusters.TruncateToMilliSeconds(start));
        }

        [Test]
        public void TruncateToSecond()
        {
            var start = LocalTime.FromHourMinuteSecondMillisecondTick(7, 4, 30, 123, 4567);
            var end = new LocalTime(7, 4, 30);
            Assert.AreEqual(end, TimeAdjusters.TruncateToSecond(start));
        }

        [Test]
        public void TruncateToMinute()
        {
            var start = LocalTime.FromHourMinuteSecondMillisecondTick(7, 4, 30, 123, 4567);
            var end = new LocalTime(7, 4, 0);
            Assert.AreEqual(end, TimeAdjusters.TruncateToMinute(start));
        }

        [Test]
        public void TruncateToHour()
        {
            var start = LocalTime.FromHourMinuteSecondMillisecondTick(7, 4, 30, 123, 4567);
            var end = new LocalTime(7, 0, 0);
            Assert.AreEqual(end, TimeAdjusters.TruncateToHour(start));
        }
    }
}
