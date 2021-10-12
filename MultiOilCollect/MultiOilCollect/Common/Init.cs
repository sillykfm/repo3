using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOilCollect
{
    public delegate void ChangeChannelDel(List<Channel> value);
    public class Init
    {
        public static int selectedIndex = 0;
        public static List<Connect> connects = new List<Connect>();

        public static event ChangeChannelDel channelChangeEvent;
        private static List<Channel> _channels = new List<Channel>();
        public static List<Channel> GetChannels
        {
            get { return _channels; }
            set
            {
                if (_channels != value)
                {
                    channelChangeEvent(value);
                }
                _channels = value;
            }
        }

        public delegate void ChangeDelegate(int value);
        public static event ChangeDelegate changeEvent;
        private static int _macNum;
        public static int MacNum
        {
            get { return _macNum; }
            set 
            {
                if (_macNum != value)
                {
                    changeEvent(value);
                }
                _macNum = value;
            }
        }
    }
}
