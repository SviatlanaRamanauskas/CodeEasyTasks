using System;
using This;

namespace Properties
{
    class Box
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }


    class ReplaceMethodsWithProperties
    {
        private Box _myBox;

        public Box MyBox
        {
            get
            {
                return _myBox;
            }
            private set
            {
                if ((value.Width > 0) && (value.Height > 0))
                {
                    _myBox = value;
                }
            }      
        }

        public char MyFavoriteLetter { get; private set; }
    }
}

/*    class Box
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    class ReplaceMethodsWithProperties
    {
        private Box _myBox;

        public Box GetMyBox()
        {
            return _myBox;
        }

        private void SetMyBox(Box box)
        {
            if ((box.Width > 0) && (box.Height > 0))
            {
                _myBox = box;
            }
        }

        private char _myFavoriteLetter;

        public char GetMyFavoriteLetter()
        {
            return _myFavoriteLetter;
        }

        private void SetMyFavoriteLetter(char letter)
        {
            _myFavoriteLetter = letter;
        }*/