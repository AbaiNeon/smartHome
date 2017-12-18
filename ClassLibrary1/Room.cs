using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    // Массив устройств, тип помещения
    public class Room
    {
        public string Name { get; set; }
        private List<Device> _devicesinRoom;
        
        public Room()
        {
            _devicesinRoom = new List<Device>();
            
        }

        //public ArrayList DevicesInRoom
        //{
        //    get
        //    {
        //        return _devicesinRoom;
        //    }
        //    set
        //    {

        //        _devicesinRoom = value;
        //    }
        //}

        public void AddDeviceToList(Device device)
        {
            _devicesinRoom.Add(device);
        }
        public Device GetDeviceFromList(int index)
        {
            return (_devicesinRoom[index]);
        }
        public bool isEmptyListOfDevises()
        {
            return _devicesinRoom.Count == 0;
                
        }
        public int countOfDevisesInList()
        {
            return _devicesinRoom.Count;

        }
    }
}
