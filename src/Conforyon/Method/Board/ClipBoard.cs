﻿#region Imports

using System.Windows.Forms;
using static Conforyon.Conforyon;

#endregion

namespace Conforyon
{
    public static class ClipBoard
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Copy"></param>
        public static void CopyText(string Text, bool Copy = true)
        {
            try
            {
                Clipboard.SetDataObject(Text, Copy);
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        public static void CopyAudio(byte[] Bytes)
        {
            try
            {
                Clipboard.SetAudio(Bytes);
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        /// <param name="Back"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static string GetText(bool Clear = false, string Back = EmptyMessage, string Error = ErrorMessage)
        {
            try
            {
                IDataObject IData = Clipboard.GetDataObject();

                if (Clear)
                    Clipboard.Clear();

                if (IData.GetDataPresent(DataFormats.Text))
                    return (string)IData.GetData(DataFormats.Text);
                else
                    return Back;
            }
            catch
            {
                return Error + ErrorTitle + "CB-PT1!)";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        public static void GetAudio(bool Clear = false)
        {
            try
            {
                Clipboard.GetAudioStream();

                if (Clear)
                    Clipboard.Clear();
            }
            catch
            {
                return;
            }
        }
    }
}