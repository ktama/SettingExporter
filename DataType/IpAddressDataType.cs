using System;
using System.Net;

namespace DataType
{
    public class IpAddressDataType : BaseDataType
    {
        private IPAddress item;

        public IPAddress Item
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
                    item = IPAddress.Parse(value);
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
        public Predicate<IPAddress> Validate { get; set; } = (value) => { return true; };

    }
}
