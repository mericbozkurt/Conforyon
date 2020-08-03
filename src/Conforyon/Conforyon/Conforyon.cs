﻿#region Imports

using System;
using System.Text.RegularExpressions;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Site   : www.Taiizor.com
//     Created: 04.Jul.2019
//     Changed: 04.Aug.2020
//     Version: 1.4.5.9
//
// |---------DO-NOT-REMOVE---------|

namespace Conforyon
{
    public static class Conforyon
    {
        #region Variables
        /// <summary>
        /// 
        /// </summary>
        public const string ErrorTitle = " (CN-LY";

        /// <summary>
        /// 
        /// </summary>
        public const string ErrorMessage = "Error!";

        /// <summary>
        /// 
        /// </summary>
        public const int VariableLength = 15;
        #endregion

        #region Enums
        public enum StorageType
        {
            Bit,
            Byte,
            KB,
            MB,
            GB,
            TB,
            PB,
            EB,
            ZB,
            YB
        }
        #endregion

        #region Arrays
        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] StorageTypes = {
            "Bit",
            "Byte",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB",
            "EB",
            "ZB",
            "YB"
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SymbolsMath = {
            "-",
            "+"
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SymbolsCalc = {
            "E",
            "B",
            "+",
            "-"
        };
        #endregion

        #region Cores
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <returns></returns>
        public static bool NumberCheck(string Variable, bool Mod = false, bool Mod2 = false)
        {
            try
            {
                if (Regex.IsMatch(Variable, "[^0-9]"))
                    return false;
                else
                {
                    if (Mod2 == false)
                    {
                        if (Mod == false)
                        {
                            Convert.ToInt64(Variable);
                            return true;
                        }
                        else
                        {
                            Convert.ToInt32(Variable);
                            return true;
                        }
                    }
                    else
                        return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable1"></param>
        /// <param name="Variable2"></param>
        /// <param name="Mod"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string Arama(string Variable1, string[] Variable2, int Mod = 1, string Error = ErrorMessage)
        {
            try
            {
                if (Mod >= 1 && Mod <= 3)
                {
                    string Status = "N";
                    if (Mod == 1)
                    {
                        if (Variable2.Length > 1)
                        {
                            foreach (string Letter in Variable2)
                            {
                                if (Variable1.Contains(Letter))
                                {
                                    Status = "Y";
                                    break;
                                }
                            }
                        }
                        else if (Variable1.Contains(Variable2[0]))
                            Status = "Y";
                    }
                    else if (Mod == 2)
                    {
                        if (Variable2.Length > 1)
                        {
                            foreach (string Letter in Variable2)
                            {
                                if (Variable1.StartsWith(Letter))
                                {
                                    Status = "Y";
                                    break;
                                }
                            }
                        }
                        else if (Variable1.StartsWith(Variable2[0]))
                            Status = "Y";
                    }
                    else if (Mod == 3)
                    {
                        if (Variable2.Length > 1)
                        {
                            foreach (string Letter in Variable2)
                            {
                                if (Variable1.EndsWith(Letter))
                                {
                                    Status = "Y";
                                    break;
                                }
                            }
                        }
                        else if (Variable1.EndsWith(Variable2[0]))
                            Status = "Y";
                    }
                    if (Status == "N")
                        return "N";
                    else
                        return "Y";
                }
                else
                    return Error;
            }
            catch
            {
                return Error + ErrorTitle + "1A2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InputVariable"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Comma"></param>
        /// <param name="Error"></param>
        /// <param name="Mod"></param>
        /// <param name="Mod2"></param>
        /// <returns></returns>
        public static string VariableFormat(string InputVariable, string Coefficient, bool Comma, string Error = ErrorMessage, bool Mod = false, bool Mod2 = false)
        {
            try
            {
                if (Mod == false)
                {
                    if (NumberCheck(Coefficient.ToString()) == true)
                    {
                        string Variable1, Variable2, Variable3;
                        if (Comma == true)
                        {
                            if (Mod2 == false)
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) * Convert.ToInt64(Coefficient)).ToString();
                            }
                            else
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) / Convert.ToInt64(Coefficient)).ToString();
                            }
                            if (Arama(Variable2, SymbolsCalc, 1, Error) == "Y")
                            {
                                if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            else
                                Variable1 = Variable2;
                        }
                        else
                        {
                            if (Mod2 == false)
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) * Convert.ToInt64(Coefficient)).ToString();
                            }
                            else
                            {
                                Variable2 = (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                                Variable3 = (Convert.ToInt64(InputVariable) / Convert.ToInt64(Coefficient)).ToString();
                            }
                            if (Arama(Variable2, SymbolsCalc, 1, Error) == "Y")
                            {
                                if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            }
                            else if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                if (Arama(Variable3, SymbolsMath, 2, Error) == "Y")
                                    Variable1 = Variable2;
                                else
                                    Variable1 = Variable3;
                            else
                                Variable1 = Variable3;
                        }
                        if (string.IsNullOrEmpty(Variable1))
                            return Error;
                        else
                            return Variable1;
                    }
                    else
                        return Error;
                }
                else
                {
                    if (Mod2 == false)
                        return (Convert.ToInt64(InputVariable) * Convert.ToDouble(Coefficient)).ToString();
                    else
                        return (Convert.ToInt64(InputVariable) / Convert.ToDouble(Coefficient)).ToString();
                }
            }
            catch
            {
                return Error + ErrorTitle + "1V2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <returns></returns>
        public static string Decimal(string Variable)
        {
            try
            {
                if (Variable.Contains("E") || Variable.Contains("B") || Variable.Contains("+") || Variable.Contains("-"))
                    return Variable;
                else
                {
                    if (Variable.Contains(","))
                    {
                        char[] Ayraçlar = { ',', '.' };
                        string[] Variableler = Variable.Split(Ayraçlar);
                        string Sonuç = string.Format("{0:0,0}", Convert.ToInt64(Variableler[0]));
                        if (Sonuç.Length == 2 && Sonuç == "00")
                            Sonuç = "0";
                        else if (Sonuç.Length == 2 && Sonuç.StartsWith("0") && !Sonuç.EndsWith("0"))
                            Sonuç.Replace("0", "");
                        return Sonuç + "," + Variableler[1];
                    }
                    else
                    {
                        if (Variable.Length > 2)
                        {
                            if (NumberCheck(Variable) == true)
                                return string.Format("{0:0,0}", Convert.ToInt64(Variable));
                            else
                                return string.Format("{0:0,0}", Variable);
                        }
                        else
                            return Variable;
                    }
                }
            }
            catch (Exception Error)
            {
                return Error + ErrorTitle + "1O2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <returns></returns>
        public static string Decimal2(string Variable)
        {
            try
            {
                if (Variable.Contains("E") || Variable.Contains("B") || Variable.Contains("+") || Variable.Contains("-"))
                    return Variable;
                else
                {
                    if (Variable.Contains(","))
                    {
                        char[] Ayraçlar = { ',' };
                        string[] Variableler = Variable.Split(Ayraçlar);
                        string Sonuç = string.Format("{0:0,0}", Convert.ToInt64(Variableler[0]));
                        if (Sonuç.Length == 2 && Sonuç == "00")
                            return "0";
                        else if (Sonuç.Length == 2 && Sonuç.StartsWith("0") && !Sonuç.EndsWith("0"))
                            return Sonuç.Replace("0", "");
                        else
                            return Sonuç;
                    }
                    else
                    {
                        if (Variable.Length > 2)
                        {
                            if (NumberCheck(Variable) == true)
                                return string.Format("{0:0,0}", Convert.ToInt64(Variable));
                            else
                                return string.Format("{0:0,0}", Variable);
                        }
                        else
                            return Variable;
                    }
                }
            }
            catch (Exception Error)
            {
                return Error + ErrorTitle + "1O3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <returns></returns>
        public static string Comma(string Variable, int PostComma = 0)
        {
            try
            {
                if (Variable.Contains("E") || Variable.Contains("B") || Variable.Contains("+") || Variable.Contains("-"))
                    return Variable;
                else
                {
                    if (Variable.Contains(",") && PostComma != 0)
                    {
                        char[] Ayraçlar = { ',' };
                        string[] Variableler = Variable.Split(Ayraçlar);
                        if (PostComma <= Variableler[1].Length)
                            return Variableler[0] + "," + Variableler[1].Substring(0, PostComma);
                        else
                        {
                            string Işlem = Variableler[0] + "," + Variableler[1].Substring(0, Variableler[1].Length);
                            int Işlem2 = PostComma - Variableler[1].Length;
                            for (int i = 0; i < Işlem2; i++)
                                Işlem += "0";
                            return Işlem;
                        }
                    }
                    else
                    {
                        if (PostComma == 0)
                        {
                            char[] Ayraçlar = { ',' };
                            string[] Variableler = Variable.Split(Ayraçlar);
                            return Variableler[0];
                        }
                        else
                        {
                            string Işlem = ",";
                            for (int i = 0; i < PostComma; i++)
                                Işlem += "0";
                            return Variable + Işlem;
                        }
                    }
                }
            }
            catch (Exception Error)
            {
                return Error + ErrorTitle + "1V3!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <returns></returns>
        public static string Comma2(string Variable, int PostComma = 0)
        {
            try
            {
                if (Variable.Contains("E") || Variable.Contains("B") || Variable.Contains("+") || Variable.Contains("-"))
                    return Variable;
                else
                {
                    if (PostComma <= Variable.Length)
                        if (Variable == ",")
                            return Variable.Substring(0, PostComma) + "0";
                        else
                            return Variable.Substring(0, PostComma);
                    else
                    {
                        string Işlem = Variable.Substring(0, Variable.Length);
                        int Işlem2 = PostComma - Variable.Length;
                        if (Variable == ",")
                        {
                            for (int i = 0; i <= Işlem2; i++)
                                Işlem += "0";
                        }
                        else
                        {
                            for (int i = 0; i < Işlem2; i++)
                                Işlem += "0";
                        }
                        return Işlem;
                    }
                }
            }
            catch (Exception Error)
            {
                return Error + ErrorTitle + "1v4!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="PostComma"></param>
        /// <returns></returns>
        public static string DecimalComma(string Variable, int PostComma = 0)
        {
            try
            {
                if (Variable.Contains("E") || Variable.Contains("B") || Variable.Contains("+") || Variable.Contains("-"))
                    return Variable;
                else
                {
                    if (PostComma == 0)
                        return Decimal2(Variable);
                    else
                    {
                        if (Variable.Contains(","))
                        {
                            char[] Ayraçlar = { ',' };
                            string[] Variableler = Variable.Split(Ayraçlar);
                            return Decimal2(Variableler[0]) + "," + Comma2(Variableler[1], PostComma);
                        }
                        else
                            return Decimal2(Variable) + Comma2(",", PostComma);
                    }
                }
            }
            catch (Exception Error)
            {
                return Error + ErrorTitle + "1O4!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string LastCheck(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Decimal == false && Comma == false)
                {
                    if (string.IsNullOrEmpty(Variable))
                        return Error;
                    else
                        return Variable;
                }
                else
                {
                    if (Decimal == true && Comma == false)
                        return Conforyon.Decimal(Variable);
                    else if (Decimal == false && Comma == true)
                        return Conforyon.Comma(Variable, PostComma);
                    else
                        return DecimalComma(Variable, PostComma);
                }
            }
            catch
            {
                return Error + ErrorTitle + "1S!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Decimal"></param>
        /// <param name="Comma"></param>
        /// <param name="PostComma"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string LastCheck2(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage)
        {
            try
            {
                if (Decimal == false && Comma == false)
                {
                    if (string.IsNullOrEmpty(Variable))
                        return Error;
                    else
                        return LastCheck(Variable, false, true, 0, Error);
                }
                else
                {
                    if (Decimal == true && Comma == false)
                        return LastCheck(Variable, true, true, 0, Error);
                    else if (Decimal == false && Comma == true)
                        return LastCheck(Variable, false, true, PostComma, Error);
                    else
                        return DecimalComma(Variable, PostComma);
                }
            }
            catch
            {
                return Error + ErrorTitle + "1S2!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Variable"></param>
        /// <param name="Mod"></param>
        /// <returns></returns>
        public static bool Check(string Variable, bool Mod = false)
        {
            try
            {
                if (Mod == false)
                {
                    if (Variable != "" && !string.IsNullOrEmpty(Variable) && !string.IsNullOrWhiteSpace(Variable) && !Variable.Contains(" "))
                        return true;
                    else
                        return false;
                }
                else
                {
                    if (Variable != "" && !string.IsNullOrEmpty(Variable) && !string.IsNullOrWhiteSpace(Variable))
                        return true;
                    else
                        return false;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}