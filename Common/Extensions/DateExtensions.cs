﻿using System;

namespace Common.Extensions
{
    public static class DateTimeOffsetExtensions
    {
        private const int DaysInWeek = 7;

        public static bool IsUtc(this DateTimeOffset instance)
        {
            return instance.Date.Kind == DateTimeKind.Utc;
        }
        public static bool IsLocalTime(this DateTimeOffset instance)
        {
            return instance.Date.Kind == DateTimeKind.Local;
        }

        public static DateTimeOffset AddWeeks(this DateTimeOffset instance, int weeksToAdd)
        {
            return instance.AddDays(weeksToAdd * DaysInWeek);
        }

        public static bool IsBefore(this DateTimeOffset? instance, DateTimeOffset toCompare)
        {
            return instance.HasValue && instance.Value.IsBefore(toCompare);
        }

        public static bool IsOnOrBefore(this DateTimeOffset? instance, DateTimeOffset toCompare)
        {
            return instance.HasValue && instance.Value.IsOnOrBefore(toCompare);
        }

        public static bool IsBefore(this DateTimeOffset instance, DateTimeOffset toCompare)
        {
            return instance < toCompare;
        }

        public static bool IsOnOrBefore(this DateTimeOffset instance, DateTimeOffset toCompare)
        {
            return instance <= toCompare;
        }

        public static bool IsOnOrAfter(this DateTimeOffset instance, DateTimeOffset toCompare)
        {
            return instance >= toCompare;
        }

        public static bool IsBetween(this DateTimeOffset instance, DateTimeOffset start, DateTimeOffset end)
        {
            return instance.IsOnOrAfter(start) && instance.IsOnOrBefore(end);
        }

        public static bool IsOnOrAfter(this DateTimeOffset? instance, DateTimeOffset toCompare)
        {
            return instance.HasValue && instance.IsOnOrAfter(toCompare);
        }
        public static bool IsAfter(this DateTimeOffset? instance, DateTimeOffset toCompare)
        {
            return instance.HasValue && instance.Value.IsAfter(toCompare);
        }

        public static bool IsAfter(this DateTimeOffset instance, DateTimeOffset toCompare)
        {
            return instance > toCompare;
        }
    }

    public static class DateExtensions
    {
        private const int DaysInWeek = 7;

        public static bool IsLessThan(this DateTime? instance, DateTime toCompare)
        {
            return instance.HasValue && instance.Value.IsLessThan(toCompare);
        }

        public static bool IsLessThan(this DateTime instance, DateTime toCompare)
        {
            return instance < toCompare;
        }

        public static bool IsLessThanOrEqualTo(this DateTime instance, DateTime toCompare)
        {
            return instance <= toCompare;
        }
        public static bool IsGreaterThan(this DateTime? instance, DateTime toCompare)
        {
            return instance.HasValue && instance.Value.IsGreaterThan(toCompare);
        }

        public static bool IsGreaterThan(this DateTime instance, DateTime toCompare)
        {
            return instance > toCompare;
        }

        public static DateTime AddWeeks(this DateTime instance, int weeksToAdd)
        {
            return instance.AddDays(weeksToAdd * DaysInWeek);
        }
    }
}
