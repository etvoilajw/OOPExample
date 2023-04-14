using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    public class Youtuber : Creator
    {
        public override void Create()
        {
            if(CreativityLevel >= 50 && Energy >= 50)
            {
                this.BrainstormVideoIdeas();
                this.CreateScript();
                this.VideoScript();
                this.EditingVideo();
                this.RenderingVideo();
            }
            else
            {
                throw new Exception("Cannot create a video. Out of ideas and/or tired");
            }
        }

        private void BrainstormVideoIdeas()
        {
            CreativityLevel = CreativityLevel - 5;
            Energy = Energy - 5;
            Console.WriteLine("Brainstorming video ideas...");

        }
        private void CreateScript()
        {
            CreativityLevel = CreativityLevel - 5;
            Energy = Energy - 5;
            Console.WriteLine("Creating a video script...");

        }

        private void VideoScript()
        {
            CreativityLevel = CreativityLevel - 1;
            Energy = Energy - 10;
            Console.WriteLine("Videotaping myself executing the script...");

        }

        private void EditingVideo()
        {
            CreativityLevel = CreativityLevel - 5;
            Energy = Energy - 5;
            Console.WriteLine("Editing the video...");

        }

        private void RenderingVideo()
        {
            CreativityLevel = CreativityLevel - 1;
            Energy = Energy - 1;
            Console.WriteLine("Rendering the video...");

        }


    }
}
