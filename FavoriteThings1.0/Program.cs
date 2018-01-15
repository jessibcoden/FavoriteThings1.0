using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings1._0
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class FavMuppet
    {
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        private string _favTrait;
        public string FavTrait
        {
            get
            {
                return _favTrait;
            }
            set
            {
                _favTrait = value;
            }
        }

        //CONSTRUCTOR METHOD:
        public FavMuppet(string muppetName)
        {
            _firstName = muppetName;
        }

        //METHOD:
        public bool PostFavMuppet(string muppetName)
        {
            _firstName = muppetName;
            return true;
        }
    }



    class FavChild
    {
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        private int _childAge;
        public int ChildAge
        {
            get
            {
                return _childAge;
            }
            set
            {
                _childAge = value;
            }
        }
    }

    class FavClassmate
    {

        private string _classmateName = Console.ReadLine();
        public string ClassmateName
        {
            get
            {
                return _classmateName;
            }
            set
            {
                _classmateName = value;
            }
        }

        private int _classmateMaturityAge;
        public int ClassmateMaturityAge
        {
            get
            {
                return _classmateMaturityAge;
            }
            set
            {
                _classmateMaturityAge = value;
            }
        }
    }
}



