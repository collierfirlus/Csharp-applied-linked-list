using System;
using System.Collections.Generic;
using System.Text;

namespace CollierFirlus_1322Lab14
{
    class BluRayDisc
    {
        string title, director;
        int yearOfRelease;
        public double cost;

        public BluRayDisc() { }
        public BluRayDisc(string title, string director, int yearOfRelease, double cost)
        {
            this.title = title;
            this.director = director;
            this.yearOfRelease = yearOfRelease;
            this.cost = cost;
        }
        public string toString()
        {
            return "$" + cost + " " + yearOfRelease + " " + title + ", " + director;
        }
    }
}
