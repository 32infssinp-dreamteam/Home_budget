using System.Drawing;

namespace Models.Models
{
    public class Category : BusinessEntity
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _colorText;
        public string ColorText
        {
            get => _colorText;
            set
            {
                if (_colorText != value)
                {
                    _colorText = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private Color _color;

        public Color Color
        {
            get => _color;
            set
            {
                if (_color != value)
                {
                    _color = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}