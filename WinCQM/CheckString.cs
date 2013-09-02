using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WinCQM
{
    public abstract class CheckString
    {
        private static Regex RegNumber = new Regex(@"^[+-]?\d+$");

        /// <summary>
        /// 判断是否数字串，并转换
        /// </summary>
        /// <param name="inputData">输入字符串</param>
        /// <param name="result">转换的整形结果</param>
        /// <returns></returns>
        public static bool IsNumber(string inputData,out int result)
        {
            result = 0;
            if (RegNumber.IsMatch(inputData))
            {
                result = int.Parse(inputData);
                return true;
            }
            return false;
        }

        /// <summary>
        /// 是否数字字符串
        /// </summary>
        /// <param name="inputData">输入字符串</param>
        /// <returns></returns>
        public static bool IsNumber(string inputData)
        {
            Match m = RegNumber.Match(inputData);
            return m.Success;
        }
    }
}
