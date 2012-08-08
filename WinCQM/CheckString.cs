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
        /// �ж��Ƿ����ִ�����ת��
        /// </summary>
        /// <param name="inputData">�����ַ���</param>
        /// <param name="result">ת�������ν��</param>
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
        /// �Ƿ������ַ���
        /// </summary>
        /// <param name="inputData">�����ַ���</param>
        /// <returns></returns>
        public static bool IsNumber(string inputData)
        {
            Match m = RegNumber.Match(inputData);
            return m.Success;
        }
    }
}
