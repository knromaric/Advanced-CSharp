using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Demo
{
    public class YouTubeApi
    {

        public List<Video> GetVideos(string url)
        {
            try
            {
                //access youtube webservice
                // read the data
                // create a list of video objects
                throw new Exception("Oops some low level Youtube error");

            }
            catch (Exception ex)
            {

                throw new YoutubeException("Could not fetch the videos from Youtube", ex);
            }

            
            
        }
    }
}
