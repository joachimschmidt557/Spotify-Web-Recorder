using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace SpotifyWebRecorder.Forms.UI
{
    public class Util
    {
		private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
		private const int WM_APPCOMMAND = 0x319;
		[DllImport( "user32.dll" )]
		public static extern IntPtr SendMessageW( IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam );
		public static void ToggleMuteVolume(IntPtr Handle)	// call from a form and set handle to "this"
		{
			SendMessageW(Handle, WM_APPCOMMAND, Handle, (IntPtr) APPCOMMAND_VOLUME_MUTE);
		}

        public static string GetDefaultOutputPath()
        {
            if (string.IsNullOrEmpty(Settings.Default.OutputPath))
            {
                Settings.Default.OutputPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "SpotifyWebRecorder");
                if (!Directory.Exists(Settings.Default.OutputPath))
                    Directory.CreateDirectory(Settings.Default.OutputPath);
                Settings.Default.Save();
            }

            return Settings.Default.OutputPath;
        }
        public static void SetDefaultOutputPath(string outputPath)
        {
            Settings.Default.OutputPath = outputPath;
            Settings.Default.Save();
        }
        public static string GetDefaultDevice()
        {
            return Settings.Default.DefaultDevice;
            
        }
        public static void SetDefaultDevice(string device)
        {
            Settings.Default.DefaultDevice = device;
            Settings.Default.Save();
        }
        public static int GetDefaultBitrate()
        {
            return Settings.Default.Bitrate;
        }
        public static void SetDefaultThreshold(int threshold)
        {
            Settings.Default.DeleteThreshold = threshold;
            Settings.Default.Save();
        }
        public static int GetDefaultThreshold()
        {
            return Settings.Default.DeleteThreshold;

        }
        public static void SetDefaultThresholdEnabled(bool threshold)
        {
            Settings.Default.DeleteThresholdEnabled = threshold;
            Settings.Default.Save();
        }
        public static bool GetDefaultThresholdEnabled()
        {
            return Settings.Default.DeleteThresholdEnabled;

        }
		public static void SetDefaultMuteAdsEnabled( bool mute )
		{
			Settings.Default.MuteAds  = mute;
			Settings.Default.Save();
		}
		public static bool GetDefaultMuteAdsEnabled()
		{
			return Settings.Default.MuteAds;

		}
		public static void SetDefaultBitrate( int bitrate )
        {
            Settings.Default.Bitrate = bitrate;
            Settings.Default.Save();
        }
        public static Mp3Tag ExtractMp3Tag(string song)
        {
			/*
            string[] split = song.Split(new[] { "–" }, 2, StringSplitOptions.RemoveEmptyEntries);
				Mp3Tag tag = new Mp3Tag(
                split.Length > 1 ? split[1] : string.Empty,
                split[0]
                );
            return tag;
			 * */

			Match match = Regex.Match( song, @"(.*?) - (.*)$", RegexOptions.IgnoreCase );
			if( match.Success )
			{
				Console.WriteLine( "Title: " + match.Groups[2].Value );
				Console.WriteLine( "Artist: " + match.Groups[1].Value );
			}

			Mp3Tag tag = new Mp3Tag(
				match.Groups[2].Value,
				match.Groups[1].Value
				);
			return tag;

        }

		public static string GetDefaultUserAgent()
		{
			return Settings.Default.UserAgent;
		}
		public static void SetDefaultUserAgent( string ua )
		{
			Settings.Default.UserAgent = ua;
			Settings.Default.Save();
		}

		public static string GetDefaultURL()
		{
			return Settings.Default.URL;
		}
		public static void SetDefaultURL( string url )
		{
			Settings.Default.URL = url;
			Settings.Default.Save();
		}

		public static int GetDefaultPlayIndicationChar()
		{
			return Settings.Default.PlayIndicationChar;
		}
		public static void SetDefaultURL( int ch )
		{
			Settings.Default.PlayIndicationChar = ch;
			Settings.Default.Save();
		}

	}
}