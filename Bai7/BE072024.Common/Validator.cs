using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.Common
{
    public class Validator
    {
        public static bool ValidateInt(string input, out int result, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                result = 0;
                errorMessage = "Giá trị không được để trống.";
                return false;
            }

            if (!int.TryParse(input, out result))
            {
                errorMessage = "Giá trị không phải là số nguyên hợp lệ.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        public static bool ValidateString(string input, out string result, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                result = null;
                errorMessage = "Giá trị không được để trống.";
                return false;
            }

            result = input;
            errorMessage = null;
            return true;
        }

        public static bool ValidateString(string input, out string errorMessage)
        {
            if (string.IsNullOrEmpty(input))
            {
                errorMessage = "Giá trị không được để trống.";
                return true;
            }
            errorMessage = null;
            return false;
        }

        public static bool ValidateDateTime(string input, out DateTime result, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                result = default(DateTime);
                errorMessage = "Giá trị không được để trống.";
                return false;
            }

            if (!DateTime.TryParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                errorMessage = "Giá trị không phải là ngày hợp lệ (định dạng dd-MM-yyyy).";
                return false;
            }

            errorMessage = null;
            return true;
        }

        public static bool ValidateDouble(string input, out double result, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                result = 0;
                errorMessage = "Giá trị không được để trống.";
                return false;
            }

            if (!double.TryParse(input, out result))
            {
                errorMessage = "Giá trị không phải là số thực hợp lệ.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        public static bool ValidateDouble(string input, out double result, out string errorMessage, bool checkPositive = false)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                result = 0;
                errorMessage = "Giá trị không được để trống.";
                return false;
            }

            if (!double.TryParse(input, out result) || (checkPositive && result <= 0))
            {
                errorMessage = checkPositive ? "Giá trị phải là số thực dương hợp lệ." : "Giá trị không phải là số thực hợp lệ.";
                return false;
            }

            errorMessage = null;
            return true;
        }
    } 
}
