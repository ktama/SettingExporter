using System;

namespace DataType
{
    public class IntDataType : BaseDataType
    {
        private int? item;

        public int? Item
        {
            get { return item; }
            set
            {
                if (Validate(value))
                {
                    item = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Display
        {
            get { return item?.ToString(); }
            set
            {
                try
                {
                    item = int.Parse(value);
                }
                catch (Exception)
                {
                }
                finally
                {
                    NotifyPropertyChanged();
                }
            }
        }
        public Predicate<int?> Validate { get; set; } = (value) => { return true; };

    }
}
