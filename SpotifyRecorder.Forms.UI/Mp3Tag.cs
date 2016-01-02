namespace SpotifyWebRecorder.Forms.UI
{
    public class Mp3Tag
    {
        public string Title { get; set; }
        public string Artist { get; set; }
		public string TrackUri { get; set; }

        public Mp3Tag(string title, string artist, string trackUri)
        {
            Title = title;
            Artist = artist;
			TrackUri = trackUri;
        }
    }
}