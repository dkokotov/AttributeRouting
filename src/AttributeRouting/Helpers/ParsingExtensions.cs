﻿using System;

namespace AttributeRouting.Helpers
{
    public static class ParsingExtensions
    {
        public static T? Parse<T>(this object obj)
            where T : struct
        {
            var typeOfT = typeof(T);
            if (typeOfT == typeof(int)) return obj.ParseInt() as T?;
            if (typeOfT == typeof(long)) return obj.ParseLong() as T?;
            if (typeOfT == typeof(float)) return obj.ParseFloat() as T?;
            if (typeOfT == typeof(double)) return obj.ParseDouble() as T?;
            if (typeOfT == typeof(decimal)) return obj.ParseDecimal() as T?;
            if (typeOfT == typeof(bool)) return obj.ParseBool() as T?;
            if (typeOfT == typeof(Guid)) return obj.ParseGuid() as T?;
            if (typeOfT == typeof(DateTime)) return obj.ParseDateTime() as T?;

            return null;
        }

        public static int? ParseInt(this object obj)
        {
            if (obj == null) return null;
            if (obj is int) return (int)obj;
            
            int result;
            if (int.TryParse(obj.ToString(), out result))
                return result;

            return null;
        }

        public static long? ParseLong(this object obj)
        {
            if (obj == null) return null;
            if (obj is long) return (long)obj;
            
            long result;
            if (long.TryParse(obj.ToString(), out result))
                return result;

            return null;
        }

        public static float? ParseFloat(this object obj)
        {
            if (obj == null) return null;
            if (obj is float) return (float)obj;
            
            float result;
            if (float.TryParse(obj.ToString(), out result))
                return result;

            return null;
        }

        public static double? ParseDouble(this object obj)
        {
            if (obj == null) return null;
            if (obj is double) return (double)obj;
            
            double result;
            if (double.TryParse(obj.ToString(), out result))
                return result;

            return null;
        }

        public static decimal? ParseDecimal(this object obj)
        {
            if (obj == null) return null;
            if (obj is decimal) return (decimal)obj;
            
            decimal result;
            if (decimal.TryParse(obj.ToString(), out result))
                return result;

            return null;
        }

        public static bool? ParseBool(this object obj)
        {
            if (obj == null) return null;
            if (obj is bool) return (bool)obj;
            
            bool result;
            if (bool.TryParse(obj.ToString(), out result))
                return result;

            return null;
        }

        public static Guid? ParseGuid(this object obj)
        {
            if (obj == null) return null;
            if (obj is Guid) return (Guid)obj;
            
            Guid result;
            if (Guid.TryParse(obj.ToString(), out result))
                return result;

            return null;
        }

        public static DateTime? ParseDateTime(this object obj)
        {
            if (obj == null) return null;
            if (obj is DateTime) return (DateTime)obj;
            
            DateTime result;
            if (DateTime.TryParse(obj.ToString(), out result))
                return result;

            return null;
        }
    }
}
