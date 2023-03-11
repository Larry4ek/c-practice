using System;


namespace zad3.MyInfo
{
    internal class MyInfo
    {
        public event Action<string> Act;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {

                if (_name != value)
                {
                    _name = value;
                    Act($"Имя было изменено на {_name}");
                    return;
                }
                Act($"Имя не изменилось !");
            }
        }
        public MyInfo(string name)
        {
            _name = name;
        }
        public void NameWasChanged(string name)
        {
            if (name != _name)
            {
                _name = name;
                Act($"Имя было изменено на {name}");
                return;
            }
            Act($"Имя не было изменено !");
        }
    }
}