using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Media_List
{
    //Mother class for all list items which has all characteristics that they share.
    public abstract class Media
    {
        protected String title;
        protected int year;

        //Constructor that gives object its characteristics
        public Media(string title, int year)
        {
            this.title = title;
            this.year = year;
        }

        //Method that lets you get the object's title without altering the object
        public String getTitle()
        {
            return this.title;
        }

        //Method that lets you get the object's year without altering the object
        public int getYear()
        {
            return this.year;
        }

        //Method to obtain object information after subclass has been specified.
        public abstract String getInfo();

    }




    //Class "Movie", Inherits from Media, and has the "duration" attribute.
    public class Movie : Media
    {
        private int duration;

        //Constructor that gives object its characteristics
        public Movie(String title, int year, int duration) : base(title, year)
        {
            this.duration = duration;
        }
        //Method that lets you get the object's duration without altering the object
        public int getDuration()
        {
            return this.duration;
        }

        public override string getInfo()
        {
            return base.title + " / " + base.year + " / Duration: " + this.duration + "m"; 
        }
    }




    //Class "TV_Show", Inherits from Media, and has the "episodes" attribute.
    public class TV_Show : Media
    {
        private int episodes;

        //Constructor that gives object its characteristics
        public TV_Show(String title, int year, int episodes) : base(title, year)
        {
            this.episodes = episodes;
        }


        //Method that lets you get the object's episodes without altering the object
        public int getEpisodes()
        {
            return this.episodes;
        }

        public override string getInfo()
        {
            return base.title + " / " + base.year + " / Episodes: " + this.episodes;
        }
    }
}
